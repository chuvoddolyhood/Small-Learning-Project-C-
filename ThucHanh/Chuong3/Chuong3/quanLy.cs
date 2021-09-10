using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    class quanLy:nhanVien
    {
        public static int donGia = 180000;
        public string MaSoNV
        {
            get => MaSoNV;
            //set => MaSoNV;
        }
        public string HoTenNV
        {
            get => HoTenNV;
        }
        public int tienCong => ngayCong * donGia;
        public static void Main(string[] args)
        {
            quanLy m1 = new quanLy();
            quanLy m2 = new quanLy();
            quanLy m3 = new quanLy();

            m1.ngayCong = 20;
            m2.ngayCong = 25;
            m3.ngayCong = 30;

            Console.WriteLine("Tien cong cong nhan 1: " + m1.tienCong);
            Console.WriteLine("Tien cong cong nhan 2: " + m2.tienCong);
            Console.WriteLine("Tien cong cong nhan 3: " + m3.tienCong);
        }
    }
}
