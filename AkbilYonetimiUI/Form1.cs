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
        public string Email { get; set; }//kay�tol fromunda kay�t olan kullan�c�n�n emaili buraya gelsin

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
            //bu formu gizleyece�iz
            //kay�t ol formu a�aca��z
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
                //1) Email ve �ifre textboxlar� dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("bilgileri eksiksiz giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //2) Girdi�i email ve �ifre veritaban�nda mevcut mu?
                //select*from kullan�c�lar where email='' and sifre=''

               var kullanici=context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));

                if (kullanici == null)
                {
                    MessageBox.Show("Email ya da �ifrenizi yanl�� girdiniz!");
                    return;
                }
                else
                {
                    MessageBox.Show($"Ho�geldiniz... {kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";

                    //beni hat�rlay� settings ile yazal�m
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
                //dipnot excepti�nlar asla kullan�c�ya g�sterilmez
                //exceptionlar loglan�r. biz �u an ��renme/geli�tirme a�ams�nda oldu�umuz i�in yazd�k.
                MessageBox.Show("beklenmedik bir sorun olu�tu!" + hata.Message);

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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))//bas�lan tu� enter ise giri� yapacak
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