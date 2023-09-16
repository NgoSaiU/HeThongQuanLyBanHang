using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTGD
{
    public partial class FThanhToan : Form
    {
        #region BienToanCuc
        #endregion

        public FThanhToan()
        {
            InitializeComponent();
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Khách hàng đã thành toán???", "Xuất hóa đơn", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!!!");
                lsvThanhToan.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        List<SanPham> dssp = new List<SanPham>();
        
        private void FThanhToan_Load(object sender, EventArgs e)
        {
            lsvThanhToan.Columns[0].Width = (int)(lsvThanhToan.Width * 0.5);
            lsvThanhToan.Columns[1].Width = (int)(lsvThanhToan.Width * 0.1);
            lsvThanhToan.Columns[2].Width = (int)(lsvThanhToan.Width * 0.1);
            lsvThanhToan.Columns[3].Width = (int)(lsvThanhToan.Width * 0.1);
            lsvThanhToan.Columns[4].Width = (int)(lsvThanhToan.Width * 0.2);


            lsvThanhToan.View = View.Details;
            lsvThanhToan.GridLines = true;
            lsvThanhToan.FullRowSelect = true;

            
            try
            {
                string path = Application.StartupPath + "\\dssp.txt";
                dssp = DSSP.DocFile(path);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //Đưa dữ liệu sản phẩm vào combobox sản phẩm
            foreach (SanPham sp in dssp)
            {
                ccbTenSanPham.Items.Add(sp.TenSP);
                
            }
          
        }
        private void btThemSPThanhToan_Click(object sender, EventArgs e)
        {

            try
            {
                foreach(SanPham sp in dssp)
                {
                    if(ccbTenSanPham.Text == sp.TenSP)
                    {
                        if(Convert.ToInt32(numSoLuong.Value) > Convert.ToInt32(sp.SoLuong))
                        {
                            throw new Exception("Quá số lượng trong kho!!!");
                        }
                    }
                }
                double thanhTien, donGia, giamGia;
                int soLuong = 0;
                string kq = "";
                soLuong = Convert.ToInt32(numSoLuong.Value);
                donGia = double.Parse(lbGiaBan.Text);
                ListViewItem item = lsvThanhToan.Items.Add((ccbTenSanPham.Text).ToString()); // Tên sản phẩm
                item.SubItems.Add(numSoLuong.Text); // số lượng
                item.SubItems.Add(lbGiaBan.Text); // đơn giá

                item.SubItems.Add(lbPhamTramGiamGia.Text);// phần trăm giảm giá

                giamGia = (double.Parse(lbPhamTramGiamGia.Text) * donGia * soLuong) / 100;
                thanhTien = soLuong * donGia - giamGia;
                kq = thanhTien.ToString();

                item.SubItems.Add(kq); //Thành tiền

                //item.SubItems.Add(String.Format("{0:#,##0.00}", kq));

                ccbTenSanPham.Text = "";
                lbGiaBan.Text = "";
                numSoLuong.Value = 1;
                lbPhamTramGiamGia.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaSPThanhToan_Click(object sender, EventArgs e)
        {
            if (lsvThanhToan.SelectedItems.Count > 0)
            {
              
                lsvThanhToan.SelectedItems[0].SubItems[0].Text = ccbTenSanPham.Text;
                lsvThanhToan.SelectedItems[0].SubItems[1].Text = numSoLuong.Text;
                lsvThanhToan.SelectedItems[0].SubItems[2].Text = lbGiaBan.Text;
                lsvThanhToan.SelectedItems[0].SubItems[3].Text = lbPhamTramGiamGia.Text;


            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void btXoaSPThanhToan_Click(object sender, EventArgs e)
        {
            if (lsvThanhToan.SelectedItems.Count > 0)
            {
                lsvThanhToan.Items.Remove(lsvThanhToan.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }

        private void lsvThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvThanhToan.SelectedItems.Count > 0)
            {
                //còn cái số thứ tự
                //int stt = 1;
                //cotTenSanPham.Text = lsvThanhToan.SelectedItems[0].SubItems[0].Text;
                

                ccbTenSanPham.Text = lsvThanhToan.SelectedItems[0].SubItems[0].Text;
                numSoLuong.Text = lsvThanhToan.SelectedItems[0].SubItems[1].Text;             
                lbGiaBan.Text = lsvThanhToan.SelectedItems[0].SubItems[2].Text; //đơn giá
                lbPhamTramGiamGia.Text = lsvThanhToan.SelectedItems[0].SubItems[3].Text;

                //soLuong = double.Parse(numSoLuong.Text);  
                //donGia = double.Parse(lbGiaBan.Text);
                //giamGia = double.Parse(lbPhamTramGiamGia.Text) / 100;

                //thanhTien = soLuong * donGia * giamGia;

                //kq = thanhTien.ToString();
                //kq = lsvThanhToan.SelectedItems[0].SubItems[3].Text;



            }
        }

        private void ccbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\dssp.txt";
                dssp = DSSP.DocFile(path);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            string x = ccbTenSanPham.SelectedItem.ToString();

            foreach (SanPham sp in dssp)
            {
                if (x == sp.TenSP)
                {
                    lbGiaBan.Text = sp.GiaBan;
                    lbPhamTramGiamGia.Text = sp.GiamGia;
                }
            }
        }
    }
}
