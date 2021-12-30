
namespace Forms
{
    partial class AccountScreen
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.txtKayitTel = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKayitEMail = new System.Windows.Forms.TextBox();
            this.txtKayitSoyisim = new System.Windows.Forms.TextBox();
            this.txtKayitİsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label12.Location = new System.Drawing.Point(33, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Telefon Numarası";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(33, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Şifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(37, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(37, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(37, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Soyisim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(37, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "İsim";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Location = new System.Drawing.Point(207, 496);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(134, 40);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnOnay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOnay.Location = new System.Drawing.Point(37, 496);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(134, 40);
            this.btnOnay.TabIndex = 20;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // txtKayitTel
            // 
            this.txtKayitTel.Location = new System.Drawing.Point(37, 442);
            this.txtKayitTel.Name = "txtKayitTel";
            this.txtKayitTel.Size = new System.Drawing.Size(304, 27);
            this.txtKayitTel.TabIndex = 19;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(37, 381);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(304, 27);
            this.txtKayitSifre.TabIndex = 18;
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(37, 320);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(304, 27);
            this.txtKayitKullaniciAdi.TabIndex = 17;
            // 
            // txtKayitEMail
            // 
            this.txtKayitEMail.Location = new System.Drawing.Point(37, 259);
            this.txtKayitEMail.Name = "txtKayitEMail";
            this.txtKayitEMail.Size = new System.Drawing.Size(304, 27);
            this.txtKayitEMail.TabIndex = 16;
            // 
            // txtKayitSoyisim
            // 
            this.txtKayitSoyisim.Location = new System.Drawing.Point(37, 198);
            this.txtKayitSoyisim.Name = "txtKayitSoyisim";
            this.txtKayitSoyisim.Size = new System.Drawing.Size(304, 27);
            this.txtKayitSoyisim.TabIndex = 15;
            // 
            // txtKayitİsim
            // 
            this.txtKayitİsim.Location = new System.Drawing.Point(37, 129);
            this.txtKayitİsim.Name = "txtKayitİsim";
            this.txtKayitİsim.Size = new System.Drawing.Size(304, 27);
            this.txtKayitİsim.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bilgileri Güncelle";
            // 
            // AccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(391, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtKayitTel);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.txtKayitKullaniciAdi);
            this.Controls.Add(this.txtKayitEMail);
            this.Controls.Add(this.txtKayitSoyisim);
            this.Controls.Add(this.txtKayitİsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountScreen";
            this.Text = "AccountScreen";
            this.Load += new System.EventHandler(this.AccountScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.TextBox txtKayitTel;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.TextBox txtKayitEMail;
        private System.Windows.Forms.TextBox txtKayitSoyisim;
        private System.Windows.Forms.TextBox txtKayitİsim;
        private System.Windows.Forms.Label label1;
    }
}