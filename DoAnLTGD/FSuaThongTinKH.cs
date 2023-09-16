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
using System.Reflection;

namespace DoAnLTGD
{
   
    public partial class FSuaThongTinKH : Form
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
        string gioiTinh = "";
        public FSuaThongTinKH()
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

        private void btSuaThongTinKH_Click(object sender, EventArgs e)
        {
            //FKhachHang f = new FKhachHang(txtHoTen.Text, txtSDT.Text, txtSoCCCD.Text, gioiTinh, txtDiaChi.Text);

            //cần cập nhật thêm
            FKhachHang f = new FKhachHang(txtMaKH.Text, txtHoTen.Text, txtSDT.Text, txtSoCCCD.Text, gioiTinh, txtDiaChi.Text);

        
            //kiểm tra tex, nếu là nam, thì thuộc tính bật lên và ngược;

            //rdNam. = FKhachHang.gioiTinhKhachHang;

            //txtDiaChi.Text = FKhachHang.diaChiKhachhHang;

            //Cập nhật lại thông tin
            FKhachHang.maKhachHang = txtMaKH.Text;
            FKhachHang.hoTenKhachHang = txtHoTen.Text;
            FKhachHang.soDienThoaiKhachhang = txtSDT.Text;
            FKhachHang.soCanCuocCongDanKhachHang = txtSoCCCD.Text;
            FKhachHang.gioiTinhKhachHang = gioiTinh;
            FKhachHang.diaChiKhachhHang = txtDiaChi.Text;




            //DataGridViewRow newdata = dgvDemo.Rows[index];
            //newdata.Cells[0].Value = txtID.Text;
            //newdata.Cells[1].Value = txtFirstName.Text;
            //newdata.Cells[2].Value = txtLastName.Text;
            //newdata.Cells[3].Value = txtSum.Text;

            //f.ShowDialog();
            this.Hide();
        }

        private void FSuaThongTinKH_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = FKhachHang.maKhachHang;
            txtHoTen.Text = FKhachHang.hoTenKhachHang;
            txtSDT.Text = FKhachHang.soDienThoaiKhachhang;
            txtSoCCCD.Text = FKhachHang.soCanCuocCongDanKhachHang;

            //Nhận dạng giới tính
            //kiểm tra tex, nếu là nam, thì thuộc tính bật lên và ngược;
            if(FKhachHang.gioiTinhKhachHang == "Nam")
            {
                rdNam.AutoCheck = true;
            }    
            if (FKhachHang.gioiTinhKhachHang == "Nữ")
            {
                rdNu.AutoCheck = true;
            }
            txtDiaChi.Text = FKhachHang.diaChiKhachhHang;

        }
    }
}
