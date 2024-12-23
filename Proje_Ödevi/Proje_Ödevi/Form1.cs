using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection(@"Data Source=KILIC;Initial Catalog=Proje;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan sütunun ProjectId olduğunu kontrol et
            if (e.RowIndex >= 0)
            {
                // Detaylar butonuna tıklanırsa
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DetaylarButton")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString(); // ID sütununu alın
                    ProjeDetaylariniYukle(id); // Detayları yükle
                    panel1.Visible = false;
                    pnlDetaylar.Visible = true; // Paneli görünür yap
                }

                // Sil butonuna tıklanırsa
                if (dataGridView1.Columns[e.ColumnIndex].Name == "SilButton")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString(); // ID sütununu alın
                    SilKayit(id); // Kaydı sil
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            GörevDurumuGüncelle();
            TabloyuYukle();
            ButonSütunlarıEkle();
        }

        private void TabloyuYukle()
        {
                SqlCommand komut = new SqlCommand("exec Listele", bağlanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    // Eğer veri varsa DataGridView'e bağla
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    // Eğer veri yoksa kullanıcıyı bilgilendir
                    MessageBox.Show("Henüz herhangi bir proje bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            bağlanti.Close();           
        }

        private void ButonSütunlarıEkle()
        {
            // Detaylar buton sütunu
            DataGridViewButtonColumn detaylarButton = new DataGridViewButtonColumn
            {
                HeaderText = "Detaylar",
                Text = "Detaylar",
                UseColumnTextForButtonValue = true,
                Name = "DetaylarButton"
            };
            dataGridView1.Columns.Add(detaylarButton);

            // Sil buton sütunu
            DataGridViewButtonColumn silButton = new DataGridViewButtonColumn
            {
                HeaderText = "Sil",
                Text = "Sil",
                UseColumnTextForButtonValue = true,
                Name = "SilButton"
            };
            dataGridView1.Columns.Add(silButton);

            DataGridViewButtonColumn silButton2 = new DataGridViewButtonColumn
            {
                HeaderText = "Sil",
                Text = "Sil",
                UseColumnTextForButtonValue = true,
                Name = "SilButton"
            };
            dataGridViewProjeGörev.Columns.Add(silButton2);
        }

        private void SilKayit(string id)
        {

                bağlanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Projects WHERE ProjectId = @ID", bağlanti);
                komut.Parameters.AddWithValue("@ID", id);
                komut.ExecuteNonQuery();                

                bağlanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.");
                TabloyuYukle(); // Tablonun güncellenmesi için yeniden yükleyin           
           
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            ProjeEkleme ekleForm = new ProjeEkleme();
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                // Proje başarıyla eklendikten sonra tabloyu güncelle
                TabloyuYukle();
            }

        }

        private void ProjeDetaylariniYukle(string projeId)
        {
            try
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Projects WHERE ProjectId = @ID", bağlanti);
                komut.Parameters.AddWithValue("@ID", projeId);

                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    // Paneldeki kontrolleri doldurun
                    lblProjeAdi.Text = reader["ProjectName"].ToString();
                    lblProjeAdi.Tag = reader["ProjectId"];
                    txtBaslangicTarihi.Text = reader["StartDate"].ToString();
                    txtBitisTarihi.Text = reader["EndDate"].ToString();
                    // Diğer detayları da ekleyin
                }
                reader.Close();

                GörevleriYukle(projeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detaylar yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                bağlanti.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            pnlDetaylar.Visible = false;
            panel1.Visible = true;
        }


        private void GörevleriYukle(string projeId)
        {
            try
            {
                SqlCommand komut = new SqlCommand("proje_detay", bağlanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ProjectId", projeId);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewProjeGörev.DataSource = dt;

                if (dataGridViewProjeGörev.Columns.Contains("TaskId"))
                {
                    dataGridViewProjeGörev.Columns["TaskId"].Visible = false;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bu projeye ait görev bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görevler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }




        private void dataGridViewProjeGörev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer tıklanan sütun "SilButton" ise
            if (dataGridViewProjeGörev.Columns[e.ColumnIndex].Name == "SilButton")
            {
                // Silinecek görev ID'sini alıyoruz
                string görevId = dataGridViewProjeGörev.Rows[e.RowIndex].Cells["TaskId"].Value.ToString(); // TaskId'yi alıyoruz

                // Silme işlemi için SilGörev metodunu çağırıyoruz
                SilGörev(görevId);
            }
        }



        private void pnlDetaylar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGörevEkle_Click(object sender, EventArgs e)
        {
            // Seçili bir satır var mı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Proje ID'sini seçilen satırdan al
                string projeId = dataGridView1.SelectedRows[0].Cells["ProjectId"].Value.ToString();

                // GörevEkleme formunu oluşturup, projeId parametresini geçir
                GörevEkleme ekleForm = new GörevEkleme(projeId);
                ekleForm.ShowDialog();
                GörevDurumuGüncelle();
                GörevleriYukle(projeId);
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SilGörev(string görevId)
        {
            try
            {
                // Veritabanına bağlanıyoruz
                bağlanti.Open();

                // Görevi silen SQL komutunu çalıştırıyoruz
                SqlCommand komut = new SqlCommand("DELETE FROM Tasks WHERE TaskId = @ID", bağlanti);
                komut.Parameters.AddWithValue("@ID", görevId);
                komut.ExecuteNonQuery();

                MessageBox.Show("Görev başarıyla silindi.");

                // Silme işlemi tamamlandıktan sonra görevleri tekrar yükle
                string projeId = lblProjeAdi.Tag.ToString(); // ProjeId'yi alıyoruz
                GörevleriYukle(projeId); // Güncel görevleri yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev silinirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                bağlanti.Close();
            }
        }


        private void GörevDurumuGüncelle()
        {
            try
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("GüncelleGörevDurumu", bağlanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.ExecuteNonQuery();
                MessageBox.Show("Görev durumları başarıyla güncellendi.");

                if (lblProjeAdi.Tag != null)
                {
                    string projeId = lblProjeAdi.Tag.ToString();
                    GörevleriYukle(projeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                bağlanti.Close();
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            panel1.Hide();
           pnlCalısanlar.Show();
        }

    }
}
