using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class Form1 : Form
    {
        public string Email { get; set; }//kayýtol fromunda kayýt olan kullanýcýnýn emaili buraya gelsin

        AkbildbContext context = new AkbildbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;
            }


            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;
            txtSifre.PasswordChar = '*';
            checkBoxHatirla.Checked = false;

            if (Properties.Akbil.Default.BeniHatirla)
            {
                txtEmail.Text = Properties.Akbil.Default.BeniHatirlaKullaniciEmail;
                txtSifre.Text = Properties.Akbil.Default.BeniHatirlaKullaniciSifre;
                checkBoxHatirla.Checked = true;
            }
           

        }



        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //bu formu gizleyeceðiz
            //kayýt ol formu açacaðýz
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                //1) Email ve þifre textboxlarý dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("bilgileri eksiksiz giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //2) Girdiði email ve þifre veritabanýnda mevcut mu?
                //select*from kullanýcýlar where email='' and sifre=''

               var kullanici=context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));

                if (kullanici == null)
                {
                    MessageBox.Show("Email ya da þifrenizi yanlýþ girdiniz!");
                    return;
                }
                else
                {
                    MessageBox.Show($"Hoþgeldiniz... {kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";

                    //beni hatýrlayý settings ile yazalým
                    if (checkBoxHatirla.Checked)
                    {
                        BeniHatirlaAyarla();

                    }

                    //temizlik
                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();
                }

            }
            catch (Exception hata)
            {
                //dipnot exceptiýnlar asla kullanýcýya gösterilmez
                //exceptionlar loglanýr. biz þu an öðrenme/geliþtirme aþamsýnda olduðumuz için yazdýk.
                MessageBox.Show("beklenmedik bir sorun oluþtu!" + hata.Message);

            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {

            }

        }
        private void BeniHatirlaAyarla()
        {
            Properties.Akbil.Default.BeniHatirlaKullaniciEmail = txtEmail.Text.Trim();
            Properties.Akbil.Default.BeniHatirlaKullaniciSifre = txtSifre.Text.Trim();
            Properties.Akbil.Default.Save();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))//basýlan tuþ enter ise giriþ yapacak
            {
                GirisYap();
            }
        }

        private void checkBoxHatirla_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxHatirla.Checked)
            {
                Properties.Akbil.Default.BeniHatirla = true;
                Properties.Akbil.Default.Save();

            }
            else
            {
                Properties.Akbil.Default.BeniHatirla = false;
                Properties.Akbil.Default.Save();


            }

        }
    }
}