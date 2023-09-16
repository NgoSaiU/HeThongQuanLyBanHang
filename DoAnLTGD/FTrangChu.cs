using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DoAnLTGD
{
    public partial class FTrangChu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,          //x-cordinate of upper left - corner
            int nTopRect,           //y-cordinate of upper left - corner
            int nRingtRect,         //x-cordinate of lower left - corner
            int nBottomRect,        //y-cordinate of upper left - corner 
            int nWidthEllipse,      //Width of Ellipse
            int nHeightEllipse      //Height of Ellipse
            );

        public static string cbnv, namenv;

        string chucVu, tenNV;
        public FTrangChu()
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        
        public FTrangChu(string chucVu, string tenNV)
        {
            this.chucVu = chucVu;
            this.tenNV = tenNV;
        }

        private void loadform(object Form)
        {
            if(this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            loadform(new FThanhToan());// load form thanh toán
        }
        private void btSanPham_Click(object sender, EventArgs e)
        {
            loadform(new FSanPham());// load form sản phẩm
        }
        private void btKhachHang_Click(object sender, EventArgs e)
        {
            loadform(new FKhachHang());// load form khách hàng
        }
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap fDangNhap = new DangNhap();
            this.Close();
            fDangNhap.ShowDialog();
            
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            
            lbHoVaTen.Text = namenv;
            lbChucVu.Text = cbnv;
        
        }

    }
}
