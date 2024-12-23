namespace Proje_Ödevi
{
    partial class ProjeEkleme
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
            this.labelad = new System.Windows.Forms.Label();
            this.labelstartdate = new System.Windows.Forms.Label();
            this.labelfinishdate = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.dtpbaşlangıçtarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpbitiştarihi = new System.Windows.Forms.DateTimePicker();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(84, 67);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(138, 32);
            this.labelad.TabIndex = 0;
            this.labelad.Text = "Proje Adı:";
            // 
            // labelstartdate
            // 
            this.labelstartdate.AutoSize = true;
            this.labelstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelstartdate.Location = new System.Drawing.Point(84, 129);
            this.labelstartdate.Name = "labelstartdate";
            this.labelstartdate.Size = new System.Drawing.Size(226, 32);
            this.labelstartdate.TabIndex = 1;
            this.labelstartdate.Text = "Başlangıç Tarihi:";
            // 
            // labelfinishdate
            // 
            this.labelfinishdate.AutoSize = true;
            this.labelfinishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelfinishdate.Location = new System.Drawing.Point(84, 190);
            this.labelfinishdate.Name = "labelfinishdate";
            this.labelfinishdate.Size = new System.Drawing.Size(156, 32);
            this.labelfinishdate.TabIndex = 2;
            this.labelfinishdate.Text = "Bitiş Tarihi:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(335, 65);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(216, 34);
            this.txtad.TabIndex = 3;
            this.txtad.TextChanged += new System.EventHandler(this.textBoxad_TextChanged);
            // 
            // dtpbaşlangıçtarihi
            // 
            this.dtpbaşlangıçtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpbaşlangıçtarihi.Location = new System.Drawing.Point(335, 127);
            this.dtpbaşlangıçtarihi.Name = "dtpbaşlangıçtarihi";
            this.dtpbaşlangıçtarihi.Size = new System.Drawing.Size(216, 34);
            this.dtpbaşlangıçtarihi.TabIndex = 4;
            this.dtpbaşlangıçtarihi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpbitiştarihi
            // 
            this.dtpbitiştarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpbitiştarihi.Location = new System.Drawing.Point(335, 188);
            this.dtpbitiştarihi.Name = "dtpbitiştarihi";
            this.dtpbitiştarihi.Size = new System.Drawing.Size(216, 34);
            this.dtpbitiştarihi.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(472, 304);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(194, 49);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // ProjeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.dtpbitiştarihi);
            this.Controls.Add(this.dtpbaşlangıçtarihi);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.labelfinishdate);
            this.Controls.Add(this.labelstartdate);
            this.Controls.Add(this.labelad);
            this.Name = "ProjeEkleme";
            this.Text = "ProjeEkleme";
            this.Load += new System.EventHandler(this.ProjeEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.Label labelstartdate;
        private System.Windows.Forms.Label labelfinishdate;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.DateTimePicker dtpbaşlangıçtarihi;
        private System.Windows.Forms.DateTimePicker dtpbitiştarihi;
        private System.Windows.Forms.Button btnkaydet;
    }
}