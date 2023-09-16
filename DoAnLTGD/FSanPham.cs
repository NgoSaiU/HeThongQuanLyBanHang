using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAnLTGD
{
    public partial class FSanPham : Form
    {
        public FSanPham()
        {
            InitializeComponent();
        }

        public static string maSanPham;
        public static string tenSanPham;
        public static string soLuongSanPham;
        public static string giaBanSanPham;
        public static string giamGiamGiaSanPham;
       

        int index;
        string maSP, tenSp, soLuongSP, giaBanSP, giamGiaSp;

        public FSanPham(string masp, string tensp, string soluong, string giabansp, string giamgiasp)
        {
            this.maSP = masp;
            this.tenSp = tensp;
            this.soLuongSP = soluong;
            this.giaBanSP = giabansp;
            this.giamGiaSp = giamgiasp;
            
        }

        List<SanPham> dssp = new List<SanPham>();
        DataTable tbSanpham;

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm sản phẩm")
            {
                txtTimKiem.Text = "";

                txtTimKiem.ForeColor = Color.Black;
            }
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm sản phẩm";

                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            dgvSanPham.DataSource = tbSanpham;
        }
        private void FKhachHang_Load(object sender, EventArgs e)
        {
            tbSanpham = new DataTable();
            tbSanpham.Columns.Add("Mã Sản Phẩm");
            tbSanpham.Columns.Add("Tên Sản Phẩm");
            tbSanpham.Columns.Add("Số Lượng");
            tbSanpham.Columns.Add("Giá Bán");
            tbSanpham.Columns.Add("Giảm Giá");

            dgvSanPham.DataSource = tbSanpham;

            dgvSanPham.Columns[0].Width = (int)(dgvSanPham.Width * 0.1);
            dgvSanPham.Columns[1].Width = (int)(dgvSanPham.Width * 0.2);
            dgvSanPham.Columns[2].Width = (int)(dgvSanPham.Width * 0.2);
            dgvSanPham.Columns[3].Width = (int)(dgvSanPham.Width * 0.2);
            dgvSanPham.Columns[4].Width = (int)(dgvSanPham.Width * 0.2);

            try
            {
                string path = Application.StartupPath + "\\dssp.txt";
                dssp = DSSP.DocFile(path);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            DataRow row;
            foreach (SanPham sp in dssp)
            {
                row = tbSanpham.NewRow();
                row[0] = sp.MaSP;
                row[1] = sp.TenSP;
                row[2] = sp.SoLuong;
                row[3] = sp.GiaBan;
                tbSanpham.Rows.Add(row);
            }
            dgvSanPham.DataSource = tbSanpham;

        }



        private void btThemSanPham_Click(object sender, EventArgs e)
        {
            FThemKhachHang fThemKhachHang = new FThemKhachHang();
            //Thêm vào dataGridView
            fThemKhachHang.ShowDialog();
            tbSanpham.Rows.Add(maSanPham, tenSanPham, soLuongSanPham, giaBanSanPham,
                giamGiamGiaSanPham);


            string path = Application.StartupPath + "\\dssp.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvSanPham.Rows[i].Cells[0].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[4].Value.ToString());
            }
            streamWriter.Close();
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            FSuaThongTinSP.viTriSua = e.RowIndex;
            DataGridViewRow row = dgvSanPham.Rows[index];

            //khi ấn vào table, dữ liệu sẽ truyền vào biến
            //việc cần làm là tạo biến để hứng dữ liệu  sau đó tryền biến này cho form sửa. 
            //sau khi sửa xong thì truyền lại vào vô đã định. (index)

            maSanPham = row.Cells[0].Value.ToString();
            tenSanPham= row.Cells[1].Value.ToString();
            soLuongSanPham= row.Cells[2].Value.ToString();
            giaBanSanPham= row.Cells[3].Value.ToString();
            giamGiamGiaSanPham= row.Cells[4].Value.ToString(); /////
           
        }

        private void btSuaSanPham_Click(object sender, EventArgs e)
        {
            FSuaThongTinSP fSuaSanPham= new FSuaThongTinSP();

            //Thêm vào dataGridView
            //tbOrder.Rows.Add(maKhachHang, hoTenKhachHang, soDienThoaiKhachhang, soCanCuocCongDanKhachHang,
            //    gioiTinhKhachHang, diaChiKhachhHang);

            fSuaSanPham.ShowDialog();

            //Sủa vào dataGridView

            DataGridViewRow newdata = dgvSanPham.Rows[index];

            newdata.Cells[0].Value = maSanPham;
            newdata.Cells[1].Value = tenSanPham;
            newdata.Cells[2].Value = soLuongSanPham;
            newdata.Cells[3].Value = giaBanSanPham;
            newdata.Cells[4].Value = giamGiamGiaSanPham;


            string path = Application.StartupPath + "\\dssp.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvSanPham.Rows[i].Cells[0].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[4].Value.ToString());
            }
            streamWriter.Close();
        }

        private void btXoaSanPham_Click(object sender, EventArgs e)
        {
            index = dgvSanPham.CurrentCell.RowIndex;
            dgvSanPham.Rows.RemoveAt(index);

            string path = Application.StartupPath + "\\dssp.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvSanPham.Rows[i].Cells[0].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvSanPham.Rows[i].Cells[4].Value.ToString());
            }
            streamWriter.Close();
            dssp = DSSP.DocFile(path);
        }
    }
}
