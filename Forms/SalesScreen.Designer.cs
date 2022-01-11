
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
            this.btnUrunResimEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUrunResmi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnSatilanUrunler);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnUrunSat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 652);
            this.panel1.TabIndex = 0;
            // 
            // btnSatilanUrunler
            // 
            this.btnSatilanUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatilanUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatilanUrunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSatilanUrunler.Location = new System.Drawing.Point(0, 268);
            this.btnSatilanUrunler.Name = "btnSatilanUrunler";
            this.btnSatilanUrunler.Size = new System.Drawing.Size(201, 54);
            this.btnSatilanUrunler.TabIndex = 4;
            this.btnSatilanUrunler.Text = "Satılan Ürünler";
            this.btnSatilanUrunler.UseVisualStyleBackColor = true;
            this.btnSatilanUrunler.Click += new System.EventHandler(this.btnSatilanUrunler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCikis.Location = new System.Drawing.Point(0, 436);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(201, 54);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunSat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUrunSat.Location = new System.Drawing.Point(0, 352);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(201, 54);
            this.btnUrunSat.TabIndex = 1;
            this.btnUrunSat.Text = "Ürün Sat";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürünleri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListele
            // 
            this.dgvListele.AllowDrop = true;
            this.dgvListele.AllowUserToAddRows = false;
            this.dgvListele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListele.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(3, 73);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.RowHeadersWidth = 51;
            this.dgvListele.RowTemplate.Height = 29;
            this.dgvListele.Size = new System.Drawing.Size(1059, 522);
            this.dgvListele.TabIndex = 1;
            // 
            // pnlSell
            // 
            this.pnlSell.BackColor = System.Drawing.Color.White;
            this.pnlSell.Controls.Add(this.btnUrunResimEkle);
            this.pnlSell.Controls.Add(this.label14);
            this.pnlSell.Controls.Add(this.txtUrunResmi);
            this.pnlSell.Controls.Add(this.label13);
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
            this.pnlSell.Location = new System.Drawing.Point(350, 85);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.Size = new System.Drawing.Size(733, 535);
            this.pnlSell.TabIndex = 2;
            this.pnlSell.Visible = false;
            this.pnlSell.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSell_Paint);
            // 
            // btnUrunResimEkle
            // 
            this.btnUrunResimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnUrunResimEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunResimEkle.Location = new System.Drawing.Point(167, 407);
            this.btnUrunResimEkle.Name = "btnUrunResimEkle";
            this.btnUrunResimEkle.Size = new System.Drawing.Size(68, 40);
            this.btnUrunResimEkle.TabIndex = 16;
            this.btnUrunResimEkle.Text = "...";
            this.btnUrunResimEkle.UseVisualStyleBackColor = false;
            this.btnUrunResimEkle.Click += new System.EventHandler(this.btnUrunResimEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(35, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "Resim";
            // 
            // txtUrunResmi
            // 
            this.txtUrunResmi.Location = new System.Drawing.Point(35, 414);
            this.txtUrunResmi.Name = "txtUrunResmi";
            this.txtUrunResmi.Size = new System.Drawing.Size(126, 27);
            this.txtUrunResmi.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(163, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(394, 31);
            this.label13.TabIndex = 13;
            this.label13.Text = "Daha fazla detay eklemek ister misin?";
            // 
            // cmbUrunKategorisi
            // 
            this.cmbUrunKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunKategorisi.FormattingEnabled = true;
            this.cmbUrunKategorisi.Location = new System.Drawing.Point(163, 256);
            this.cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            this.cmbUrunKategorisi.Size = new System.Drawing.Size(208, 28);
            this.cmbUrunKategorisi.TabIndex = 12;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(263, 401);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(219, 40);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "İşlemi Tamamla";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(388, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Konum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(163, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(163, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(163, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(388, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(388, 256);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(204, 27);
            this.txtKonum.TabIndex = 4;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(163, 335);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(429, 27);
            this.txtUrunAciklama.TabIndex = 3;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(163, 124);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(204, 27);
            this.txtUrunFiyati.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(388, 124);
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
            this.pnlUrunListele.Location = new System.Drawing.Point(216, 57);
            this.pnlUrunListele.Name = "pnlUrunListele";
            this.pnlUrunListele.Size = new System.Drawing.Size(1062, 595);
            this.pnlUrunListele.TabIndex = 3;
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Location = new System.Drawing.Point(856, 29);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(134, 27);
            this.btnUrunDuzenle.TabIndex = 4;
            this.btnUrunDuzenle.Text = "Ürünü Düzenle";
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // txtUrunDuzenle
            // 
            this.txtUrunDuzenle.Location = new System.Drawing.Point(666, 29);
            this.txtUrunDuzenle.Name = "txtUrunDuzenle";
            this.txtUrunDuzenle.Size = new System.Drawing.Size(156, 27);
            this.txtUrunDuzenle.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(580, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ürün Id :";
            // 
            // pnlUrunGuncelle
            // 
            this.pnlUrunGuncelle.BackColor = System.Drawing.Color.White;
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
            this.pnlUrunGuncelle.Location = new System.Drawing.Point(350, 85);
            this.pnlUrunGuncelle.Name = "pnlUrunGuncelle";
            this.pnlUrunGuncelle.Size = new System.Drawing.Size(733, 535);
            this.pnlUrunGuncelle.TabIndex = 4;
            this.pnlUrunGuncelle.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(156, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Resim:";
            // 
            // btnGuncelleResim
            // 
            this.btnGuncelleResim.Location = new System.Drawing.Point(382, 357);
            this.btnGuncelleResim.Name = "btnGuncelleResim";
            this.btnGuncelleResim.Size = new System.Drawing.Size(43, 26);
            this.btnGuncelleResim.TabIndex = 14;
            this.btnGuncelleResim.Text = "***";
            this.btnGuncelleResim.UseVisualStyleBackColor = true;
            this.btnGuncelleResim.Click += new System.EventHandler(this.btnGuncelleResim_Click);
            // 
            // txtGuncelleResim
            // 
            this.txtGuncelleResim.Location = new System.Drawing.Point(160, 357);
            this.txtGuncelleResim.Name = "txtGuncelleResim";
            this.txtGuncelleResim.Size = new System.Drawing.Size(205, 27);
            this.txtGuncelleResim.TabIndex = 13;
            // 
            // cmbGuncelleUrunKategorisi
            // 
            this.cmbGuncelleUrunKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuncelleUrunKategorisi.FormattingEnabled = true;
            this.cmbGuncelleUrunKategorisi.Location = new System.Drawing.Point(382, 114);
            this.cmbGuncelleUrunKategorisi.Name = "cmbGuncelleUrunKategorisi";
            this.cmbGuncelleUrunKategorisi.Size = new System.Drawing.Size(203, 28);
            this.cmbGuncelleUrunKategorisi.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(271, 423);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(219, 40);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(381, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Konum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(159, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(160, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(381, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Kategorisi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(160, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ürün Adı:";
            // 
            // txtGuncelleKonum
            // 
            this.txtGuncelleKonum.Location = new System.Drawing.Point(382, 189);
            this.txtGuncelleKonum.Name = "txtGuncelleKonum";
            this.txtGuncelleKonum.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleKonum.TabIndex = 4;
            // 
            // txtGuncelleUrunAciklama
            // 
            this.txtGuncelleUrunAciklama.Location = new System.Drawing.Point(156, 272);
            this.txtGuncelleUrunAciklama.Name = "txtGuncelleUrunAciklama";
            this.txtGuncelleUrunAciklama.Size = new System.Drawing.Size(430, 27);
            this.txtGuncelleUrunAciklama.TabIndex = 3;
            // 
            // txtGuncelleUrunFiyati
            // 
            this.txtGuncelleUrunFiyati.Location = new System.Drawing.Point(160, 189);
            this.txtGuncelleUrunFiyati.Name = "txtGuncelleUrunFiyati";
            this.txtGuncelleUrunFiyati.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleUrunFiyati.TabIndex = 2;
            // 
            // txtGuncelleUrunAdi
            // 
            this.txtGuncelleUrunAdi.Location = new System.Drawing.Point(160, 114);
            this.txtGuncelleUrunAdi.Name = "txtGuncelleUrunAdi";
            this.txtGuncelleUrunAdi.Size = new System.Drawing.Size(204, 27);
            this.txtGuncelleUrunAdi.TabIndex = 0;
            // 
            // pnlSatilanUrunler
            // 
            this.pnlSatilanUrunler.Controls.Add(this.dgvSatilanUrunler);
            this.pnlSatilanUrunler.Location = new System.Drawing.Point(216, 57);
            this.pnlSatilanUrunler.Name = "pnlSatilanUrunler";
            this.pnlSatilanUrunler.Size = new System.Drawing.Size(1062, 595);
            this.pnlSatilanUrunler.TabIndex = 5;
            this.pnlSatilanUrunler.Visible = false;
            // 
            // dgvSatilanUrunler
            // 
            this.dgvSatilanUrunler.AllowUserToAddRows = false;
            this.dgvSatilanUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSatilanUrunler.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatilanUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatilanUrunler.Location = new System.Drawing.Point(0, 0);
            this.dgvSatilanUrunler.Name = "dgvSatilanUrunler";
            this.dgvSatilanUrunler.RowHeadersWidth = 51;
            this.dgvSatilanUrunler.RowTemplate.Height = 29;
            this.dgvSatilanUrunler.Size = new System.Drawing.Size(1062, 595);
            this.dgvSatilanUrunler.TabIndex = 0;
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1288, 693);
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUrunResimEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUrunResmi;
    }
}