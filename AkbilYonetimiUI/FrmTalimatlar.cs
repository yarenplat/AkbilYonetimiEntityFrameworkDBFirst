using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmTalimatlar : Form
    {
        AkbildbContext context = new AkbildbContext();
        public FrmTalimatlar()
        {
            InitializeComponent();
        }
        private void FrmTalimatlar_Load(object sender, EventArgs e)
        {
            //Comboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil seçiniz...";
            // cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBoxYukleme.Enabled = false;

            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TalimatlariDataGrideGetir();
            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;

            checkBoxTumunuGoster.Checked = false;
            BekleyenTalimatSayisiniGetir();
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;

        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
                var bekleyen = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID && !x.YuklendiMi);

                if (cmbBoxAkbiller.SelectedIndex >= 0)
                {

                    //burada  ise bekleyen talimatlar içinden sadece comboda secili olanını sayısını alıyoruz.

                    lblBekleyenTalimat.Text = bekleyen.Count(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString()).ToString();

                }
                else
                {
                    lblBekleyenTalimat.Text = bekleyen.Count().ToString();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

        private void TalimatlariDataGrideGetir(bool tumunuGoster = false)
        {
            try
            {
                var talimatlar = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciID);

                if (!tumunuGoster)
                {
                    talimatlar = talimatlar.Where(x => !x.YuklendiMi);
                }

                if (cmbBoxAkbiller.SelectedIndex >= 0)
                {
                    talimatlar = talimatlar.Where(x => x.Akbil.Substring(0, 16) == cmbBoxAkbiller.SelectedValue.ToString());
                }

                dataGridViewTalimatlar.DataSource = talimatlar.ToList();

                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;
                dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yüklendi Mi?";

                foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
                {
                    item.Width = 200;
                }
                dataGridViewTalimatlar.Columns["Akbil"].Width = 400;

                //istediğiniz diğer kolonlara da ayarlama yapabilirsiniz.
            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimatlar getirilirken hata oluştu! " + hata.Message);
            }
        }

        private void ComboBoxaKullanicininAkbilleriniGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciID).ToList();
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo";


            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }

        }

        private void cmbBoxAkbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = true;


            }
            else
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = false;


            }
            BekleyenTalimatSayisiniGetir();
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden talimat kaydedilemez! ");
                    return;
                }
                if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
                {
                    MessageBox.Show("Yükleme miktarı girişi zorunludur! ");
                    return;
                }
                if (!decimal.TryParse(txtYuklenecekTutar.Text.Trim(), out decimal tutar))
                {
                    MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır! ");
                    return;
                }

                Talimatlar yeniTalimat = new Talimatlar()
                {
                    EklenmeTarihi = DateTime.Now,
                    AkbilId = cmbBoxAkbiller.SelectedValue.ToString(),
                    YuklendiMi = false,
                    YukleneckTutar = Convert.ToDecimal(txtYuklenecekTutar.Text),
                    YuklenmeTarihi = null

                };

                context.Talimatlars.Add(yeniTalimat);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Yeni talimat eklendi!!");
                    //temizlik
                    txtYuklenecekTutar.Clear();
                    //cmbBoxAkbiller.SelectedIndex = -1;
                    //cmbBoxAkbiller.Text = "Akbil Seçiniz";

                    groupBoxYukleme.Enabled = false;
                    BekleyenTalimatSayisiniGetir();
                    TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);

                }
                else
                {
                    MessageBox.Show("Yeni talimat eklenemedi!!");
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimat kaydedilemedi! " + hata.Message);
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            //if yazılsa daha iyi olurdu
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
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

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            if (lblBekleyenTalimat.Text != "0")
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 40);
                    lblBekleyenTalimat.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 25);
                    lblBekleyenTalimat.ForeColor = Color.Red;
                }
            }
        }

        private void talimatiIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    //Yüklenmiş bir talimat iptal edilemez/silinemez.
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        MessageBox.Show($"DİKKAT! {item.Cells["Akbil"].Value} {item.Cells["YukleneckTutar"].Value} liralık yüklemesi yapılmıştır. YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ! \nİşlemlerinize devam etmek için tamama basınız.");
                        continue;
                    } // if bitti
                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);
                    if (secilenTalimat != null)
                    {
                        context.Talimatlars.Remove(secilenTalimat);
                        sayac += context.SaveChanges();

                    }
                } // foreach bitti

                MessageBox.Show($"Seçtiğiniz {sayac} adet talimat iptal edilmiştir.");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir sorun oluştu! " + hata.Message);
            }
        }

        private void talimatiYukleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        continue;
                    }
                    //önce talimat yüklendiMi=1 yapacağız.
                    var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);
                    if (secilenTalimat != null)
                    {
                        secilenTalimat.YuklendiMi = true;
                        secilenTalimat.YuklenmeTarihi = DateTime.Now;
                        context.Talimatlars.Update(secilenTalimat);
                        sayac += context.SaveChanges();

                        //sonra akbilin bakiyesine ekleme yapacağız.

                        secilenTalimat.Akbil.Bakiye = Convert.ToDecimal(item.Cells["YuklenckTutar"].Value);

                        context.Akbillers.Update(secilenTalimat.Akbil);
                        context.SaveChanges();
                    }



                } // foreach bitti.
                MessageBox.Show($"{sayac} adet talimat akbile yüklendi!");
                TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }

        private void lblBekleyenTalimat_Click(object sender, EventArgs e)
        {

        }

        private void txtYuklenecekTutar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}