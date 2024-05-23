namespace Kel4_PBO
{
    partial class KinkAppAdmin
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
            panelMenu = new Panel();
            iconButtonDataKaryawan = new FontAwesome.Sharp.IconButton();
            iconButtonPesanan = new FontAwesome.Sharp.IconButton();
            iconButtonDataBarang = new FontAwesome.Sharp.IconButton();
            iconButtonKotakMasuk = new FontAwesome.Sharp.IconButton();
            iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            labelHome = new Label();
            panel1 = new Panel();
            panelHeader = new Panel();
            labelChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            iconButtonExit = new FontAwesome.Sharp.IconButton();
            panelContent = new Panel();
            labelHomeApp = new Label();
            pictureBoxHome = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(iconButtonDataKaryawan);
            panelMenu.Controls.Add(iconButtonPesanan);
            panelMenu.Controls.Add(iconButtonDataBarang);
            panelMenu.Controls.Add(iconButtonKotakMasuk);
            panelMenu.Controls.Add(iconButtonDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(270, 729);
            panelMenu.TabIndex = 0;
            // 
            // iconButtonDataKaryawan
            // 
            iconButtonDataKaryawan.Dock = DockStyle.Top;
            iconButtonDataKaryawan.FlatAppearance.BorderSize = 0;
            iconButtonDataKaryawan.FlatStyle = FlatStyle.Flat;
            iconButtonDataKaryawan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDataKaryawan.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonDataKaryawan.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButtonDataKaryawan.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDataKaryawan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDataKaryawan.IconSize = 35;
            iconButtonDataKaryawan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDataKaryawan.Location = new Point(0, 400);
            iconButtonDataKaryawan.Name = "iconButtonDataKaryawan";
            iconButtonDataKaryawan.Padding = new Padding(30, 0, 0, 0);
            iconButtonDataKaryawan.Size = new Size(270, 60);
            iconButtonDataKaryawan.TabIndex = 5;
            iconButtonDataKaryawan.Text = "Data Karyawan";
            iconButtonDataKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDataKaryawan.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDataKaryawan.UseVisualStyleBackColor = true;
            iconButtonDataKaryawan.Click += iconButtonDataKaryawan_Click;
            // 
            // iconButtonPesanan
            // 
            iconButtonPesanan.Dock = DockStyle.Top;
            iconButtonPesanan.FlatAppearance.BorderSize = 0;
            iconButtonPesanan.FlatStyle = FlatStyle.Flat;
            iconButtonPesanan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonPesanan.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonPesanan.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconButtonPesanan.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonPesanan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPesanan.IconSize = 35;
            iconButtonPesanan.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPesanan.Location = new Point(0, 340);
            iconButtonPesanan.Name = "iconButtonPesanan";
            iconButtonPesanan.Padding = new Padding(30, 0, 0, 0);
            iconButtonPesanan.Size = new Size(270, 60);
            iconButtonPesanan.TabIndex = 4;
            iconButtonPesanan.Text = "Pesanan";
            iconButtonPesanan.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonPesanan.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonPesanan.UseVisualStyleBackColor = true;
            iconButtonPesanan.Click += iconButtonPesanan_Click;
            // 
            // iconButtonDataBarang
            // 
            iconButtonDataBarang.Dock = DockStyle.Top;
            iconButtonDataBarang.FlatAppearance.BorderSize = 0;
            iconButtonDataBarang.FlatStyle = FlatStyle.Flat;
            iconButtonDataBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDataBarang.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonDataBarang.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            iconButtonDataBarang.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDataBarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDataBarang.IconSize = 35;
            iconButtonDataBarang.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.Location = new Point(0, 280);
            iconButtonDataBarang.Name = "iconButtonDataBarang";
            iconButtonDataBarang.Padding = new Padding(30, 0, 0, 0);
            iconButtonDataBarang.Size = new Size(270, 60);
            iconButtonDataBarang.TabIndex = 3;
            iconButtonDataBarang.Text = "Data Barang";
            iconButtonDataBarang.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDataBarang.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDataBarang.UseVisualStyleBackColor = true;
            iconButtonDataBarang.Click += iconButtonDataBarang_Click;
            // 
            // iconButtonKotakMasuk
            // 
            iconButtonKotakMasuk.Dock = DockStyle.Top;
            iconButtonKotakMasuk.FlatAppearance.BorderSize = 0;
            iconButtonKotakMasuk.FlatStyle = FlatStyle.Flat;
            iconButtonKotakMasuk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonKotakMasuk.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonKotakMasuk.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            iconButtonKotakMasuk.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonKotakMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKotakMasuk.IconSize = 35;
            iconButtonKotakMasuk.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKotakMasuk.Location = new Point(0, 220);
            iconButtonKotakMasuk.Name = "iconButtonKotakMasuk";
            iconButtonKotakMasuk.Padding = new Padding(30, 0, 0, 0);
            iconButtonKotakMasuk.Size = new Size(270, 60);
            iconButtonKotakMasuk.TabIndex = 2;
            iconButtonKotakMasuk.Text = "Kotak Masuk";
            iconButtonKotakMasuk.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonKotakMasuk.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonKotakMasuk.UseVisualStyleBackColor = true;
            iconButtonKotakMasuk.Click += iconButtonKotakMasuk_Click;
            // 
            // iconButtonDashboard
            // 
            iconButtonDashboard.Dock = DockStyle.Top;
            iconButtonDashboard.FlatAppearance.BorderSize = 0;
            iconButtonDashboard.FlatStyle = FlatStyle.Flat;
            iconButtonDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButtonDashboard.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconButtonDashboard.IconColor = Color.FromArgb(255, 102, 36);
            iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDashboard.IconSize = 35;
            iconButtonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDashboard.Location = new Point(0, 160);
            iconButtonDashboard.Name = "iconButtonDashboard";
            iconButtonDashboard.Padding = new Padding(30, 0, 0, 0);
            iconButtonDashboard.Size = new Size(270, 60);
            iconButtonDashboard.TabIndex = 1;
            iconButtonDashboard.Text = "Dashboard";
            iconButtonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDashboard.UseVisualStyleBackColor = true;
            iconButtonDashboard.Click += iconButtonDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Black;
            panelLogo.Controls.Add(btnHome);
            panelLogo.Controls.Add(labelHome);
            panelLogo.Controls.Add(panel1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(270, 160);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.logo;
            btnHome.Location = new Point(42, 46);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(70, 70);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 4;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.ForeColor = Color.White;
            labelHome.Location = new Point(120, 69);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(73, 32);
            labelHome.TabIndex = 3;
            labelHome.Text = "KINK";
            // 
            // panel1
            // 
            panel1.Location = new Point(267, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 188);
            panel1.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(35, 35, 35);
            panelHeader.Controls.Add(labelChildForm);
            panelHeader.Controls.Add(iconCurrentChildForm);
            panelHeader.Controls.Add(iconButtonMinimize);
            panelHeader.Controls.Add(iconButtonExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(270, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(738, 160);
            panelHeader.TabIndex = 1;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // labelChildForm
            // 
            labelChildForm.AutoSize = true;
            labelChildForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChildForm.ForeColor = Color.White;
            labelChildForm.Location = new Point(84, 75);
            labelChildForm.Name = "labelChildForm";
            labelChildForm.Size = new Size(55, 21);
            labelChildForm.TabIndex = 3;
            labelChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(35, 35, 35);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(37, 65);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // iconButtonMinimize
            // 
            iconButtonMinimize.FlatAppearance.BorderSize = 0;
            iconButtonMinimize.FlatStyle = FlatStyle.Flat;
            iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButtonMinimize.IconColor = Color.Black;
            iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMinimize.Location = new Point(680, 7);
            iconButtonMinimize.Name = "iconButtonMinimize";
            iconButtonMinimize.Padding = new Padding(0, 0, 0, 20);
            iconButtonMinimize.Size = new Size(15, 15);
            iconButtonMinimize.TabIndex = 1;
            iconButtonMinimize.UseVisualStyleBackColor = true;
            iconButtonMinimize.Click += iconButtonMinimize_Click;
            // 
            // iconButtonExit
            // 
            iconButtonExit.FlatAppearance.BorderSize = 0;
            iconButtonExit.FlatStyle = FlatStyle.Flat;
            iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonExit.IconColor = Color.Black;
            iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonExit.Location = new Point(709, 7);
            iconButtonExit.Name = "iconButtonExit";
            iconButtonExit.Size = new Size(20, 20);
            iconButtonExit.TabIndex = 0;
            iconButtonExit.UseVisualStyleBackColor = true;
            iconButtonExit.Click += iconButtonExit_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(35, 35, 35);
            panelContent.Controls.Add(labelHomeApp);
            panelContent.Controls.Add(pictureBoxHome);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(270, 160);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(738, 569);
            panelContent.TabIndex = 2;
            // 
            // labelHomeApp
            // 
            labelHomeApp.AutoSize = true;
            labelHomeApp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHomeApp.ForeColor = Color.White;
            labelHomeApp.Location = new Point(303, 217);
            labelHomeApp.Name = "labelHomeApp";
            labelHomeApp.Size = new Size(112, 32);
            labelHomeApp.TabIndex = 6;
            labelHomeApp.Text = "KinkApp";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.logo;
            pictureBoxHome.Location = new Point(285, 60);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(150, 150);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHome.TabIndex = 5;
            pictureBoxHome.TabStop = false;
            // 
            // KinkAppAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "KinkAppAdmin";
            Text = "KinkApp";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonDataKaryawan;
        private FontAwesome.Sharp.IconButton iconButtonPesanan;
        private FontAwesome.Sharp.IconButton iconButtonDataBarang;
        private FontAwesome.Sharp.IconButton iconButtonKotakMasuk;
        private Panel panel1;
        private Panel panelHeader;
        private Panel panelContent;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private Label labelHome;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label labelChildForm;
        private Label labelHomeApp;
        private PictureBox pictureBoxHome;
    }
}
