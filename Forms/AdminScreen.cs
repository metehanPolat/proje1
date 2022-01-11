using Business.Concrete;
using DataAccess.Concrete.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            pnlKullaniciler.Visible = true;
            pnlUrunler.Visible = false;
            UserManager userManager = new UserManager(new EfUserDal());
            dgvOrtak.DataSource = userManager.GetAll();


            dgvOrtak.Columns[0].Visible = false;
            dgvOrtak.RowHeadersVisible = false; // ilk baştaki kendi eklediği sütunu kaldırır.
            
            dgvOrtak.Columns[3].Width = 110;
            dgvOrtak.Columns[4].Width = 110;
            dgvOrtak.Columns[5].Width = 110;
            dgvOrtak.Columns[6].Width = 115;

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn dgvBtn2 = new DataGridViewButtonColumn();
            dgvBtn2.Text = "Sil";
            dgvBtn2.UseColumnTextForButtonValue = true;
            //çerçeve rengi
            dgvBtn2.DefaultCellStyle.BackColor = Color.Blue;
            //buton seçiliyken çerçeve rengi
            dgvBtn2.DefaultCellStyle.SelectionBackColor = Color.Red;
            // Butonun genişiliği
            dgvBtn2.Width = 70;
            // DataGridView e ekleme
            dgvUrunlerGetir.Columns.Add(dgvBtn2);
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            pnlKullaniciler.Visible = false;
            pnlUrunler.Visible = true;
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());

            dgvUrunlerGetir.Rows.Clear();
            dgvUrunlerGetir.Columns.Clear();

            //dataGridView_cu.DataSource = sellingItemsManager.GetAll();
            DataGridViewButtonColumn dgvBtn1 = new DataGridViewButtonColumn();
            dgvBtn1.Text = "Sil";
            dgvBtn1.UseColumnTextForButtonValue = true;
            //çerçeve rengi
            dgvBtn1.DefaultCellStyle.BackColor = Color.Blue;
            //buton seçiliyken çerçeve rengi
            dgvBtn1.DefaultCellStyle.SelectionBackColor = Color.Red;
            // Butonun genişiliği
            dgvBtn1.Width = 70;
            // DataGridView e ekleme

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn urunId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            dgvUrunlerGetir.Columns.Add(img);
            dgvUrunlerGetir.Columns.Add(urunId);
            dgvUrunlerGetir.Columns.Add(name);
            dgvUrunlerGetir.Columns.Add(description);
            dgvUrunlerGetir.Columns.Add(price);
            dgvUrunlerGetir.Columns.Add(category);
            dgvUrunlerGetir.Columns.Add(location);
            dgvUrunlerGetir.Columns.Add(dgvBtn1);
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Button btn1 = new Button();

            img.HeaderText = "Image";
            urunId.HeaderText = "UrunId";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";

            string resaultCategory = "bilinmiyor";
            foreach (var item in sellingItemsManager.GetAll(null))
            {
                foreach (var ct in categoryManager.GetAll())
                {
                    if (ct.Id == item.CategoryId)
                    {
                        resaultCategory = ct.CategoryName;
                    }
                }
                Image image = Image.FromFile(item.Picture);
                dgvUrunlerGetir.Rows.Add(image,item.Id ,item.Name, item.Description, item.Price, resaultCategory, item.Location);

            }
            dgvUrunlerGetir.Columns[1].Visible = false;
            dgvUrunlerGetir.RowHeadersVisible = false; // ilk baştaki kendi eklediği sütunu kaldırır.
            
            dgvUrunlerGetir.Columns[3].Width = 90;
            dgvUrunlerGetir.Columns[4].Width = 88;
            dgvUrunlerGetir.Columns[5].Width = 88;
            dgvUrunlerGetir.Columns[6].Width = 90;
            dgvUrunlerGetir.AllowUserToAddRows = false;
        }

        private void dgvOrtak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var resault = userManager.GetAllId(Convert.ToInt32(dgvOrtak.CurrentRow.Cells[0].Value.ToString()));
            foreach (var item in resault)
            {
                userManager.Delete(item);
            }

            dgvOrtak.DataSource = userManager.GetAll();
        }

        private void dgvUrunlerGetir_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView_cu.DataSource = sellingItemsManager.GetAll();
            DataGridViewButtonColumn dgvBtn1 = new DataGridViewButtonColumn();
            dgvBtn1.Text = "Sil";
            dgvBtn1.UseColumnTextForButtonValue = true;
            //çerçeve rengi
            dgvBtn1.DefaultCellStyle.BackColor = Color.Blue;
            //buton seçiliyken çerçeve rengi
            dgvBtn1.DefaultCellStyle.SelectionBackColor = Color.Red;
            // Butonun genişiliği
            dgvBtn1.Width = 70;
            // DataGridView e ekleme
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            var resault = sellingItemsManager.GetAllUrunId(Convert.ToInt32(dgvUrunlerGetir.CurrentRow.Cells[1].Value.ToString()));
            foreach (var item in resault)
            {
                sellingItemsManager.Delete(item);
            }
            dgvUrunlerGetir.Rows.Clear();
            dgvUrunlerGetir.Columns.Clear();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn urunId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            dgvUrunlerGetir.Columns.Add(img);
            dgvUrunlerGetir.Columns.Add(urunId);
            dgvUrunlerGetir.Columns.Add(name);
            dgvUrunlerGetir.Columns.Add(description);
            dgvUrunlerGetir.Columns.Add(price);
            dgvUrunlerGetir.Columns.Add(category);
            dgvUrunlerGetir.Columns.Add(location);
            dgvUrunlerGetir.Columns.Add(dgvBtn1);
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Button btn1 = new Button();
            foreach (var item in sellingItemsManager.GetAll())
            {
                Image image = Image.FromFile(item.Picture);
                dgvUrunlerGetir.Rows.Add(image, item.Id, item.Name, item.Description, item.Price, item.CategoryId, item.Location);

            }

            img.HeaderText = "Image";
            urunId.HeaderText = "UrunId";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";

            dgvUrunlerGetir.RowHeadersVisible = false; // ilk baştaki kendi eklediği sütunu kaldırır.
            
            dgvUrunlerGetir.Columns[3].Width = 90;
            dgvUrunlerGetir.Columns[4].Width = 90;
            dgvUrunlerGetir.Columns[5].Width = 90;
            dgvUrunlerGetir.Columns[6].Width = 90;
            dgvUrunlerGetir.AllowUserToAddRows = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
