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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            pnlSatisYapma.Visible = true;
            pnlSatinAlma.Visible = false;
            btnSatınAl.Visible = true;
            btnSatisYap.Visible = false;
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            pnlSatisYapma.Visible = false;
            pnlSatinAlma.Visible = true;
            btnSatınAl.Visible = false;
            btnSatisYap.Visible = true;
        }

        private void btnCikis1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserManager userManager = new UserManager(new EfUserDal());
            bool resault = true;
            foreach (var item in userManager.GetAll())
            {
                if (txtKayitKullaniciAdi.Text == item.UserName)
                {
                    resault = false;
                }
            }
            if (txtKayitİsim.Text !="" && txtKayitSoyisim.Text != "" && txtKayitEMail.Text != "" && txtKayitSifre.Text != "" && txtKayitKullaniciAdi.Text != "" && txtKayitTel.Text.Length == 11 && txtKayitTel.Text!="")
            {
                if (resault)
                {
                    user.Name = txtKayitİsim.Text;
                    user.Surname = txtKayitSoyisim.Text;
                    user.Email = txtKayitEMail.Text;
                    user.UserName = txtKayitKullaniciAdi.Text;
                    user.Pasword = txtKayitSifre.Text;
                    user.PhoneNumber = txtKayitTel.Text;
                    userManager.Add(user);

                    MessageBox.Show("Kayıt işlemi Başarıyla Geerçekleşti!!!");
                    pnlKayitOl.Visible = false;
                    pnlSatinAlma.Visible = true;
                    pnlSatisYapma.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı kullanılmakta !!!");
                    txtKayitKullaniciAdi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bilgileri boş bırakmadığınızdan ya da tel i doğru girmediğinizden!!!", "İşlem başarısız");
            }
        }

        private void btnSatinAlmaKayitOl_Click(object sender, EventArgs e)
        {
            pnlKayitOl.Visible = true;
            pnlSatinAlma.Visible = false;
            pnlSatisYapma.Visible = false;
        }

        private void btnSatisKayitOl_Click(object sender, EventArgs e)
        {
            pnlKayitOl.Visible = true;
            pnlSatinAlma.Visible = false;
            pnlSatisYapma.Visible = false;
        }
        public static int resaultUserId = 1002;
        private void btnSatinAlmaGirisYap_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager(new EfUserDal());
            bool result = false;
            foreach (var us in user.GetAll())
            {
                if (txtSatinAlmaParola.Text == us.Pasword && txtSatinAlmaKullaniciAdi.Text == us.UserName)
                {
                    resaultUserId = us.Id;
                    //SalesScreen salesScreen = new SalesScreen();
                    // salesScreen.Visible = true;
                    Form1 form = new Form1();
                    form.Visible = true;
                    result = true;
                    this.Hide();
                }
            }

            AdminManager admin = new AdminManager(new EfAdminDal());
            foreach (var item in admin.GetAll())
            {
                if (txtSatinAlmaParola.Text == item.Password && txtSatinAlmaKullaniciAdi.Text == item.Name)
                {
                    AdminScreen adminScreen = new AdminScreen();
                    adminScreen.Visible = true;
                    result = true;
                    this.Hide();
                }
            }
            if (!result)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                txtSatisParola.Clear();
                txtSatisKullaniciAdi.Clear();
            }
        }

        private void btnSatisGirisYap_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager(new EfUserDal());
            bool result = false;
            foreach (var us in user.GetAll())
            {
                if (txtSatisParola.Text == us.Pasword && txtSatisKullaniciAdi.Text == us.UserName)
                {
                    resaultUserId = us.Id;
                    SalesScreen salesScreen = new SalesScreen();
                    salesScreen.Visible = true;
                    result = true;
                    this.Hide();
                }
            }
            // ADMİN GİRİŞİ
            AdminManager admin = new AdminManager(new EfAdminDal());
            foreach (var item in admin.GetAll())
            {
                if (txtSatisParola.Text == item.Password && txtSatisKullaniciAdi.Text == item.Name)
                {
                    AdminScreen adminScreen = new AdminScreen();
                    adminScreen.Visible = true;
                    result = true;
                    this.Hide();
                }
            }
            if (!result)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                txtSatisParola.Clear();
                txtSatisKullaniciAdi.Clear();
            }
        }
    }
}
