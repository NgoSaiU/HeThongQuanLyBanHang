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
    public partial class FThemSanPham : Form
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



        public FThemSanPham()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemSPM_Click(object sender, EventArgs e)
        {
            FSanPham f = new FSanPham(txtMaSP.Text, txtTenSP.Text, txtSoLuongSP.Text, txtGiaBan.Text, txtGiamGia.Text);
            FSanPham.maSanPham = txtMaSP.Text;
            FSanPham.tenSanPham = txtTenSP.Text;
            FSanPham.soLuongSanPham = txtSoLuongSP.Text;
            FSanPham.giaBanSanPham = txtGiaBan.Text;
            FSanPham.giamGiamGiaSanPham = txtGiamGia.Text;

            //f.ShowDialog();
            this.Hide();
        }
    }
}
