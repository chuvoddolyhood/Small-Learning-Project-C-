using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai8
    {
        //Viết chương trình nhập bán kính của hình tròn và tính chu vi, diện tích hình tròn đó.
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ban kinh hinh tron r= ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chu vi hinh tron= " + r * 2 * Math.PI);
            Console.WriteLine("Dien tich hinh tron= " + Math.Pow(r,2) * Math.PI);
        }
    }
}
