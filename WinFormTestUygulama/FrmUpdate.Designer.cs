namespace WinFormTestUygulama
{
    partial class FrmUpdate
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
            btnUpdate = new Button();
            label6 = new Label();
            txtTelefonu = new TextBox();
            label5 = new Label();
            txtSinifi = new TextBox();
            label4 = new Label();
            txtNumarasi = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            lblID = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkKhaki;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(260, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(384, 49);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.Olive;
            label6.Location = new Point(260, 9);
            label6.Name = "label6";
            label6.Size = new Size(364, 37);
            label6.TabIndex = 22;
            label6.Text = "Öğrenci Güncelleme Formu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTelefonu
            // 
            txtTelefonu.Font = new Font("Segoe UI", 12F);
            txtTelefonu.Location = new Point(260, 295);
            txtTelefonu.Name = "txtTelefonu";
            txtTelefonu.Size = new Size(384, 29);
            txtTelefonu.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(78, 298);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 20;
            label5.Text = "Öğrencinin Telefonu";
            // 
            // txtSinifi
            // 
            txtSinifi.Font = new Font("Segoe UI", 12F);
            txtSinifi.Location = new Point(260, 260);
            txtSinifi.Name = "txtSinifi";
            txtSinifi.Size = new Size(384, 29);
            txtSinifi.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Olive;
            label4.Location = new Point(78, 263);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 18;
            label4.Text = "Öğrencinin Sınıfı";
            // 
            // txtNumarasi
            // 
            txtNumarasi.Font = new Font("Segoe UI", 12F);
            txtNumarasi.Location = new Point(260, 225);
            txtNumarasi.Name = "txtNumarasi";
            txtNumarasi.Size = new Size(384, 29);
            txtNumarasi.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(78, 228);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 16;
            label3.Text = "Öğrencinin Numarası";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F);
            txtSoyad.Location = new Point(260, 190);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(384, 29);
            txtSoyad.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(78, 193);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 14;
            label2.Text = "Öğrencinin Soyadı";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F);
            txtAd.Location = new Point(260, 155);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(384, 29);
            txtAd.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(78, 158);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 12;
            label1.Text = "Öğrencinin Adı";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblID.ForeColor = Color.Teal;
            lblID.Location = new Point(260, 120);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 21);
            lblID.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Olive;
            label8.Location = new Point(78, 120);
            label8.Name = "label8";
            label8.Size = new Size(127, 21);
            label8.TabIndex = 25;
            label8.Text = "Kayıt Numarası";
            // 
            // FrmUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(lblID);
            Controls.Add(btnUpdate);
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
            Name = "FrmUpdate";
            Text = "FrmUpdate";
            Load += FrmUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label6;
        private TextBox txtTelefonu;
        private Label label5;
        private TextBox txtSinifi;
        private Label label4;
        private TextBox txtNumarasi;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Label lblID;
        private Label label8;
    }
}