namespace AkbilYonetimiUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxGiris = new GroupBox();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            checkBoxHatirla = new CheckBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpBoxGiris.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxGiris
            // 
            grpBoxGiris.BackColor = Color.Transparent;
            grpBoxGiris.Controls.Add(btnGirisYap);
            grpBoxGiris.Controls.Add(btnKayitOl);
            grpBoxGiris.Controls.Add(checkBoxHatirla);
            grpBoxGiris.Controls.Add(txtSifre);
            grpBoxGiris.Controls.Add(txtEmail);
            grpBoxGiris.Controls.Add(label2);
            grpBoxGiris.Controls.Add(label1);
            grpBoxGiris.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpBoxGiris.Location = new Point(3, 12);
            grpBoxGiris.Name = "grpBoxGiris";
            grpBoxGiris.Size = new Size(188, 158);
            grpBoxGiris.TabIndex = 0;
            grpBoxGiris.TabStop = false;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.IndianRed;
            btnGirisYap.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(108, 118);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(75, 39);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.IndianRed;
            btnKayitOl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(22, 118);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(66, 39);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(55, 81);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(93, 19);
            checkBoxHatirla.TabIndex = 4;
            checkBoxHatirla.Text = "Beni Hatırla!";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            checkBoxHatirla.CheckedChanged += checkBoxHatirla_CheckedChanged_1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(56, 44);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(123, 21);
            txtSifre.TabIndex = 3;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(56, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(123, 21);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ekran_görüntüsü_2023_03_24_112005;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(367, 362);
            Controls.Add(grpBoxGiris);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "HOŞGELDİNİZ...";
            Load += Form1_Load;
            grpBoxGiris.ResumeLayout(false);
            grpBoxGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxGiris;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private CheckBox checkBoxHatirla;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}