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
    public partial class ProjeEkleme : Form
    {
        public ProjeEkleme()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection(@"Data Source=KILIC;Initial Catalog=Proje;Integrated Security=True");
        private void ProjeEkleme_Load(object sender, EventArgs e)
        {

        }

        private void textBoxad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (bağlanti.State == ConnectionState.Closed)
            {
                bağlanti.Open();
            }


            SqlCommand komut = new SqlCommand("insert into  Projects (ProjectName,StartDate,EndDate) values (@projectname,@startdate,@enddate)",bağlanti);
            komut.Parameters.AddWithValue("@projectname", txtad.Text);
            komut.Parameters.AddWithValue("@startdate", dtpbaşlangıçtarihi.Value);
            komut.Parameters.AddWithValue("@enddate", dtpbitiştarihi.Value);

            komut.ExecuteNonQuery();

            bağlanti.Close();

            MessageBox.Show("Başarıyla Eklendi");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
