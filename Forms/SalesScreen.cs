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
            dgvListele.Rows.Clear();
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()); 
            pnlSell.Visible = false;
            pnlUrunListele.Visible = true;
            pnlUrunGuncelle.Visible = false;
            pnlSatilanUrunler.Visible = false;


            string resaultCategory ="bilinmiyor";
            foreach (var item in sellingItemsManager.GetAllUserId(LoginScreen.resaultUserId))
            {
                foreach (var ct in categoryManager.GetAll())
                {
                    if (ct.Id == item.CategoryId)
                    {
                        resaultCategory = ct.CategoryName;
                    }
                }
                Image image = Image.FromFile(item.Picture);
                //img.Image = image;
                dgvListele.Rows.Add(image,item.Id ,item.Name, item.Description, item.Price, resaultCategory, item.Location);

            }

            

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

            
            if (txtKonum.Text !="" && txtUrunAciklama.Text !="" && txtUrunAdi.Text !="" && txtUrunFiyati.Text !="" && cmbUrunKategorisi.Text != "" && txtUrunResmi.Text !="")
            {
                sellingItems.UserId = LoginScreen.resaultUserId;
                sellingItems.Name = txtUrunAdi.Text;
                sellingItems.Description = txtUrunAciklama.Text;
                sellingItems.Price = Convert.ToInt32(txtUrunFiyati.Text);
                sellingItems.CategoryId = resaultId;
                sellingItems.Location = txtKonum.Text;
                sellingItems.Picture = txtUrunResmi.Text;
                sellingItemsManager.Add(sellingItems);
                MessageBox.Show("Kayıt işlemi Başarıyla Geerçekleşti!!!");

                txtKonum.Clear();
                txtUrunAciklama.Clear();
                txtUrunAdi.Clear();
                txtUrunFiyati.Clear();
                txtUrunResmi.Clear();
            }
            else
            {
                MessageBox.Show("Bilgiler boş bırakılamaz !!!", "İşlem başarısız");
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            bool tut=false;
            foreach (var item in sellingItemsManager.GetAllUserId(LoginScreen.resaultUserId))
            {
                if (item.Id == Convert.ToInt32(txtUrunDuzenle.Text.ToString()))
                {
                    tut = true;
                    break;
                }
            }
            if (tut)
            {
                pnlSell.Visible = false;
                pnlUrunGuncelle.Visible = true;
                pnlUrunListele.Visible = false;
                pnlSatilanUrunler.Visible = false;
                foreach (var item in sellingItemsManager.GetAllUrunId(Convert.ToInt32(txtUrunDuzenle.Text.ToString())))
                {
                    txtGuncelleKonum.Text = item.Location;
                    txtGuncelleResim.Text = item.Picture;
                    txtGuncelleUrunAciklama.Text = item.Description;
                    txtGuncelleUrunAdi.Text = item.Name;
                    txtGuncelleUrunFiyati.Text = item.Price.ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("Yanlış bir Ürün Numarası Girdiniz !!!!");
            }
            
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
            dgvSatilanUrunler.Rows.Clear();
            pnlSell.Visible = false;
            pnlUrunListele.Visible = false;
            pnlUrunGuncelle.Visible = false;
            pnlSatilanUrunler.Visible = true;

            string resaultCategory = "bilinmiyor";
            SoldManager soldManager = new SoldManager(new EfSoldItemsDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in soldManager.GetAllUserId(LoginScreen.resaultUserId))
            {
                foreach (var ct in categoryManager.GetAll())
                {
                    if (ct.Id == item.CategoryId)
                    {
                        resaultCategory = ct.CategoryName;
                    }
                }
                Image image = Image.FromFile(item.Picture);
                //img.Image = image;
                dgvSatilanUrunler.Rows.Add(image, item.Id, item.Name, item.Description, item.Price, resaultCategory, item.Location);

            }

            
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
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            img.HeaderText = "Image";
            id.HeaderText = "Id";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";
            

            SoldManager soldManager = new SoldManager(new EfSoldItemsDal());
            DataGridViewImageColumn img2 = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn id2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location2 = new DataGridViewTextBoxColumn();

            dgvSatilanUrunler.Columns.Add(img2);
            dgvSatilanUrunler.Columns.Add(id2);
            dgvSatilanUrunler.Columns.Add(name2);
            dgvSatilanUrunler.Columns.Add(description2);
            dgvSatilanUrunler.Columns.Add(price2);
            dgvSatilanUrunler.Columns.Add(category2);
            dgvSatilanUrunler.Columns.Add(location2);
            img2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img2.HeaderText = "Image";
            id2.HeaderText = "Id";
            name2.HeaderText = "İsim";
            description2.HeaderText = "Açıklama";
            price2.HeaderText = "Fiyat";
            category2.HeaderText = "Kategori";
            location2.HeaderText = "Konum";
            id2.Visible = false;

            dgvSatilanUrunler.RowHeadersVisible = false; // ilk baştaki kendi eklediği sütunu kaldırır.
            
            dgvSatilanUrunler.Columns[3].Width = 200;
            dgvSatilanUrunler.Columns[4].Width = 200;
            dgvSatilanUrunler.Columns[5].Width = 200;
            dgvSatilanUrunler.Columns[6].Width = 200;
            //dgvSatilanUrunler.Columns[7].Width = 150;
            //dgvSatilanUrunler.Columns[8].Width = 150;

            dgvListele.RowHeadersVisible = false; // ilk baştaki kendi eklediği sütunu kaldırır.
            
            dgvListele.Columns[3].Width = 169;
            dgvListele.Columns[4].Width = 169;
            dgvListele.Columns[5].Width = 169;
            dgvListele.Columns[6].Width = 152;
            //dgvListele.Columns[7].Width = 150;
            //dgvListele.Columns[8].Width = 150;
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

        private void btnUrunResimEkle_Click(object sender, EventArgs e)
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
            txtUrunResmi.Text = DosyaYolu;
        }
    }
}
