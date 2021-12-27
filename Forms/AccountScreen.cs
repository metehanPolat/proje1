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
    public partial class AccountScreen : Form
    {
        public AccountScreen()
        {
            InitializeComponent();
        }

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var item in userManager.GetAllId(LoginScreen.resaultUserId))
            {
                txtKayitEMail.Text = item.Email;
                txtKayitKullaniciAdi.Text = item.UserName;
                txtKayitSifre.Text = item.Pasword;
                txtKayitSoyisim.Text = item.Surname;
                txtKayitTel.Text = item.PhoneNumber;
                txtKayitİsim.Text = item.Name;
            }
            txtKayitTel.MaxLength = 11;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var resault = userManager.GetAllId(LoginScreen.resaultUserId);
            if (txtKayitEMail.Text !="" && txtKayitKullaniciAdi.Text !="" && txtKayitSifre.Text!="" && txtKayitSoyisim.Text!="" && txtKayitTel.Text!="" && txtKayitİsim.Text!="")
            {
                foreach (var item in resault)
                {
                    item.Email = txtKayitEMail.Text;
                    item.UserName = txtKayitKullaniciAdi.Text;
                    item.Pasword = txtKayitSifre.Text;
                    item.Surname = txtKayitSoyisim.Text;
                    item.PhoneNumber = txtKayitTel.Text;
                    item.Name = txtKayitİsim.Text;
                    userManager.Update(item);
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Geerçekleşti!!!");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            AccountScreen accountScreen = new AccountScreen();
            this.Hide();
        }
    }
}
