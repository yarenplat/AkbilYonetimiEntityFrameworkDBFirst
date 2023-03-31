using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        AkbildbContext context = new AkbildbContext();


        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;

                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("zorunlu alanları doldurunuz");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }

                }//foreach bitti
                //bu emailden sistemde var mı?
                if (context.Kullanicilars.FirstOrDefault(x=>x.Email==txtEmail.Text.Trim())!=null)
                {
                    MessageBox.Show("bu emaille sistemde kayıt mevcuttur!");
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    return;
                }

                Kullanicilar yeniKullanici = new Kullanicilar()
                {
                    EklenmeTarihi = DateTime.Now,
                    Ad = txtIsim.Text.Trim(),
                    Soyad = txtSoyisim.Text.Trim(),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Email = txtEmail.Text.Trim(),
                    Parola = GenelIslemler.MD5Encryption(txtSifre.Text.Trim())
                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Kullanıcı Eklendi!");
                    //temizlik
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();

                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;

                        }//forech bitt
                    }
                    
                        var cevap = MessageBox.Show("Giriş sayfasına gitmet ister misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if ((int)cevap == 6)    //(cevap==DialogResult.Yes)
                        {
                            Form1 frmg = new Form1();
                            frmg.Email = txtEmail.Text.Trim();
                            this.Hide();
                            frmg.Show();
                        }
                    
                }
                else
                {
                    MessageBox.Show("Kullanici Ekleme Başarısız Oldu!");
                }

                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;

            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılacak(loglama)
                MessageBox.Show("beklenmedik bir hata oluştu!lütfen tekrar deneyiniz!", ex.Message);
            }
        }
        private void GirisFormunaGit()
        {
            Form1 frmG = new Form1();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
