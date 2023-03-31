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
    public partial class FrmAkbiller : Form
    {
        AkbildbContext context = new AkbildbContext();
        public FrmAkbiller()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //kontroller
                if (cmbBoxAkbilTipleri.SelectedIndex < 0)
                {
                    MessageBox.Show("lütfen ekleyeceğiniz akbilin türünü seçiniz!");
                    return;
                }
                if (maskedTextBoxAkbilNo.Text.Length < 16)
                {
                    MessageBox.Show("Akbil No 16 Haneli olmalıdır");
                    return;
                }
                Akbiller yeniAkbil = new Akbiller()
                {
                    EklenmeTarihi = DateTime.Now,
                    AkbilNo = maskedTextBoxAkbilNo.Text,
                    AkbilSahibiId = GenelIslemler.GirisYapanKullaniciID,
                    AkbilTipi = cmbBoxAkbilTipleri.SelectedItem.ToString(),
                    Bakiye = 0,
                    VizelendigiTarih=null

                };
                context.Akbillers.Add(yeniAkbil);
                int sonuc = context.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show("Yeni Akbil Eklendi!");
                    //temizlik
                    maskedTextBoxAkbilNo.Text = "Akbil tipi seçiniz...";
                    cmbBoxAkbilTipleri.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Yeni Akbil Eklenemedi!");
                }
                



            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
            }
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            cmbBoxAkbilTipleri.Text = "Akbil Tipi Seçiniz...";
            cmbBoxAkbilTipleri.SelectedIndex = -1;
            dataGridViewAkbiller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewiDoldur();
        }

        private void DataGridViewiDoldur()
        {
            try
            {
                dataGridViewAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciID).ToList();

                //bazı kolonlar gizlensin
                dataGridViewAkbiller.Columns["AkbilSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarih"].HeaderText = "Vizelendiği Tarih";
                dataGridViewAkbiller.Columns["VizelendigiTarih"].Width = 200;

            }
            catch (Exception hata)
            {

                MessageBox.Show("Akbilleri listeleyemedim!" + hata.Message);
            }
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Güle Güle...  \n  Çıkış Yapıldı! ");
            //GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            //GenelIslemler.GirisYapanKullaniciID = 0;


            Form1 giris = new Form1();
            foreach (Form item in Application.OpenForms)
            {

                item.Hide();

            }
            giris.Show();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }
    }
}
