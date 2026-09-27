namespace WinFormTestUygulama
{
    partial class FrmAddStudent
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtNumarasi = new TextBox();
            label3 = new Label();
            txtSinifi = new TextBox();
            label4 = new Label();
            txtTelefonu = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(64, 84);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Öğrencinin Adı";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(246, 81);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(384, 29);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(246, 116);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(384, 29);
            txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(64, 119);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 2;
            label2.Text = "Öğrencinin Soyadı";
            // 
            // txtNumarasi
            // 
            txtNumarasi.Font = new Font("Segoe UI", 12F);
            txtNumarasi.Location = new Point(246, 151);
            txtNumarasi.Name = "txtNumarasi";
            txtNumarasi.Size = new Size(384, 29);
            txtNumarasi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(64, 154);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 4;
            label3.Text = "Öğrencinin Numarası";
            // 
            // txtSinifi
            // 
            txtSinifi.Font = new Font("Segoe UI", 12F);
            txtSinifi.Location = new Point(246, 186);
            txtSinifi.Name = "txtSinifi";
            txtSinifi.Size = new Size(384, 29);
            txtSinifi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(64, 189);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 6;
            label4.Text = "Öğrencinin Sınıfı";
            // 
            // txtTelefonu
            // 
            txtTelefonu.Font = new Font("Segoe UI", 12F);
            txtTelefonu.Location = new Point(246, 221);
            txtTelefonu.Name = "txtTelefonu";
            txtTelefonu.Size = new Size(384, 29);
            txtTelefonu.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(64, 224);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 8;
            label5.Text = "Öğrencinin Telefonu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(288, 25);
            label6.Name = "label6";
            label6.Size = new Size(306, 37);
            label6.TabIndex = 10;
            label6.Text = "Öğrenci Ekleme Formu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Teal;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKaydet.Location = new Point(246, 265);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(384, 49);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(729, 376);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(txtTelefonu);
            Controls.Add(label5);
            Controls.Add(txtSinifi);
            Controls.Add(label4);
            Controls.Add(txtNumarasi);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "FrmAddStudent";
            Text = "FrmAddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtNumarasi;
        private Label label3;
        private TextBox txtSinifi;
        private Label label4;
        private TextBox txtTelefonu;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
    }
}