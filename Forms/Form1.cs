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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            ////dataGridView_cu.DataSource = sellingItemsManager.GetAll();
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
            //dataGridView_cu.Columns.Add(dgvBtn);

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            cmbKategoriler.Items.Add("");
            foreach (var item in categoryManager.GetAll())
            {
                cmbKategoriler.Items.Add(item.CategoryName.ToString());
            }
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn userId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn urunId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn location = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(img);
            dataGridView1.Columns.Add(userId);
            dataGridView1.Columns.Add(urunId);
            dataGridView1.Columns.Add(name);
            dataGridView1.Columns.Add(description);
            dataGridView1.Columns.Add(price);
            dataGridView1.Columns.Add(category);
            dataGridView1.Columns.Add(location);
            dataGridView1.Columns.Add(dgvBtn);

            img.HeaderText = "Image";
            userId.HeaderText = "UserId";
            urunId.HeaderText = "Ürün Numarası";
            name.HeaderText = "İsim";
            description.HeaderText = "Açıklama";
            price.HeaderText = "Fiyat";
            category.HeaderText = "Kategori";
            location.HeaderText = "Konum";
            userId.Visible = false;
            urunId.Visible = false;
            dgvBtn.Text = "Satın Al";
            dgvBtn.UseColumnTextForButtonValue = true;
            //çerçeve rengi
            dgvBtn.DefaultCellStyle.BackColor = Color.Blue;
            //buton seçiliyken çerçeve rengi
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            // Butonun genişiliği
            dgvBtn.Width = 70;
            // DataGridView e ekleme

            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void dataGridView_cu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            int resaultKategorId = 0;

            dataGridView1.Rows.Clear();
            string resaultCategory = "bilinmiyor";
            if (cmbKategoriler.Text =="")
            {
                List<SellingItems> resaultDeneme;
                if (textBox_cuSearch.Text == "")
                {
                    resaultDeneme = sellingItemsManager.GetAll(null);
                }
                else
                {
                    resaultDeneme = sellingItemsManager.GetAll(textBox_cuSearch.Text.ToString());
                }
                Button btn1 = new Button();
                foreach (var item in resaultDeneme)
                {
                    foreach (var ct in categoryManager.GetAll())
                    {
                        if (ct.Id == item.CategoryId)
                        {
                            resaultCategory = ct.CategoryName;
                        }
                    }
                    Image image = Image.FromFile(item.Picture);
                    dataGridView1.Rows.Add(image,item.UserId,item.Id,item.Name, item.Description, item.Price, resaultCategory, item.Location);

                }

            }
            else
            {
                foreach (var item in categoryManager.GetAll())
                {
                    if (cmbKategoriler.Text == item.CategoryName)
                    {
                        resaultKategorId = item.Id;
                    }
                }

                //dataGridView_cu.DataSource = sellingItemsManager.GetAll();
                
                Button btn1 = new Button();
                foreach (var item in sellingItemsManager.GetAllCategoryId(resaultKategorId))
                {
                    foreach (var ct in categoryManager.GetAll())
                    {
                        if (ct.Id == item.CategoryId)
                        {
                            resaultCategory = ct.CategoryName;
                        }
                    }
                    Image image = Image.FromFile(item.Picture);
                    dataGridView1.Rows.Add(image,item.UserId,item.Id,item.Name, item.Description, item.Price, resaultCategory, item.Location);

                }
                
                
                

                //dataGridView_cu.DataSource = sellingItemsManager.GetAllCategoryId(resaultKategorId);
            }
            //dataGridView1.Columns["userId"].Visible = false;
            //dataGridView1.Columns["urunId"].Visible = false;
        }

        private void button_cuSettings_Click(object sender, EventArgs e)
        {
            AccountScreen accountScreen = new AccountScreen();
            accountScreen.Visible = true;
        }

        private void button_cuExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Visible = true;
        }

        private void dataGridView_cu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SellingItemsManager sellingItemsManager = new SellingItemsManager(new EfSellingItemsDal());
            SoldManager soldManager = new SoldManager(new EfSoldItemsDal());
            SoldItems soldItems = new SoldItems();
            string resaultImage = "a";
            foreach (var item in sellingItemsManager.GetAll())
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()) == item.UserId)
                {
                    resaultImage = item.Picture;
                }
            }
            soldItems.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            soldItems.Picture = resaultImage;
            soldItems.UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            soldItems.Name = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            soldItems.Description = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            soldItems.Price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            soldItems.CategoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            soldItems.Location = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            soldManager.Add(soldItems);


            dataGridView1.Rows.Clear();
            Button btn1 = new Button();
            foreach (var item in sellingItemsManager.GetAll())
            {
                Image image = Image.FromFile(item.Picture);
                dataGridView1.Rows.Add(image, item.UserId, item.Id, item.Name, item.Description, item.Price, item.CategoryId, item.Location);

            }

            MessageBox.Show("Satın Alma işlemi Başarıyla Geerçekleşti!!!");
        }

        private void textBox_cuSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable sam = (DataTable)dataGridView1.DataSource;
            //DataView dv = sam.DefaultView;
            //dv.RowFilter = "İsim LIKE'%" + textBox_cuSearch.Text + "%'";
            //dataGridView1.DataSource = dv;
        }
    }
}
