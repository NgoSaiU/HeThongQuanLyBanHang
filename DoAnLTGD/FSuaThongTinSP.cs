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
using System.Runtime.Intrinsics.Arm;

namespace DoAnLTGD
{
    public partial class FSuaThongTinSP : Form
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


        public static int viTriSua;
        public FSuaThongTinSP()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btSuaSP_Click(object sender, EventArgs e)
        {
            //FKhachHang f = new FKhachHang(txtHoTen.Text, txtSDT.Text, txtSoCCCD.Text, gioiTinh, txtDiaChi.Text);

            //cần cập nhật thêm
            FSanPham f = new FSanPham(txtMaSP.Text, txtTenSP.Text, txtSoLuong.Text, txtGiaBan.Text, txtGiamGia.Text);


            //kiểm tra tex, nếu là nam, thì thuộc tính bật lên và ngược;

            //rdNam. = FKhachHang.gioiTinhKhachHang;

            //txtDiaChi.Text = FKhachHang.diaChiKhachhHang;

            //Cập nhật lại thông tin

            FSanPham.maSanPham = txtMaSP.Text;
            FSanPham.tenSanPham = txtTenSP.Text;
            FSanPham.soLuongSanPham = txtSoLuong.Text;
            FSanPham.giaBanSanPham = txtGiaBan.Text;
            FSanPham.giamGiamGiaSanPham = txtGiamGia.Text;

            //DataGridViewRow newdata = dgvDemo.Rows[index];
            //newdata.Cells[0].Value = txtID.Text;
            //newdata.Cells[1].Value = txtFirstName.Text;
            //newdata.Cells[2].Value = txtLastName.Text;
            //newdata.Cells[3].Value = txtSum.Text;

            //f.ShowDialog();
            this.Hide();
        }

        private void FSuaThongTinSP_Load(object sender, EventArgs e)
        {
            txtMaSP.Text = FSanPham.maSanPham;
            txtTenSP.Text = FSanPham.tenSanPham;
            txtSoLuong.Text = FSanPham.soLuongSanPham;
            txtGiaBan.Text = FSanPham.soLuongSanPham;
            txtGiamGia.Text = FSanPham.giamGiamGiaSanPham;
        }
    }
}
