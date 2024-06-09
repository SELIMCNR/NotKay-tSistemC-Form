namespace WindowsFormsApp1
{
    partial class Frm_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.Btn_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_ogretmensifre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ NUMARA:";
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(146, 23);
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(100, 20);
            this.mskNumara.TabIndex = 1;
            // 
            // Btn_giris
            // 
            this.Btn_giris.Location = new System.Drawing.Point(146, 94);
            this.Btn_giris.Name = "Btn_giris";
            this.Btn_giris.Size = new System.Drawing.Size(100, 23);
            this.Btn_giris.TabIndex = 2;
            this.Btn_giris.Text = "GİRİŞ YAP";
            this.Btn_giris.UseVisualStyleBackColor = true;
            this.Btn_giris.Click += new System.EventHandler(this.Ogr_giris);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÖĞRETMEN ŞİFRE:";
            // 
            // msk_ogretmensifre
            // 
            this.msk_ogretmensifre.Location = new System.Drawing.Point(146, 49);
            this.msk_ogretmensifre.Name = "msk_ogretmensifre";
            this.msk_ogretmensifre.PasswordChar = '*';
            this.msk_ogretmensifre.Size = new System.Drawing.Size(100, 20);
            this.msk_ogretmensifre.TabIndex = 1;
            this.msk_ogretmensifre.TextChanged += new System.EventHandler(this.msk_ogretmensifre_TextChanged);
            // 
            // Frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(296, 185);
            this.Controls.Add(this.Btn_giris);
            this.Controls.Add(this.msk_ogretmensifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskNumara);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Giris";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.Button Btn_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_ogretmensifre;
    }
}

