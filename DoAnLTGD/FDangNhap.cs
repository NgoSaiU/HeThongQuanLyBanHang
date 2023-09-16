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
    public partial class DangNhap : Form
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
        
        
        public DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        List<TaiKhoan> dsnv = new List<TaiKhoan>();
        bool co = false;

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";

                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";

                txtTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                peye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbbChucVu.Items.AddRange(new string[] { "Quản lý", "Nhân viên" });
            try
            {
                string path = Application.StartupPath + "\\dsnv.txt";
                dsnv = DanhSachTaiKhoan.Docfile(path);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {

            try
            {
                if (co == false)
                {
                    throw new Exception("Vui long chon chuc vu!!!");
                }
                if (KiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text, cbbChucVu.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    {
                        if (KiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text, cbbChucVu.Text))
                        {
                            
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sai thông tin đăng nhập");
                            txtTenDangNhap.Focus();
                        }
                        return true;
                    }

            }
            return base.ProcessDialogKey(keyData);
        }

        bool KiemTraDangNhap(string tenTaiKhoan, string matKhau, string chucvu)
        {
            foreach (TaiKhoan nv in dsnv)
            {
                if (tenTaiKhoan == nv.UserName && matKhau == nv.PassWork && chucvu == nv.ChucVu)
                {
                    FTrangChu f = new FTrangChu(nv.ChucVu, nv.TenNV);
                    FTrangChu.cbnv = nv.ChucVu;
                    FTrangChu.namenv = nv.TenNV;
                    return true;
                }
            }
            return false;
        }


        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.SelectedItem != null)
            {
                co = true;
            }
            else
                co = false;
        }
    }


}