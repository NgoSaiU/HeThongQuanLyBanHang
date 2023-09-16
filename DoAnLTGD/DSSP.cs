using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoAnLTGD
{
    public class DSSP
    {
        public static List<SanPham> DocFile(string path)
        {
            List<SanPham> dssp = new List<SanPham>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 5)
                    {
                        SanPham sanpham = new SanPham();// tạo 1 not
                        sanpham.MaSP = arr[0];
                        sanpham.TenSP = arr[1];
                        sanpham.SoLuong = arr[2];
                        sanpham.GiaBan = arr[3];
                        sanpham.GiamGia = arr[4];
                        dssp.Add(sanpham);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dssp;
        }
    }

}
