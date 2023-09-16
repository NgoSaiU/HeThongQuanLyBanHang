namespace DoAnLTGD
{
    partial class DangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDangNhap = new DoAnLTGD.RJButton();
            this.bntExit = new DoAnLTGD.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phide = new System.Windows.Forms.PictureBox();
            this.peye = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnLTGD.Properties.Resources.logo_1_removebg_preview1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(134, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(76, 263);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(248, 20);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatKhau.Location = new System.Drawing.Point(76, 312);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(209, 20);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.cbbChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(76, 217);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(248, 28);
            this.cbbChucVu.TabIndex = 3;
            this.cbbChucVu.Text = "-- Chọn chức vụ --";
            this.cbbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbbChucVu_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.btDangNhap);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phide);
            this.panel1.Controls.Add(this.peye);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbbChucVu);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(625, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 553);
            this.panel1.TabIndex = 5;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDangNhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDangNhap.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDangNhap.BorderRadius = 10;
            this.btDangNhap.BorderSize = 0;
            this.btDangNhap.FlatAppearance.BorderSize = 0;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btDangNhap.Location = new System.Drawing.Point(105, 413);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(188, 50);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.TextColor = System.Drawing.Color.Black;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.bntExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.bntExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bntExit.BorderRadius = 5;
            this.bntExit.BorderSize = 0;
            this.bntExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExit.FlatAppearance.BorderSize = 0;
            this.bntExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntExit.ForeColor = System.Drawing.Color.Black;
            this.bntExit.Location = new System.Drawing.Point(346, 12);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(30, 30);
            this.bntExit.TabIndex = 9;
            this.bntExit.Text = "X";
            this.bntExit.TextColor = System.Drawing.Color.Black;
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(104)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(115, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "APPLE STORE";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 3);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 3);
            this.label1.TabIndex = 6;
            // 
            // phide
            // 
            this.phide.BackgroundImage = global::DoAnLTGD.Properties.Resources._495_4950508_show_password_show_password_icon_png_transparent_png_removebg_preview;
            this.phide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.phide.Location = new System.Drawing.Point(294, 305);
            this.phide.Name = "phide";
            this.phide.Size = new System.Drawing.Size(30, 30);
            this.phide.TabIndex = 5;
            this.phide.TabStop = false;
            this.phide.Click += new System.EventHandler(this.phide_Click);
            // 
            // peye
            // 
            this.peye.BackgroundImage = global::DoAnLTGD.Properties.Resources.show_password;
            this.peye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.peye.Location = new System.Drawing.Point(294, 305);
            this.peye.Name = "peye";
            this.peye.Size = new System.Drawing.Size(30, 30);
            this.peye.TabIndex = 5;
            this.peye.TabStop = false;
            this.peye.Click += new System.EventHandler(this.peye_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DoAnLTGD.Properties.Resources.kisspng_computer_icons_public_key_infrastructure_5b0ac8421bb791_2926023915274332821135_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(28, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DoAnLTGD.Properties.Resources.kisspng_computer_icons_google_account_icon_design_login_5afc02dab4a218_0950785215264652427399_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(28, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTGD.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 553);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private ComboBox cbbChucVu;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox phide;
        private PictureBox peye;
        private Label label3;
        private RJButton bntExit;
        private RJButton btDangNhap;
        
    }
}