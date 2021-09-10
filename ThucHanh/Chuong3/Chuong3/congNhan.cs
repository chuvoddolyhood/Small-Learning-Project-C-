using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    class congNhan : nhanVien
    {
        public static int donGia = 150000;

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
            congNhan e1 = new congNhan();
            congNhan e2 = new congNhan();
            congNhan e3 = new congNhan();

            e1.ngayCong = 20;
            e2.ngayCong = 25;
            e3.ngayCong = 30;

            Console.WriteLine("Tien cong cong nhan 1: "+e1.tienCong);
            Console.WriteLine("Tien cong cong nhan 2: " + e2.tienCong);
            Console.WriteLine("Tien cong cong nhan 3: " + e3.tienCong);
        }
    }
}
