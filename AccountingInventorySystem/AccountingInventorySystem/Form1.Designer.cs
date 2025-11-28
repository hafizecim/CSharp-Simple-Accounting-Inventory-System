namespace AccountingInventorySystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifre_goster = new System.Windows.Forms.CheckBox();
            this.giris = new System.Windows.Forms.Button();
            this.sifremi_unuttum = new System.Windows.Forms.LinkLabel();
            this.kayit_ol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Giriş ve Kayıt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Location = new System.Drawing.Point(94, 58);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(187, 20);
            this.kullanici_adi.TabIndex = 1;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(94, 98);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(187, 20);
            this.sifre.TabIndex = 2;
            this.sifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // sifre_goster
            // 
            this.sifre_goster.AutoSize = true;
            this.sifre_goster.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_goster.Location = new System.Drawing.Point(175, 124);
            this.sifre_goster.Name = "sifre_goster";
            this.sifre_goster.Size = new System.Drawing.Size(106, 19);
            this.sifre_goster.TabIndex = 5;
            this.sifre_goster.Text = "Şifre Görüntüle";
            this.sifre_goster.UseVisualStyleBackColor = true;
            this.sifre_goster.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(95, 163);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(110, 33);
            this.giris.TabIndex = 6;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sifremi_unuttum
            // 
            this.sifremi_unuttum.AutoSize = true;
            this.sifremi_unuttum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremi_unuttum.Location = new System.Drawing.Point(104, 215);
            this.sifremi_unuttum.Name = "sifremi_unuttum";
            this.sifremi_unuttum.Size = new System.Drawing.Size(93, 15);
            this.sifremi_unuttum.TabIndex = 7;
            this.sifremi_unuttum.TabStop = true;
            this.sifremi_unuttum.Text = "Şifremi Unuttum";
            this.sifremi_unuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifremi_unuttum_LinkClicked);
            // 
            // kayit_ol
            // 
            this.kayit_ol.AutoSize = true;
            this.kayit_ol.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_ol.Location = new System.Drawing.Point(125, 246);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(51, 15);
            this.kayit_ol.TabIndex = 8;
            this.kayit_ol.TabStop = true;
            this.kayit_ol.Text = "Kayıt Ol";
            this.kayit_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kayit_ol_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 298);
            this.Controls.Add(this.kayit_ol);
            this.Controls.Add(this.sifremi_unuttum);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.sifre_goster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kullanıcı Giriş/Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sifre_goster;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.LinkLabel sifremi_unuttum;
        private System.Windows.Forms.LinkLabel kayit_ol;
    }
}

