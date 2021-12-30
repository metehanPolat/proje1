using Business.Concrete;
using DataAccess.Concrete.Oracle;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class SalesScreen : Form
    {
        public SalesScreen()
        {
            InitializeComponent();
        }

        private void SalesScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            pnlSell.Visible = false;
            pnlUrunListele.Visible = true;
            pnlUrunGuncelle.Visible = false;
            pnlSatilanUrunler.Visible = false;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            dgvListele.Columns.Add(img);
            dgvListele.Columns.Add(id);
            dgvListele.Columns.Add(name);
            dgvListele.Columns.Add(description);
            dgvListele.Columns.Add(price);
            dgvListele.Columns.Add(category);
            dgvListele.Columns.Add(location);
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var item in sellingItemsManager.GetAllUserId(LoginScreen.resaultUserId))
            {
                Image image = Image.FromFile(item.Picture);
                //img.Image = image;
                dgvListele.Rows.Add(image,item.Id ,item.Name, item.Description, item.Price, item.CategoryId, item.Location);

            }

            img.HeaderText = "Image";
            id.HeaderText = "Id";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";

            //img.Name = "img";


            //dgvListele.DataSource = sellingItemsManager.GetAllUserId(LoginScreen.resaultUserId);
        }

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            pnlSell.Visible = true;
            pnlUrunListele.Visible = false;
            pnlUrunGuncelle.Visible = false;
            pnlSatilanUrunler.Visible = false;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellingItems sellingItems = new SellingItems();
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            //bool resault = true;

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            int resaultId = 0;// kategorinin id sini tutucağım ki selling items tablosuna id olarak atayabileyim
            foreach (var item in categoryManager.GetAll()) // isimden category id ye geçiyor
            {
                if (cmbUrunKategorisi.Text == item.CategoryName)
                {
                    resaultId = item.Id;
                }
            }

            
            if (txtKonum.Text !="" && txtUrunAciklama.Text !="" && txtUrunAdi.Text !="" && txtUrunFiyati.Text !="" && cmbUrunKategorisi.Text != "")
            {
                sellingItems.UserId = LoginScreen.resaultUserId;
                sellingItems.Name = txtUrunAdi.Text;
                sellingItems.Description = txtUrunAciklama.Text;
                sellingItems.Price = Convert.ToInt32(txtUrunFiyati.Text);
                sellingItems.CategoryId = resaultId;
                sellingItems.Location = txtKonum.Text;
                sellingItemsManager.Add(sellingItems);
                MessageBox.Show("Kayıt işlemi Başarıyla Geerçekleşti!!!");

                txtKonum.Clear();
                txtUrunAciklama.Clear();
                txtUrunAdi.Clear();
                txtUrunFiyati.Clear();
            }
            else
            {
                MessageBox.Show("Bilgiler boş bırakılamaz !!!", "İşlem başarısız");
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            pnlSell.Visible = false;
            pnlUrunGuncelle.Visible = true;
            pnlUrunListele.Visible = false;
            pnlSatilanUrunler.Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SellingItems sellingItems = new SellingItems();
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            var resault = sellingItemsManager.GetAllUrunId(Convert.ToInt32(txtUrunDuzenle.Text));

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            int resaultId = 0;// kategorinin id sini tutucağım ki selling items tablosuna id olarak atayabileyim
            foreach (var item in categoryManager.GetAll()) // isimden category id ye geçiyor
            {
                if (cmbGuncelleUrunKategorisi.Text == item.CategoryName)
                {
                    resaultId = item.Id;
                }
            }
            if (txtGuncelleKonum.Text != "" && txtGuncelleUrunAciklama.Text != "" && txtGuncelleUrunAdi.Text != "" && txtGuncelleUrunFiyati.Text != "" && cmbGuncelleUrunKategorisi.Text != "" && txtGuncelleResim.Text !="")
            {
                foreach (var item in resault)
                {
                    item.Picture = txtGuncelleResim.Text;
                    item.UserId = LoginScreen.resaultUserId;
                    item.Name = txtGuncelleUrunAdi.Text;
                    item.Description = txtGuncelleUrunAciklama.Text;
                    item.Price = Convert.ToInt32(txtGuncelleUrunFiyati.Text);
                    item.CategoryId = resaultId;
                    item.Location = txtGuncelleKonum.Text;
                    sellingItemsManager.Update(item);
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Geerçekleşti!!!");
                }
            }
            else
            {
                MessageBox.Show("Bilgiler boş bırakılamaz !!!", "İşlem başarısız");
            }
        }

        private void btnSatilanUrunler_Click(object sender, EventArgs e)
        {
            pnlSell.Visible = false;
            pnlUrunListele.Visible = false;
            pnlUrunGuncelle.Visible = false;
            pnlSatilanUrunler.Visible = true;
            SoldManager soldManager = new SoldManager(new EfSoldItemsDal());
            //SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            dgvSatilanUrunler.Columns.Add(img);
            dgvSatilanUrunler.Columns.Add(id);
            dgvSatilanUrunler.Columns.Add(name);
            dgvSatilanUrunler.Columns.Add(description);
            dgvSatilanUrunler.Columns.Add(price);
            dgvSatilanUrunler.Columns.Add(category);
            dgvSatilanUrunler.Columns.Add(location);
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var item in soldManager.GetAll())
            {
                Image image = Image.FromFile(item.Picture);
                //img.Image = image;
                dgvSatilanUrunler.Rows.Add(image, item.Id, item.Name, item.Description, item.Price, item.CategoryId, item.Location);

            }

            img.HeaderText = "Image";
            id.HeaderText = "Id";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";

            //dgvSatilanUrunler.DataSource = soldManager.GetAllUserId(LoginScreen.resaultUserId);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Visible = true;
        }

        private void SalesScreen_Load_1(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                cmbGuncelleUrunKategorisi.Items.Add(item.CategoryName.ToString());
                cmbUrunKategorisi.Items.Add(item.CategoryName.ToString());
            }

            //DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            //dgvBtn.Text = "Satın Al";
            //dgvBtn.UseColumnTextForButtonValue = true;
            ////çerçeve rengi
            //dgvBtn.DefaultCellStyle.BackColor = Color.Blue;
            ////buton seçiliyken çerçeve rengi
            //dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            //// Butonun genişiliği
            //dgvBtn.Width = 70;
            //// DataGridView e ekleme
            //dgvListele.Columns.Add(dgvBtn);
        }

        private void btnGuncelleResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.InitialDirectory = "C:";
            file.RestoreDirectory = true; // önceki açılan yerden açılıcak
            file.Filter = "Resim |*.png| Resim|*.jpg";
            file.FilterIndex = 2; // 2 filtreyi uygular

            file.CheckFileExists = false; // dosya kısmına bir isim yazıldığında var mı yok mu bakar
            file.Title = "Resimi Seçiniz..."; // başlık

            string DosyaYolu = "a";
            if (file.ShowDialog() == DialogResult.OK)// dosya seçildiyse gir
            {
                DosyaYolu = file.FileName;//seçilen dosyanın tüm yolunu verir
                //string DosyaAdi = file.SafeFileName; //seçilen dosyanın adını verir
            }
            txtGuncelleResim.Text = DosyaYolu;
        }

        private void pnlSell_Paint(object sender, PaintEventArgs e)
        {
            //txtUrunFiyati.Text = "Enter text here...";
        }
        
    }
}
