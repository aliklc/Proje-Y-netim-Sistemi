namespace Proje_Ödevi
{
    partial class GörevEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGörevAd = new System.Windows.Forms.Label();
            this.lblÇalışan = new System.Windows.Forms.Label();
            this.txtGörevAdı = new System.Windows.Forms.TextBox();
            this.cmbÇalışan = new System.Windows.Forms.ComboBox();
            this.btnGörevEkle = new System.Windows.Forms.Button();
            this.lblbaşlangıç = new System.Windows.Forms.Label();
            this.lblbitiş = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblGörevAd
            // 
            this.lblGörevAd.AutoSize = true;
            this.lblGörevAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGörevAd.Location = new System.Drawing.Point(65, 60);
            this.lblGörevAd.Name = "lblGörevAd";
            this.lblGörevAd.Size = new System.Drawing.Size(148, 32);
            this.lblGörevAd.TabIndex = 0;
            this.lblGörevAd.Text = "Görev Adı:";
            // 
            // lblÇalışan
            // 
            this.lblÇalışan.AutoSize = true;
            this.lblÇalışan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇalışan.Location = new System.Drawing.Point(65, 257);
            this.lblÇalışan.Name = "lblÇalışan";
            this.lblÇalışan.Size = new System.Drawing.Size(118, 32);
            this.lblÇalışan.TabIndex = 1;
            this.lblÇalışan.Text = "Çalışan:";
            // 
            // txtGörevAdı
            // 
            this.txtGörevAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGörevAdı.Location = new System.Drawing.Point(317, 54);
            this.txtGörevAdı.Name = "txtGörevAdı";
            this.txtGörevAdı.Size = new System.Drawing.Size(233, 38);
            this.txtGörevAdı.TabIndex = 3;
            // 
            // cmbÇalışan
            // 
            this.cmbÇalışan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbÇalışan.FormattingEnabled = true;
            this.cmbÇalışan.Location = new System.Drawing.Point(317, 250);
            this.cmbÇalışan.Name = "cmbÇalışan";
            this.cmbÇalışan.Size = new System.Drawing.Size(233, 39);
            this.cmbÇalışan.TabIndex = 4;
            // 
            // btnGörevEkle
            // 
            this.btnGörevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörevEkle.Location = new System.Drawing.Point(551, 352);
            this.btnGörevEkle.Name = "btnGörevEkle";
            this.btnGörevEkle.Size = new System.Drawing.Size(199, 56);
            this.btnGörevEkle.TabIndex = 5;
            this.btnGörevEkle.Text = "Kaydet";
            this.btnGörevEkle.UseVisualStyleBackColor = true;
            this.btnGörevEkle.Click += new System.EventHandler(this.btnGörevEkle_Click);
            // 
            // lblbaşlangıç
            // 
            this.lblbaşlangıç.AutoSize = true;
            this.lblbaşlangıç.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaşlangıç.Location = new System.Drawing.Point(65, 125);
            this.lblbaşlangıç.Name = "lblbaşlangıç";
            this.lblbaşlangıç.Size = new System.Drawing.Size(226, 32);
            this.lblbaşlangıç.TabIndex = 6;
            this.lblbaşlangıç.Text = "Başlangıç Tarihi:";
            // 
            // lblbitiş
            // 
            this.lblbitiş.AutoSize = true;
            this.lblbitiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbitiş.Location = new System.Drawing.Point(65, 193);
            this.lblbitiş.Name = "lblbitiş";
            this.lblbitiş.Size = new System.Drawing.Size(156, 32);
            this.lblbitiş.TabIndex = 7;
            this.lblbitiş.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(317, 119);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(233, 38);
            this.dtpBaslangicTarihi.TabIndex = 8;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitisTarihi.Location = new System.Drawing.Point(317, 187);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(233, 38);
            this.dtpBitisTarihi.TabIndex = 9;
            // 
            // GörevEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.lblbitiş);
            this.Controls.Add(this.lblbaşlangıç);
            this.Controls.Add(this.btnGörevEkle);
            this.Controls.Add(this.cmbÇalışan);
            this.Controls.Add(this.txtGörevAdı);
            this.Controls.Add(this.lblÇalışan);
            this.Controls.Add(this.lblGörevAd);
            this.Name = "GörevEkleme";
            this.Text = "GörevEkleme";
            this.Load += new System.EventHandler(this.GörevEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGörevAd;
        private System.Windows.Forms.Label lblÇalışan;
        private System.Windows.Forms.TextBox txtGörevAdı;
        private System.Windows.Forms.ComboBox cmbÇalışan;
        private System.Windows.Forms.Button btnGörevEkle;
        private System.Windows.Forms.Label lblbaşlangıç;
        private System.Windows.Forms.Label lblbitiş;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
    }
}