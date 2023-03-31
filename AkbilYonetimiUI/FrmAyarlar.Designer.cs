namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSifre = new TextBox();
            btnGuncelle = new Button();
            dtpDogumTarihi = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            aNASAYFAToolStripMenuItem = new ToolStripMenuItem();
            çIKIŞToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(242, 27);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(263, 72);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Yeni Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(65, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(65, 74);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(65, 117);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(160, 23);
            txtSoyad.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(329, 69);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(171, 23);
            txtSifre.TabIndex = 9;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.IndianRed;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = SystemColors.ControlText;
            btnGuncelle.Location = new Point(12, 219);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(484, 77);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(329, 24);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(171, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNASAYFAToolStripMenuItem, çIKIŞToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(508, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            aNASAYFAToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            aNASAYFAToolStripMenuItem.Size = new Size(78, 20);
            aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            aNASAYFAToolStripMenuItem.Click += aNASAYFAToolStripMenuItem_Click;
            // 
            // çIKIŞToolStripMenuItem
            // 
            çIKIŞToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            çIKIŞToolStripMenuItem.Size = new Size(49, 20);
            çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            çIKIŞToolStripMenuItem.Click += çIKIŞToolStripMenuItem_Click;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1656413801326;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(508, 308);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(btnGuncelle);
            Controls.Add(txtSifre);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmAyarlar";
            Text = "GÜNCELLEME";
            Load += FrmAyarlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSifre;
        private Button btnGuncelle;
        private DateTimePicker dtpDogumTarihi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}