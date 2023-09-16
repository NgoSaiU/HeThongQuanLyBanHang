namespace DoAnLTGD
{
    partial class FKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.btTiemKiemKH = new DoAnLTGD.RJButton();
            this.btThemKH = new DoAnLTGD.RJButton();
            this.btSuaKH = new DoAnLTGD.RJButton();
            this.btXoaKH = new DoAnLTGD.RJButton();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.txtTimKiemKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiemKH.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemKH.Location = new System.Drawing.Point(70, 80);
            this.txtTimKiemKH.Multiline = true;
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(700, 35);
            this.txtTimKiemKH.TabIndex = 1;
            this.txtTimKiemKH.Text = "Tìm kiếm khách hàng";
            this.txtTimKiemKH.Enter += new System.EventHandler(this.txtTimKiemKH_Enter);
            this.txtTimKiemKH.Leave += new System.EventHandler(this.txtTimKiemKH_Leave);
            // 
            // btTiemKiemKH
            // 
            this.btTiemKiemKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btTiemKiemKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btTiemKiemKH.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btTiemKiemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTiemKiemKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btTiemKiemKH.BorderRadius = 10;
            this.btTiemKiemKH.BorderSize = 0;
            this.btTiemKiemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTiemKiemKH.FlatAppearance.BorderSize = 0;
            this.btTiemKiemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTiemKiemKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTiemKiemKH.ForeColor = System.Drawing.Color.Black;
            this.btTiemKiemKH.Location = new System.Drawing.Point(790, 70);
            this.btTiemKiemKH.Name = "btTiemKiemKH";
            this.btTiemKiemKH.Size = new System.Drawing.Size(125, 50);
            this.btTiemKiemKH.TabIndex = 2;
            this.btTiemKiemKH.Text = "Tìm kiếm";
            this.btTiemKiemKH.TextColor = System.Drawing.Color.Black;
            this.btTiemKiemKH.UseVisualStyleBackColor = false;
            // 
            // btThemKH
            // 
            this.btThemKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btThemKH.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btThemKH.BorderRadius = 10;
            this.btThemKH.BorderSize = 0;
            this.btThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemKH.FlatAppearance.BorderSize = 0;
            this.btThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThemKH.ForeColor = System.Drawing.Color.Black;
            this.btThemKH.Location = new System.Drawing.Point(546, 557);
            this.btThemKH.Name = "btThemKH";
            this.btThemKH.Size = new System.Drawing.Size(125, 50);
            this.btThemKH.TabIndex = 2;
            this.btThemKH.Text = "Thêm";
            this.btThemKH.TextColor = System.Drawing.Color.Black;
            this.btThemKH.UseVisualStyleBackColor = false;
            this.btThemKH.Click += new System.EventHandler(this.btThemKH_Click);
            // 
            // btSuaKH
            // 
            this.btSuaKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSuaKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSuaKH.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btSuaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSuaKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSuaKH.BorderRadius = 10;
            this.btSuaKH.BorderSize = 0;
            this.btSuaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuaKH.FlatAppearance.BorderSize = 0;
            this.btSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSuaKH.ForeColor = System.Drawing.Color.Black;
            this.btSuaKH.Location = new System.Drawing.Point(686, 557);
            this.btSuaKH.Name = "btSuaKH";
            this.btSuaKH.Size = new System.Drawing.Size(125, 50);
            this.btSuaKH.TabIndex = 2;
            this.btSuaKH.Text = "Sửa";
            this.btSuaKH.TextColor = System.Drawing.Color.Black;
            this.btSuaKH.UseVisualStyleBackColor = false;
            this.btSuaKH.Click += new System.EventHandler(this.btSuaKH_Click);
            // 
            // btXoaKH
            // 
            this.btXoaKH.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btXoaKH.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btXoaKH.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.btXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btXoaKH.BorderRadius = 10;
            this.btXoaKH.BorderSize = 0;
            this.btXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoaKH.FlatAppearance.BorderSize = 0;
            this.btXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btXoaKH.Location = new System.Drawing.Point(817, 557);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(125, 50);
            this.btXoaKH.TabIndex = 2;
            this.btXoaKH.Text = "Xóa";
            this.btXoaKH.TextColor = System.Drawing.Color.Black;
            this.btXoaKH.UseVisualStyleBackColor = false;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(127)))));
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(70, 150);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 29;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(845, 380);
            this.dgvKH.TabIndex = 3;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnLTGD.Properties.Resources.ảnh_nền;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btXoaKH);
            this.Controls.Add(this.btSuaKH);
            this.Controls.Add(this.btThemKH);
            this.Controls.Add(this.btTiemKiemKH);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKhachHang";
            this.Text = "FKhachHang";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTimKiemKH;
        private RJButton btTiemKiemKH;
        private RJButton btThemKH;
        private RJButton btSuaKH;
        private RJButton btXoaKH;
        private DataGridView dgvKH;
    }
}