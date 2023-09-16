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
    public partial class FThemKhachHang : Form
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


        string gioiTinh = "";
        public FThemKhachHang()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton bt = (RadioButton)sender;

            gioiTinh = bt.Text;
        }
        private void btThemKHM_Click(object sender, EventArgs e)
        {
            //FKhachHang f = new FKhachHang(txtHoTen.Text, txtSDT.Text, txtSoCCCD.Text, gioiTinh, txtDiaChi.Text);

            //cần cập nhật thêm
            FKhachHang f = new FKhachHang(txtMaKH.Text, txtHoTen.Text,txtSDT.Text,txtSoCCCD.Text, gioiTinh, txtDiaChi.Text);
            FKhachHang.maKhachHang = txtMaKH.Text;
            FKhachHang.hoTenKhachHang = txtHoTen.Text;
            FKhachHang.soDienThoaiKhachhang = txtSDT.Text;
            FKhachHang.soCanCuocCongDanKhachHang = txtSoCCCD.Text;
            FKhachHang.gioiTinhKhachHang = gioiTinh;
            FKhachHang.diaChiKhachhHang = txtDiaChi.Text;

            //f.ShowDialog();
            this.Hide();
        }
    }
}
