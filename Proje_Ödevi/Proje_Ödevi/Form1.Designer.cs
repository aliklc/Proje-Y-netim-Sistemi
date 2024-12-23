namespace Proje_Ödevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlDetaylar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGörevEkle = new System.Windows.Forms.Button();
            this.dataGridViewProjeGörev = new System.Windows.Forms.DataGridView();
            this.btnTamam = new System.Windows.Forms.Button();
            this.txtBitisTarihi = new System.Windows.Forms.TextBox();
            this.txtBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.pnlCalısanlar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDetaylar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjeGörev)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.btnCalisanlar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnProjeEkle);
            this.panel1.Controls.Add(this.pnlCalısanlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 767);
            this.panel1.TabIndex = 0;
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProjeEkle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnProjeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjeEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProjeEkle.Location = new System.Drawing.Point(31, 49);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(228, 59);
            this.btnProjeEkle.TabIndex = 0;
            this.btnProjeEkle.Text = "Proje Ekle";
            this.btnProjeEkle.UseVisualStyleBackColor = false;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 527);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlDetaylar
            // 
            this.pnlDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetaylar.AutoSize = true;
            this.pnlDetaylar.Controls.Add(this.dataGridViewProjeGörev);
            this.pnlDetaylar.Controls.Add(this.label3);
            this.pnlDetaylar.Controls.Add(this.label2);
            this.pnlDetaylar.Controls.Add(this.label1);
            this.pnlDetaylar.Controls.Add(this.btnGörevEkle);
            this.pnlDetaylar.Controls.Add(this.btnTamam);
            this.pnlDetaylar.Controls.Add(this.txtBitisTarihi);
            this.pnlDetaylar.Controls.Add(this.txtBaslangicTarihi);
            this.pnlDetaylar.Controls.Add(this.lblProjeAdi);
            this.pnlDetaylar.Location = new System.Drawing.Point(0, 0);
            this.pnlDetaylar.Name = "pnlDetaylar";
            this.pnlDetaylar.Size = new System.Drawing.Size(1533, 770);
            this.pnlDetaylar.TabIndex = 2;
            this.pnlDetaylar.Visible = false;
            this.pnlDetaylar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetaylar_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bitiş Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Başlangıç Tarihi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Projenin Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnGörevEkle
            // 
            this.btnGörevEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGörevEkle.AutoSize = true;
            this.btnGörevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörevEkle.Location = new System.Drawing.Point(1272, 358);
            this.btnGörevEkle.Name = "btnGörevEkle";
            this.btnGörevEkle.Size = new System.Drawing.Size(237, 69);
            this.btnGörevEkle.TabIndex = 5;
            this.btnGörevEkle.Text = "Projeye Yeni Görev Ekle";
            this.btnGörevEkle.UseVisualStyleBackColor = true;
            this.btnGörevEkle.UseWaitCursor = true;
            this.btnGörevEkle.Click += new System.EventHandler(this.btnGörevEkle_Click);
            // 
            // dataGridViewProjeGörev
            // 
            this.dataGridViewProjeGörev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProjeGörev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjeGörev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjeGörev.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewProjeGörev.Name = "dataGridViewProjeGörev";
            this.dataGridViewProjeGörev.RowHeadersWidth = 51;
            this.dataGridViewProjeGörev.RowTemplate.Height = 24;
            this.dataGridViewProjeGörev.Size = new System.Drawing.Size(1510, 333);
            this.dataGridViewProjeGörev.TabIndex = 4;
            this.dataGridViewProjeGörev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjeGörev_CellContentClick);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.AutoSize = true;
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(1348, 706);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(161, 52);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.UseWaitCursor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitisTarihi.Location = new System.Drawing.Point(222, 591);
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Size = new System.Drawing.Size(224, 30);
            this.txtBitisTarihi.TabIndex = 2;
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslangicTarihi.Location = new System.Drawing.Point(222, 506);
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
            this.txtBaslangicTarihi.Size = new System.Drawing.Size(224, 30);
            this.txtBaslangicTarihi.TabIndex = 1;
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAdi.Location = new System.Drawing.Point(217, 433);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(144, 29);
            this.lblProjeAdi.TabIndex = 0;
            this.lblProjeAdi.Text = "Projenin Adı";
            this.lblProjeAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalisanlar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCalisanlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanlar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalisanlar.Location = new System.Drawing.Point(31, 174);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(228, 59);
            this.btnCalisanlar.TabIndex = 2;
            this.btnCalisanlar.Text = "Çalışanlar";
            this.btnCalisanlar.UseVisualStyleBackColor = false;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // pnlCalısanlar
            // 
            this.pnlCalısanlar.Location = new System.Drawing.Point(2, 3);
            this.pnlCalısanlar.Name = "pnlCalısanlar";
            this.pnlCalısanlar.Size = new System.Drawing.Size(1507, 767);
            this.pnlCalısanlar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDetaylar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDetaylar.ResumeLayout(false);
            this.pnlDetaylar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjeGörev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.Panel pnlDetaylar;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.TextBox txtBitisTarihi;
        private System.Windows.Forms.TextBox txtBaslangicTarihi;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridView dataGridViewProjeGörev;
        private System.Windows.Forms.Button btnGörevEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalisanlar;
        private System.Windows.Forms.Panel pnlCalısanlar;
    }
}

