namespace DoAnLTGD
{
    partial class FSanPham
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiemSanPham = new DoAnLTGD.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaSanPham = new DoAnLTGD.RJButton();
            this.btSuaSanPham = new DoAnLTGD.RJButton();
            this.btThemSanPham = new DoAnLTGD.RJButton();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(67, 76);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(700, 35);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Nhập Mã Sản Phẩm";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btTimKiemSanPham
            // 
            this.btTimKiemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btTimKiemSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.btTimKiemSanPham.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btTimKiemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiemSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btTimKiemSanPham.BorderRadius = 10;
            this.btTimKiemSanPham.BorderSize = 0;
            this.btTimKiemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTimKiemSanPham.FlatAppearance.BorderSize = 0;
            this.btTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiemSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTimKiemSanPham.ForeColor = System.Drawing.Color.Black;
            this.btTimKiemSanPham.Location = new System.Drawing.Point(790, 67);
            this.btTimKiemSanPham.Name = "btTimKiemSanPham";
            this.btTimKiemSanPham.Size = new System.Drawing.Size(125, 50);
            this.btTimKiemSanPham.TabIndex = 3;
            this.btTimKiemSanPham.Text = "Tìm kiếm";
            this.btTimKiemSanPham.TextColor = System.Drawing.Color.Black;
            this.btTimKiemSanPham.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "SẢN PHẨM";
            // 
            // btXoaSanPham
            // 
            this.btXoaSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btXoaSanPham.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btXoaSanPham.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btXoaSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btXoaSanPham.BorderRadius = 10;
            this.btXoaSanPham.BorderSize = 0;
            this.btXoaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaSanPham.FlatAppearance.BorderSize = 0;
            this.btXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoaSanPham.ForeColor = System.Drawing.Color.Black;
            this.btXoaSanPham.Location = new System.Drawing.Point(790, 563);
            this.btXoaSanPham.Name = "btXoaSanPham";
            this.btXoaSanPham.Size = new System.Drawing.Size(125, 50);
            this.btXoaSanPham.TabIndex = 5;
            this.btXoaSanPham.Text = "Xóa";
            this.btXoaSanPham.TextColor = System.Drawing.Color.Black;
            this.btXoaSanPham.UseVisualStyleBackColor = false;
            this.btXoaSanPham.Click += new System.EventHandler(this.btXoaSanPham_Click);
            // 
            // btSuaSanPham
            // 
            this.btSuaSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSuaSanPham.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSuaSanPham.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btSuaSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSuaSanPham.BorderRadius = 10;
            this.btSuaSanPham.BorderSize = 0;
            this.btSuaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuaSanPham.FlatAppearance.BorderSize = 0;
            this.btSuaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSuaSanPham.ForeColor = System.Drawing.Color.Black;
            this.btSuaSanPham.Location = new System.Drawing.Point(659, 563);
            this.btSuaSanPham.Name = "btSuaSanPham";
            this.btSuaSanPham.Size = new System.Drawing.Size(125, 50);
            this.btSuaSanPham.TabIndex = 6;
            this.btSuaSanPham.Text = "Sửa";
            this.btSuaSanPham.TextColor = System.Drawing.Color.Black;
            this.btSuaSanPham.UseVisualStyleBackColor = false;
            this.btSuaSanPham.Click += new System.EventHandler(this.btSuaSanPham_Click);
            // 
            // btThemSanPham
            // 
            this.btThemSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemSanPham.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemSanPham.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btThemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSanPham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btThemSanPham.BorderRadius = 10;
            this.btThemSanPham.BorderSize = 0;
            this.btThemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemSanPham.FlatAppearance.BorderSize = 0;
            this.btThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemSanPham.ForeColor = System.Drawing.Color.Black;
            this.btThemSanPham.Location = new System.Drawing.Point(528, 563);
            this.btThemSanPham.Name = "btThemSanPham";
            this.btThemSanPham.Size = new System.Drawing.Size(125, 50);
            this.btThemSanPham.TabIndex = 7;
            this.btThemSanPham.Text = "Thêm";
            this.btThemSanPham.TextColor = System.Drawing.Color.Black;
            this.btThemSanPham.UseVisualStyleBackColor = false;
            this.btThemSanPham.Click += new System.EventHandler(this.btThemSanPham_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(70, 146);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 29;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(845, 380);
            this.dgvSanPham.TabIndex = 8;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // FSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btXoaSanPham);
            this.Controls.Add(this.btSuaSanPham);
            this.Controls.Add(this.btThemSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTimKiemSanPham);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSanPham";
            this.Text = "FQuanLyKho";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTimKiem;
        private RJButton btTimKiemSanPham;
        private Label label1;
        private RJButton btXoaSanPham;
        private RJButton btSuaSanPham;
        private RJButton btThemSanPham;
        private DataGridView dgvSanPham;
    }
}