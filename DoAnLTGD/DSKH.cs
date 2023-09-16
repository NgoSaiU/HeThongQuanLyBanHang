using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoAnLTGD
{
    public class DSKH
    {
        //public static bool FIleLuu(List<KhachHang> dskh, string path)
        //{
        //    try
        //    {
        //        StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
        //        foreach (KhachHang kh in dskh)
        //        {
        //            string line = kh.Ma + ";" + kh.Ten;
        //        }
        //        sw.Close();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<KhachHang> DocFile (string path)
        {
            List<KhachHang> dskh = new List<KhachHang>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while(line != null)
                {
                    string[] arr = line.Split(';');
                    if(arr.Length == 6)
                    {
                        KhachHang khach = new KhachHang();// tạo 1 not
                        khach.Ma = arr[0];
                        khach.Ten = arr[1];
                        khach.soDT = arr[2];
                        khach.soCCCD = arr[3];
                        khach.gioiTinh = arr[4];
                        khach.diaChi = arr[5];

                        dskh.Add(khach);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dskh;
        }
    }
}
