using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoAnLTGD
{
    public class DanhSachTaiKhoan
    {

        public static List<TaiKhoan> Docfile(string path)
        {
            List<TaiKhoan> dsnv = new List<TaiKhoan>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 5)
                    {
                        TaiKhoan nv = new TaiKhoan();
                        nv.MaNV = arr[0];
                        nv.TenNV = arr[1];
                        nv.ChucVu = arr[2];
                        nv.UserName = arr[3];
                        nv.PassWork = arr[4];
                        dsnv.Add(nv);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsnv;
        }
    }
}
