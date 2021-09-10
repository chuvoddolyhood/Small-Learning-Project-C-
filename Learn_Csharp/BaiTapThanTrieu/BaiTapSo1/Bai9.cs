using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai9
    {
        //: Giải và biện luận phương trình bậc nhất a𝑥 + b = 0
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Vo so nghiem");
                if(b!=0) Console.WriteLine("Vo nghiem");
            }
            else
            {
                if(b==0) Console.WriteLine("x = 0");
                else Console.WriteLine($"x= {(float)-b/a}");
            }
        }
    }
}
