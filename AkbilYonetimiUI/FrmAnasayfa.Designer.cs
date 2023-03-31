namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            btnAkbil = new Button();
            btnTalimat = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = Color.DarkOrange;
            btnAkbil.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAkbil.Location = new Point(63, 12);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(217, 95);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "AKBİL İŞLEMLERİ";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimat
            // 
            btnTalimat.BackColor = Color.GreenYellow;
            btnTalimat.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTalimat.Location = new Point(63, 123);
            btnTalimat.Name = "btnTalimat";
            btnTalimat.Size = new Size(217, 98);
            btnTalimat.TabIndex = 1;
            btnTalimat.Text = "TALİMAT İŞLEMLERİ";
            btnTalimat.UseVisualStyleBackColor = false;
            btnTalimat.Click += btnTalimat_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.LightSeaGreen;
            btnAyarlar.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyarlar.Location = new Point(63, 238);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(217, 88);
            btnAyarlar.TabIndex = 2;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FrmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(339, 355);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimat);
            Controls.Add(btnAkbil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAnasayfa";
            Text = "ANASAYFA";
            FormClosed += FrmAnasayfa_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}