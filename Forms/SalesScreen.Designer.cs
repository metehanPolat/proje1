
namespace Forms
{
    partial class SalesScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatilanUrunler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.pnlSell = new System.Windows.Forms.Panel();
            this.cmbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.pnlUrunListele = new System.Windows.Forms.Panel();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.txtUrunDuzenle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlUrunGuncelle = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuncelleResim = new System.Windows.Forms.Button();
            this.txtGuncelleResim = new System.Windows.Forms.TextBox();
            this.cmbGuncelleUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGuncelleKonum = new System.Windows.Forms.TextBox();
            this.txtGuncelleUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtGuncelleUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtGuncelleUrunAdi = new System.Windows.Forms.TextBox();
            this.pnlSatilanUrunler = new System.Windows.Forms.Panel();
            this.dgvSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.pnlSell.SuspendLayout();
            this.pnlUrunListele.SuspendLayout();
            this.pnlUrunGuncelle.SuspendLayout();
            this.pnlSatilanUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSatilanUrunler);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnUrunSat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 680);
            this.panel1.TabIndex = 0;
            // 
            // btnSatilanUrunler
            // 
            this.btnSatilanUrunler.Location = new System.Drawing.Point(22, 408);
            this.btnSatilanUrunler.Name = "btnSatilanUrunler";
            this.btnSatilanUrunler.Size = new System.Drawing.Size(148, 36);
            this.btnSatilanUrunler.TabIndex = 4;
            this.btnSatilanUrunler.Text = "Satılan Ürünler";
            this.btnSatilanUrunler.UseVisualStyleBackColor = true;
            this.btnSatilanUrunler.Click += new System.EventHandler(this.btnSatilanUrunler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(22, 532);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(148, 37);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(22, 473);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(148, 37);
            this.btnUrunSat.TabIndex = 1;
            this.btnUrunSat.Text = "Ürün Sat";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürünleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListele
            // 
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(0, 90);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.RowHeadersWidth = 51;
            this.dgvListele.RowTemplate.Height = 29;
            this.dgvListele.Size = new System.Drawing.Size(1018, 522);
            this.dgvListele.TabIndex = 1;
            // 
            // pnlSell
            // 
            this.pnlSell.Controls.Add(this.cmbUrunKategorisi);
            this.pnlSell.Controls.Add(this.btnSell);
            this.pnlSell.Controls.Add(this.label5);
            this.pnlSell.Controls.Add(this.label4);
            this.pnlSell.Controls.Add(this.label3);
            this.pnlSell.Controls.Add(this.label2);
            this.pnlSell.Controls.Add(this.label1);
            this.pnlSell.Controls.Add(this.txtKonum);
            this.pnlSell.Controls.Add(this.txtUrunAciklama);
            this.pnlSell.Controls.Add(this.txtUrunFiyati);
            this.pnlSell.Controls.Add(this.txtUrunAdi);
            this.pnlSell.Location = new System.Drawing.Point(365, 32);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.Size = new System.Drawing.Size(1018, 612);
            this.pnlSell.TabIndex = 2;
            this.pnlSell.Visible = false;
            // 
            // cmbUrunKategorisi
            // 
            this.cmbUrunKategorisi.FormattingEnabled = true;
            this.cmbUrunKategorisi.Location = new System.Drawing.Point(372, 146);
            this.cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            this.cmbUrunKategorisi.Size = new System.Drawing.Size(208, 28);
            this.cmbUrunKategorisi.TabIndex = 12;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(333, 423);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(204, 29);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "İşlemi Tamamla";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Konum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategorisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(349, 323);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(204, 27);
            this.txtKonum.TabIndex = 4;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(349, 254);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(204, 27);
            this.txtUrunAciklama.TabIndex = 3;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(349, 192);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(204, 27);
            this.txtUrunFiyati.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(349, 66);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(204, 27);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // pnlUrunListele
            // 
            this.pnlUrunListele.Controls.Add(this.btnUrunDuzenle);
            this.pnlUrunListele.Controls.Add(this.txtUrunDuzenle);
            this.pnlUrunListele.Controls.Add(this.label7);
            this.pnlUrunListele.Controls.Add(this.dgvListele);
            this.pnlUrunListele.Location = new System.Drawing.Point(196, 68);
            this.pnlUrunListele.Name = "pnlUrunListele";
            this.pnlUrunListele.Size = new System.Drawing.Size(1018, 612);
            this.pnlUrunListele.TabIndex = 3;
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Location = new System.Drawing.Point(852, 41);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(134, 24);
            this.btnUrunDuzenle.TabIndex = 4;
            this.btnUrunDuzenle.Text = "Ürünü Düzenle";
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // txtUrunDuzenle
            // 
            this.txtUrunDuzenle.Location = new System.Drawing.Point(662, 38);
            this.txtUrunDuzenle.Name = "txtUrunDuzenle";
            this.txtUrunDuzenle.Size = new System.Drawing.Size(156, 27);
            this.txtUrunDuzenle.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ürün Id :";
            // 
            // pnlUrunGuncelle
            // 
            this.pnlUrunGuncelle.Controls.Add(this.label12);
            this.pnlUrunGuncelle.Controls.Add(this.btnGuncelleResim);
            this.pnlUrunGuncelle.Controls.Add(this.txtGuncelleResim);
            this.pnlUrunGuncelle.Controls.Add(this.cmbGuncelleUrunKategorisi);
            this.pnlUrunGuncelle.Controls.Add(this.btnGuncelle);
            this.pnlUrunGuncelle.Controls.Add(this.label6);
            this.pnlUrunGuncelle.Controls.Add(this.label8);
            this.pnlUrunGuncelle.Controls.Add(this.label9);
            this.pnlUrunGuncelle.Controls.Add(this.label10);
            this.pnlUrunGuncelle.Controls.Add(this.label11);
            this.pnlUrunGuncelle.Controls.Add(this.txtGuncelleKonum);
            this.pnlUrunGuncelle.Controls.Add(this.txtGuncelleUrunAciklama);
            this.pnlUrunGuncelle.Controls.Add(this.txtGuncelleUrunFiyati);
            this.pnlUrunGuncelle.Controls.Add(this.txtGuncelleUrunAdi);
            this.pnlUrunGuncelle.Location = new System.Drawing.Point(1486, 99);
            this.pnlUrunGuncelle.Name = "pnlUrunGuncelle";
            this.pnlUrunGuncelle.Size = new System.Drawing.Size(1018, 612);
            this.pnlUrunGuncelle.TabIndex = 4;
            this.pnlUrunGuncelle.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Resim:";
            // 
            // btnGuncelleResim
            // 
            this.btnGuncelleResim.Location = new System.Drawing.Point(558, 391);
            this.btnGuncelleResim.Name = "btnGuncelleResim";
            this.btnGuncelleResim.Size = new System.Drawing.Size(43, 26);
            this.btnGuncelleResim.TabIndex = 14;
            this.btnGuncelleResim.Text = "***";
            this.btnGuncelleResim.UseVisualStyleBackColor = true;
            this.btnGuncelleResim.Click += new System.EventHandler(this.btnGuncelleResim_Click);
            // 
            // txtGuncelleResim
            // 
            this.txtGuncelleResim.Location = new System.Drawing.Point(347, 390);
            this.txtGuncelleResim.Name = "txtGuncelleResim";
            this.txtGuncelleResim.Size = new System.Drawing.Size(205, 27);
            this.txtGuncelleResim.TabIndex = 13;
            // 
            // cmbGuncelleUrunKategorisi
            // 
            this.cmbGuncelleUrunKategorisi.FormattingEnabled = true;
            this.cmbGuncelleUrunKategorisi.Location = new System.Drawing.Point(349, 140);
            this.cmbGuncelleUrunKategorisi.Name = "cmbGuncelleUrunKategorisi";
            this.cmbGuncelleUrunKategorisi.Size = new System.Drawing.Size(203, 28);
            this.cmbGuncelleUrunKategorisi.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(348, 458);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 29);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Konum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Kategorisi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ürün Adı:";
            // 
            // txtGuncelleKonum
            // 
            this.txtGuncelleKonum.Location = new System.Drawing.Point(349, 323);
            this.txtGuncelleKonum.Name = "txtGuncelleKonum";
            this.txtGuncelleKonum.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleKonum.TabIndex = 4;
            // 
            // txtGuncelleUrunAciklama
            // 
            this.txtGuncelleUrunAciklama.Location = new System.Drawing.Point(349, 254);
            this.txtGuncelleUrunAciklama.Name = "txtGuncelleUrunAciklama";
            this.txtGuncelleUrunAciklama.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleUrunAciklama.TabIndex = 3;
            // 
            // txtGuncelleUrunFiyati
            // 
            this.txtGuncelleUrunFiyati.Location = new System.Drawing.Point(349, 192);
            this.txtGuncelleUrunFiyati.Name = "txtGuncelleUrunFiyati";
            this.txtGuncelleUrunFiyati.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleUrunFiyati.TabIndex = 2;
            // 
            // txtGuncelleUrunAdi
            // 
            this.txtGuncelleUrunAdi.Location = new System.Drawing.Point(349, 66);
            this.txtGuncelleUrunAdi.Name = "txtGuncelleUrunAdi";
            this.txtGuncelleUrunAdi.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleUrunAdi.TabIndex = 0;
            // 
            // pnlSatilanUrunler
            // 
            this.pnlSatilanUrunler.Controls.Add(this.dgvSatilanUrunler);
            this.pnlSatilanUrunler.Location = new System.Drawing.Point(508, 717);
            this.pnlSatilanUrunler.Name = "pnlSatilanUrunler";
            this.pnlSatilanUrunler.Size = new System.Drawing.Size(1018, 612);
            this.pnlSatilanUrunler.TabIndex = 5;
            this.pnlSatilanUrunler.Visible = false;
            // 
            // dgvSatilanUrunler
            // 
            this.dgvSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatilanUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvSatilanUrunler.Name = "dgvSatilanUrunler";
            this.dgvSatilanUrunler.RowHeadersWidth = 51;
            this.dgvSatilanUrunler.RowTemplate.Height = 29;
            this.dgvSatilanUrunler.Size = new System.Drawing.Size(1018, 612);
            this.dgvSatilanUrunler.TabIndex = 0;
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 851);
            this.Controls.Add(this.pnlSatilanUrunler);
            this.Controls.Add(this.pnlUrunGuncelle);
            this.Controls.Add(this.pnlUrunListele);
            this.Controls.Add(this.pnlSell);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SalesScreen_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.pnlSell.ResumeLayout(false);
            this.pnlSell.PerformLayout();
            this.pnlUrunListele.ResumeLayout(false);
            this.pnlUrunListele.PerformLayout();
            this.pnlUrunGuncelle.ResumeLayout(false);
            this.pnlUrunGuncelle.PerformLayout();
            this.pnlSatilanUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatilanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Panel pnlUrunListele;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.TextBox txtUrunDuzenle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSatilanUrunler;
        private System.Windows.Forms.Panel pnlUrunGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGuncelleKonum;
        private System.Windows.Forms.TextBox txtGuncelleUrunAciklama;
        private System.Windows.Forms.TextBox txtGuncelleUrunFiyati;
        private System.Windows.Forms.TextBox txtGuncelleUrunAdi;
        private System.Windows.Forms.Panel pnlSatilanUrunler;
        private System.Windows.Forms.DataGridView dgvSatilanUrunler;
        private System.Windows.Forms.ComboBox cmbGuncelleUrunKategorisi;
        private System.Windows.Forms.ComboBox cmbUrunKategorisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuncelleResim;
        private System.Windows.Forms.TextBox txtGuncelleResim;
    }
}