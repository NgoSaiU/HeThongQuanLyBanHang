namespace DoAnLTGD
{
    partial class FThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbPhamTramGiamGia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.ccbTenSanPham = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lsvThanhToan = new System.Windows.Forms.ListView();
            this.cotTenSanPham = new System.Windows.Forms.ColumnHeader("(none)");
            this.cotSoLuong = new System.Windows.Forms.ColumnHeader();
            this.cotDonGia = new System.Windows.Forms.ColumnHeader();
            this.cotGiamGia = new System.Windows.Forms.ColumnHeader();
            this.cotThanhTien = new System.Windows.Forms.ColumnHeader();
            this.btXoaSPThanhToan = new DoAnLTGD.RJButton();
            this.btThanhToan = new DoAnLTGD.RJButton();
            this.btSuaSPThanhToan = new DoAnLTGD.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btThemSPThanhToan = new DoAnLTGD.RJButton();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbPhamTramGiamGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTenNhanVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(59, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbPhamTramGiamGia
            // 
            this.lbPhamTramGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPhamTramGiamGia.Location = new System.Drawing.Point(38, 161);
            this.lbPhamTramGiamGia.Name = "lbPhamTramGiamGia";
            this.lbPhamTramGiamGia.Size = new System.Drawing.Size(310, 40);
            this.lbPhamTramGiamGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phần trăm giảm giá:";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTenNhanVien.Location = new System.Drawing.Point(32, 78);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(310, 40);
            this.lbTenNhanVien.TabIndex = 0;
            this.lbTenNhanVien.Text = "Nguyễn Minh Triết";
            this.lbTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.groupBox2.Controls.Add(this.numSoLuong);
            this.groupBox2.Controls.Add(this.lbGiaBan);
            this.groupBox2.Controls.Add(this.ccbTenSanPham);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(508, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 290);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(37, 237);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(310, 34);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGiaBan.Location = new System.Drawing.Point(37, 161);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(310, 40);
            this.lbGiaBan.TabIndex = 3;
            // 
            // ccbTenSanPham
            // 
            this.ccbTenSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.ccbTenSanPham.FormattingEnabled = true;
            this.ccbTenSanPham.Location = new System.Drawing.Point(37, 76);
            this.ccbTenSanPham.Name = "ccbTenSanPham";
            this.ccbTenSanPham.Size = new System.Drawing.Size(310, 36);
            this.ccbTenSanPham.TabIndex = 2;
            this.ccbTenSanPham.SelectedIndexChanged += new System.EventHandler(this.ccbTenSanPham_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn giá:";
            // 
            // lsvThanhToan
            // 
            this.lsvThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.lsvThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotTenSanPham,
            this.cotSoLuong,
            this.cotDonGia,
            this.cotGiamGia,
            this.cotThanhTien});
            this.lsvThanhToan.FullRowSelect = true;
            this.lsvThanhToan.GridLines = true;
            this.lsvThanhToan.Location = new System.Drawing.Point(59, 394);
            this.lsvThanhToan.Name = "lsvThanhToan";
            this.lsvThanhToan.Size = new System.Drawing.Size(832, 182);
            this.lsvThanhToan.TabIndex = 1;
            this.lsvThanhToan.UseCompatibleStateImageBehavior = false;
            this.lsvThanhToan.View = System.Windows.Forms.View.Details;
            this.lsvThanhToan.SelectedIndexChanged += new System.EventHandler(this.lsvThanhToan_SelectedIndexChanged);
            // 
            // cotTenSanPham
            // 
            this.cotTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // cotSoLuong
            // 
            this.cotSoLuong.Text = "Số Lượng";
            // 
            // cotDonGia
            // 
            this.cotDonGia.Text = "Đơn Giá";
            // 
            // cotGiamGia
            // 
            this.cotGiamGia.Text = "Phần Trăm Giảm Giá";
            // 
            // cotThanhTien
            // 
            this.cotThanhTien.Text = "Thành Tiền";
            // 
            // btXoaSPThanhToan
            // 
            this.btXoaSPThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btXoaSPThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btXoaSPThanhToan.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btXoaSPThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaSPThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btXoaSPThanhToan.BorderRadius = 5;
            this.btXoaSPThanhToan.BorderSize = 0;
            this.btXoaSPThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaSPThanhToan.FlatAppearance.BorderSize = 0;
            this.btXoaSPThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaSPThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoaSPThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btXoaSPThanhToan.Location = new System.Drawing.Point(639, 582);
            this.btXoaSPThanhToan.Name = "btXoaSPThanhToan";
            this.btXoaSPThanhToan.Size = new System.Drawing.Size(125, 50);
            this.btXoaSPThanhToan.TabIndex = 2;
            this.btXoaSPThanhToan.Text = "Xóa";
            this.btXoaSPThanhToan.TextColor = System.Drawing.Color.Black;
            this.btXoaSPThanhToan.UseVisualStyleBackColor = false;
            this.btXoaSPThanhToan.Click += new System.EventHandler(this.btXoaSPThanhToan_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btThanhToan.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btThanhToan.BorderRadius = 5;
            this.btThanhToan.BorderSize = 0;
            this.btThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhToan.FlatAppearance.BorderSize = 0;
            this.btThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btThanhToan.Location = new System.Drawing.Point(770, 582);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(125, 50);
            this.btThanhToan.TabIndex = 2;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.TextColor = System.Drawing.Color.Black;
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btSuaSPThanhToan
            // 
            this.btSuaSPThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btSuaSPThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btSuaSPThanhToan.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btSuaSPThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaSPThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSuaSPThanhToan.BorderRadius = 5;
            this.btSuaSPThanhToan.BorderSize = 0;
            this.btSuaSPThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuaSPThanhToan.FlatAppearance.BorderSize = 0;
            this.btSuaSPThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaSPThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSuaSPThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btSuaSPThanhToan.Location = new System.Drawing.Point(508, 582);
            this.btSuaSPThanhToan.Name = "btSuaSPThanhToan";
            this.btSuaSPThanhToan.Size = new System.Drawing.Size(125, 50);
            this.btSuaSPThanhToan.TabIndex = 2;
            this.btSuaSPThanhToan.Text = "Sửa";
            this.btSuaSPThanhToan.TextColor = System.Drawing.Color.Black;
            this.btSuaSPThanhToan.UseVisualStyleBackColor = false;
            this.btSuaSPThanhToan.Click += new System.EventHandler(this.btSuaSPThanhToan_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(112)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(375, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "THANH TOÁN";
            // 
            // btThemSPThanhToan
            // 
            this.btThemSPThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btThemSPThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btThemSPThanhToan.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btThemSPThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSPThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btThemSPThanhToan.BorderRadius = 5;
            this.btThemSPThanhToan.BorderSize = 0;
            this.btThemSPThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemSPThanhToan.FlatAppearance.BorderSize = 0;
            this.btThemSPThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemSPThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemSPThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btThemSPThanhToan.Location = new System.Drawing.Point(377, 582);
            this.btThemSPThanhToan.Name = "btThemSPThanhToan";
            this.btThemSPThanhToan.Size = new System.Drawing.Size(125, 50);
            this.btThemSPThanhToan.TabIndex = 2;
            this.btThemSPThanhToan.Text = "Thêm";
            this.btThemSPThanhToan.TextColor = System.Drawing.Color.Black;
            this.btThemSPThanhToan.UseVisualStyleBackColor = false;
            this.btThemSPThanhToan.Click += new System.EventHandler(this.btThemSPThanhToan_Click);
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(DoAnLTGD.SanPham);
            // 
            // FThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btThemSPThanhToan);
            this.Controls.Add(this.btSuaSPThanhToan);
            this.Controls.Add(this.btXoaSPThanhToan);
            this.Controls.Add(this.lsvThanhToan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThanhToan";
            this.Text = "FThanhToan";
            this.Load += new System.EventHandler(this.FThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView lsvThanhToan;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label lbTenNhanVien;
        private Label label1;
        private ComboBox ccbTenSanPham;
        private Label label5;
        private Label label6;
        private Label label11;
        private RJButton btXoaSPThanhToan;
        private RJButton btThanhToan;
        private RJButton btSuaSPThanhToan;
        private Label label8;
        private ColumnHeader cotTenSanPham;
        private ColumnHeader cotSoLuong;
        private ColumnHeader cotDonGia;
        private ColumnHeader cotGiamGia;
        private Label lbGiaBan;
        private RJButton btThemSPThanhToan;
        private BindingSource sanPhamBindingSource;
        private NumericUpDown numSoLuong;
        private Label lbPhamTramGiamGia;
        private ColumnHeader cotThanhTien;
    }
}