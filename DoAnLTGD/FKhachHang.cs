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
    public partial class FKhachHang : Form
    {
       

        public FKhachHang()
        {
            InitializeComponent();
        }
       
        public static string maKhachHang;
        public static string hoTenKhachHang;
        public static string soDienThoaiKhachhang;
        public static string soCanCuocCongDanKhachHang;
        public static string gioiTinhKhachHang;
        public static string diaChiKhachhHang;

        int index;
        string maKH, hoTen, sDT, soCCCD, gioiTinh, diaChi;

        public FKhachHang(string makh, string hoten, string sodt, string socccd, string gioitinh, string diachi)
        {
            this.maKH = makh;
            this.hoTen = hoten;
            this.sDT = sodt;
            this.soCCCD = socccd;
            this.gioiTinh = gioitinh;
            this.diaChi = diachi;
        }

        List<KhachHang> dskh = new List<KhachHang>();


        DataTable tbOrder;

        private void txtTimKiemKH_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "Tìm kiếm khách hàng")
            {
                txtTimKiemKH.Text = "";

                txtTimKiemKH.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemKH_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "")
            {
                txtTimKiemKH.Text = "Tìm kiếm khách hàng";

                txtTimKiemKH.ForeColor = Color.Gray;
            }
        }
  
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKH.DataSource = tbOrder;
        }


        
        private void FKhachHang_Load(object sender, EventArgs e)
        {
            tbOrder = new DataTable();
            tbOrder.Columns.Add("Mã KH");
            tbOrder.Columns.Add("Tên Khách Hàng");
            tbOrder.Columns.Add("Số ĐT");
            tbOrder.Columns.Add("Số CCCD");
            tbOrder.Columns.Add("Giới Tính");
            tbOrder.Columns.Add("Địa Chỉ");

            dgvKH.DataSource = tbOrder;

            dgvKH.Columns[0].Width = (int)(dgvKH.Width * 0.1);
            dgvKH.Columns[1].Width = (int)(dgvKH.Width * 0.3);
            dgvKH.Columns[2].Width = (int)(dgvKH.Width * 0.1);
            dgvKH.Columns[3].Width = (int)(dgvKH.Width * 0.2);
            dgvKH.Columns[4].Width = (int)(dgvKH.Width * 0.1);
            dgvKH.Columns[5].Width = (int)(dgvKH.Width * 0.2);

            try
            {
                string path = Application.StartupPath + "\\dskh.txt";
                dskh = DSKH.DocFile(path);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            DataRow row;
            foreach (KhachHang kh in dskh)
            {
                row = tbOrder.NewRow();
                row[0] = kh.Ma;
                row[1] = kh.Ten;
                row[2] = kh.soDT;
                row[3] = kh.soCCCD;
                row[4] = kh.gioiTinh;
                row[5] = kh.diaChi;
                tbOrder.Rows.Add(row);
            }
        }


        private void btThemKH_Click(object sender, EventArgs e)
        {
            FThemKhachHang fThemKhachHang = new FThemKhachHang();
            //Thêm vào dataGridView
            fThemKhachHang.ShowDialog();
            tbOrder.Rows.Add(maKhachHang, hoTenKhachHang, soDienThoaiKhachhang, soCanCuocCongDanKhachHang,
                gioiTinhKhachHang, diaChiKhachhHang);


            //DataRow row;
            //KhachHang khach = new KhachHang();
            //khach.Ma = maKhachHang;
            //khach.Ten = hoTenKhachHang;
            //khach.soDT = soDienThoaiKhachhang;
            //khach.soCCCD = soCanCuocCongDanKhachHang;
            //khach.gioiTinh = gioiTinhKhachHang;
            //khach.diaChi = diaChiKhachhHang;

            //dskh.Add(khach);////////
            //tbOrder.Clear()
            //foreach (KhachHang kh in dskh)
            //{
            //    row = tbOrder.NewRow();
            //    row[0] = kh.Ma;
            //    row[1] = kh.Ten;
            //    row[2] = kh.soDT;
            //    row[3] = kh.soCCCD;
            //    row[4] = kh.gioiTinh;
            //    row[5] = kh.diaChi;
            //    tbOrder.Rows.Add(row);
            //}


            string path = Application.StartupPath + "\\dskh.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvKH.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvKH.Rows[i].Cells[0].Value.ToString() + ";" 
                    + dgvKH.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[4].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[5].Value.ToString());
            }
            streamWriter.Close();
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            index = dgvKH.CurrentCell.RowIndex;
            dgvKH.Rows.RemoveAt(index);

            string path = Application.StartupPath + "\\dskh.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvKH.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvKH.Rows[i].Cells[0].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[4].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[5].Value.ToString()); 
            }
            streamWriter.Close();
            dskh = DSKH.DocFile(path);
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            FSuaThongTinKH.viTriSua = e.RowIndex;
            DataGridViewRow row = dgvKH.Rows[index];

            //khi ấn vào table, dữ liệu sẽ truyền vào biến
            //việc cần làm là tạo biến để hứng dữ liệu  sau đó tryền biến này cho form sửa. 
            //sau khi sửa xong thì truyền lại vào vô đã định. (index)

            maKhachHang = row.Cells[0].Value.ToString();
            hoTenKhachHang = row.Cells[1].Value.ToString();
            soDienThoaiKhachhang = row.Cells[2].Value.ToString();
            soCanCuocCongDanKhachHang = row.Cells[3].Value.ToString();
            gioiTinhKhachHang = row.Cells[4].Value.ToString();
            diaChiKhachhHang = row.Cells[5].Value.ToString();


        }
        private void btSuaKH_Click(object sender, EventArgs e)
        {
            FSuaThongTinKH fSuaKhachHang = new FSuaThongTinKH();

            //Thêm vào dataGridView
            //tbOrder.Rows.Add(maKhachHang, hoTenKhachHang, soDienThoaiKhachhang, soCanCuocCongDanKhachHang,
            //    gioiTinhKhachHang, diaChiKhachhHang);

            fSuaKhachHang.ShowDialog();

            //Sủa vào dataGridView

            DataGridViewRow newdata = dgvKH.Rows[index];

            newdata.Cells[0].Value = maKhachHang;
            newdata.Cells[1].Value = hoTenKhachHang;
            newdata.Cells[2].Value = soDienThoaiKhachhang;
            newdata.Cells[3].Value = soCanCuocCongDanKhachHang;
            newdata.Cells[4].Value = gioiTinhKhachHang;
            newdata.Cells[5].Value = diaChiKhachhHang;


            string path = Application.StartupPath + "\\dskh.txt";
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            streamWriter = new StreamWriter(path);
            for (int i = 0; i < dgvKH.Rows.Count - 1; i++)
            {
                streamWriter.WriteLine(dgvKH.Rows[i].Cells[0].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[1].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[2].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[3].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[4].Value.ToString() + ";"
                    + dgvKH.Rows[i].Cells[5].Value.ToString());
            }
            streamWriter.Close();
        }


    }

}