namespace WinFormTestUygulama
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnGiris = new Button();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(105, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 216);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.PaleTurquoise;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F);
            txtKullaniciAdi.Location = new Point(31, 240);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(267, 29);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.PaleTurquoise;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(31, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 29);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(31, 279);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "Parola";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Teal;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGiris.ForeColor = SystemColors.ActiveCaptionText;
            btnGiris.ImageAlign = ContentAlignment.MiddleRight;
            btnGiris.ImageKey = "pngwing.com (7).png";
            btnGiris.ImageList = ımageList1;
            btnGiris.Location = new Point(31, 346);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(266, 64);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "pngwing.com (6).png");
            ımageList1.Images.SetKeyName(1, "pngwing.com (7).png");
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(338, 487);
            Controls.Add(btnGiris);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtPassword;
        private Label label2;
        private Button btnGiris;
        private ImageList ımageList1;
    }
}