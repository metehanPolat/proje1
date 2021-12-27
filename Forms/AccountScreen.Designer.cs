
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
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Location = new System.Drawing.Point(77, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Location = new System.Drawing.Point(77, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Şifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(77, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(77, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "e mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(77, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Soyisim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(77, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "İsim";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(190, 433);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(79, 31);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(77, 433);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(86, 31);
            this.btnOnay.TabIndex = 20;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // txtKayitTel
            // 
            this.txtKayitTel.Location = new System.Drawing.Point(77, 377);
            this.txtKayitTel.Name = "txtKayitTel";
            this.txtKayitTel.Size = new System.Drawing.Size(192, 27);
            this.txtKayitTel.TabIndex = 19;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(77, 321);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(192, 27);
            this.txtKayitSifre.TabIndex = 18;
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(77, 266);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(192, 27);
            this.txtKayitKullaniciAdi.TabIndex = 17;
            // 
            // txtKayitEMail
            // 
            this.txtKayitEMail.Location = new System.Drawing.Point(77, 206);
            this.txtKayitEMail.Name = "txtKayitEMail";
            this.txtKayitEMail.Size = new System.Drawing.Size(192, 27);
            this.txtKayitEMail.TabIndex = 16;
            // 
            // txtKayitSoyisim
            // 
            this.txtKayitSoyisim.Location = new System.Drawing.Point(77, 146);
            this.txtKayitSoyisim.Name = "txtKayitSoyisim";
            this.txtKayitSoyisim.Size = new System.Drawing.Size(192, 27);
            this.txtKayitSoyisim.TabIndex = 15;
            // 
            // txtKayitİsim
            // 
            this.txtKayitİsim.Location = new System.Drawing.Point(77, 85);
            this.txtKayitİsim.Name = "txtKayitİsim";
            this.txtKayitİsim.Size = new System.Drawing.Size(192, 27);
            this.txtKayitİsim.TabIndex = 14;
            // 
            // AccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(338, 516);
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
    }
}