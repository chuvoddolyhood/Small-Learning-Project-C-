using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3
{
    //Bai1 trang 75 76
    class nhanVien
    {
        private string maSoNV; //ma so nhan vien
        private string hoTenNV; // ho ten nhan vien
        protected int ngayCong; //so ngay cong trong thang
        private Boolean triSoNgayCong; //tri so ngay cong --> tien thuong hay phat

        public string MasoNV
        {
            get => maSoNV;
            set => maSoNV = "xxx";
        }
        public string HotenNV
        {
            get => hoTenNV;
            set => hoTenNV = "xxx xxx xxxx";
        }
        public int NgayCong
        {
            get => ngayCong;
            set => ngayCong=0;
        }
        public Boolean TriSoNgayCong
        {
            get => triSoNgayCong;
            set
            {
                if (ngayCong < 20) triSoNgayCong = false;
                else if (ngayCong > 26) triSoNgayCong = true;
            }
        }

    }
}
