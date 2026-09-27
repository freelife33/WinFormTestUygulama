namespace WinFormTestUygulama
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnTest = new Button();
            btnFrmOgrenci = new Button();
            dgwOgrenciListesi = new DataGridView();
            panel1 = new Panel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnFrmUpdate = new Button();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciListesi).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.DarkSeaGreen;
            btnTest.Dock = DockStyle.Right;
            btnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTest.ForeColor = Color.Snow;
            btnTest.Location = new Point(883, 0);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(171, 48);
            btnTest.TabIndex = 0;
            btnTest.Text = "Bağlantıyı Test Et";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnFrmOgrenci
            // 
            btnFrmOgrenci.BackColor = Color.Teal;
            btnFrmOgrenci.Dock = DockStyle.Left;
            btnFrmOgrenci.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFrmOgrenci.ForeColor = Color.Snow;
            btnFrmOgrenci.Location = new Point(0, 0);
            btnFrmOgrenci.Name = "btnFrmOgrenci";
            btnFrmOgrenci.Size = new Size(171, 48);
            btnFrmOgrenci.TabIndex = 1;
            btnFrmOgrenci.Text = "Öğrenci Ekle";
            btnFrmOgrenci.UseVisualStyleBackColor = false;
            btnFrmOgrenci.Click += btnFrmOgrenci_Click;
            // 
            // dgwOgrenciListesi
            // 
            dgwOgrenciListesi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dgwOgrenciListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwOgrenciListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwOgrenciListesi.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwOgrenciListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwOgrenciListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwOgrenciListesi.DefaultCellStyle = dataGridViewCellStyle3;
            dgwOgrenciListesi.Dock = DockStyle.Fill;
            dgwOgrenciListesi.Location = new Point(0, 87);
            dgwOgrenciListesi.MultiSelect = false;
            dgwOgrenciListesi.Name = "dgwOgrenciListesi";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SkyBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgwOgrenciListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgwOgrenciListesi.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dgwOgrenciListesi.RowTemplate.Height = 35;
            dgwOgrenciListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwOgrenciListesi.Size = new Size(1054, 466);
            dgwOgrenciListesi.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnFrmUpdate);
            panel1.Controls.Add(btnTest);
            panel1.Controls.Add(btnFrmOgrenci);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 48);
            panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Dock = DockStyle.Left;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Snow;
            btnDelete.Location = new Point(385, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(214, 48);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Seçili Öğrenciyi Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DeepSkyBlue;
            btnRefresh.Dock = DockStyle.Right;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Snow;
            btnRefresh.Location = new Point(757, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 48);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Listeyi Yenile";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFrmUpdate
            // 
            btnFrmUpdate.BackColor = Color.DarkKhaki;
            btnFrmUpdate.Dock = DockStyle.Left;
            btnFrmUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFrmUpdate.ForeColor = Color.Snow;
            btnFrmUpdate.Location = new Point(171, 0);
            btnFrmUpdate.Name = "btnFrmUpdate";
            btnFrmUpdate.Size = new Size(214, 48);
            btnFrmUpdate.TabIndex = 2;
            btnFrmUpdate.Text = "Seçili Öğrenciyi Güncelle";
            btnFrmUpdate.UseVisualStyleBackColor = false;
            btnFrmUpdate.Click += btnFrmUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1054, 39);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1054, 39);
            label1.TabIndex = 0;
            label1.Text = "KAYITLI ÖĞRENCİ LİSTESİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 553);
            Controls.Add(dgwOgrenciListesi);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwOgrenciListesi).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private Button btnFrmOgrenci;
        private DataGridView dgwOgrenciListesi;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnFrmUpdate;
        private Button btnRefresh;
        private Button btnDelete;
    }
}
