
namespace Forms
{
    partial class AdminScreen
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.pnlKullaniciler = new System.Windows.Forms.Panel();
            this.dgvOrtak = new System.Windows.Forms.DataGridView();
            this.pnlUrunler = new System.Windows.Forms.Panel();
            this.dgvUrunlerGetir = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlKullaniciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtak)).BeginInit();
            this.pnlUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Controls.Add(this.btnKullanicilar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 672);
            this.panel1.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCikis.Location = new System.Drawing.Point(23, 363);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(156, 43);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUrunler.Location = new System.Drawing.Point(23, 285);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(156, 43);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnKullanicilar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKullanicilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnKullanicilar.Location = new System.Drawing.Point(23, 205);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(156, 43);
            this.btnKullanicilar.TabIndex = 1;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // pnlKullaniciler
            // 
            this.pnlKullaniciler.Controls.Add(this.dgvOrtak);
            this.pnlKullaniciler.Location = new System.Drawing.Point(250, 80);
            this.pnlKullaniciler.Name = "pnlKullaniciler";
            this.pnlKullaniciler.Size = new System.Drawing.Size(700, 500);
            this.pnlKullaniciler.TabIndex = 1;
            // 
            // dgvOrtak
            // 
            this.dgvOrtak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrtak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrtak.Location = new System.Drawing.Point(0, 0);
            this.dgvOrtak.Name = "dgvOrtak";
            this.dgvOrtak.RowHeadersWidth = 51;
            this.dgvOrtak.RowTemplate.Height = 29;
            this.dgvOrtak.Size = new System.Drawing.Size(700, 500);
            this.dgvOrtak.TabIndex = 0;
            this.dgvOrtak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrtak_CellClick);
            // 
            // pnlUrunler
            // 
            this.pnlUrunler.Controls.Add(this.dgvUrunlerGetir);
            this.pnlUrunler.Location = new System.Drawing.Point(250, 80);
            this.pnlUrunler.Name = "pnlUrunler";
            this.pnlUrunler.Size = new System.Drawing.Size(700, 500);
            this.pnlUrunler.TabIndex = 2;
            // 
            // dgvUrunlerGetir
            // 
            this.dgvUrunlerGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunlerGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunlerGetir.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunlerGetir.Name = "dgvUrunlerGetir";
            this.dgvUrunlerGetir.RowHeadersWidth = 51;
            this.dgvUrunlerGetir.RowTemplate.Height = 29;
            this.dgvUrunlerGetir.Size = new System.Drawing.Size(700, 500);
            this.dgvUrunlerGetir.TabIndex = 0;
            this.dgvUrunlerGetir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunlerGetir_CellClick);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1007, 669);
            this.Controls.Add(this.pnlUrunler);
            this.Controls.Add(this.pnlKullaniciler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.panel1.ResumeLayout(false);
            this.pnlKullaniciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtak)).EndInit();
            this.pnlUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerGetir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Panel pnlKullaniciler;
        private System.Windows.Forms.DataGridView dgvOrtak;
        private System.Windows.Forms.Panel pnlUrunler;
        private System.Windows.Forms.DataGridView dgvUrunlerGetir;
    }
}