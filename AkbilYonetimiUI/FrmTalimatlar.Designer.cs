namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalimatlar));
            menuStrip1 = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxAkbiller = new ComboBox();
            label1 = new Label();
            txtYuklenecekTutar = new TextBox();
            btnTalimatKaydet = new Button();
            label = new Label();
            lblBekleyenTalimat = new Label();
            checkBoxTumunuGoster = new CheckBox();
            dataGridViewTalimatlar = new DataGridView();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            groupBoxYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(587, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(78, 20);
            anaMenüToolStripMenuItem.Text = "ANASAYFA";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(49, 20);
            cikisYapToolStripMenuItem.Text = "ÇIKIŞ";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(12, 43);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(356, 23);
            cmbBoxAkbiller.TabIndex = 1;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar";
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(109, 27);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(125, 23);
            txtYuklenecekTutar.TabIndex = 3;
            txtYuklenecekTutar.TextChanged += txtYuklenecekTutar_TextChanged;
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.BackColor = Color.MediumBlue;
            btnTalimatKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTalimatKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnTalimatKaydet.Location = new Point(238, 22);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(118, 32);
            btnTalimatKaydet.TabIndex = 4;
            btnTalimatKaydet.Text = "TALİMATI KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = false;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.RosyBrown;
            label.Location = new Point(379, 43);
            label.Name = "label";
            label.Size = new Size(206, 32);
            label.TabIndex = 5;
            label.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.RosyBrown;
            lblBekleyenTalimat.Location = new Point(463, 75);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(28, 32);
            lblBekleyenTalimat.TabIndex = 6;
            lblBekleyenTalimat.Text = "0";
            lblBekleyenTalimat.Click += lblBekleyenTalimat_Click;
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxTumunuGoster.ForeColor = SystemColors.ButtonHighlight;
            checkBoxTumunuGoster.Location = new Point(25, 146);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(112, 19);
            checkBoxTumunuGoster.TabIndex = 7;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(19, 176);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowTemplate.Height = 25;
            dataGridViewTalimatlar.Size = new Size(557, 126);
            dataGridViewTalimatlar.TabIndex = 8;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 48);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.Image = (Image)resources.GetObject("talimatiYukleToolStripMenuItem.Image");
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(154, 22);
            talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.Image = (Image)resources.GetObject("talimatiIptalEtToolStripMenuItem.Image");
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(154, 22);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxYukleme.Location = new Point(12, 72);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(361, 68);
            groupBoxYukleme.TabIndex = 9;
            groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(587, 314);
            Controls.Add(groupBoxYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(label);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmTalimatlar";
            Text = "TALİMAT İŞLEMLERİ";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbBoxAkbiller;
        private Label label1;
        private TextBox txtYuklenecekTutar;
        private Button btnTalimatKaydet;
        private Label label;
        private Label lblBekleyenTalimat;
        private CheckBox checkBoxTumunuGoster;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}