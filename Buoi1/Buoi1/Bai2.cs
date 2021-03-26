using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Bai2
    {
        //Viết chương trình cho phép nhập 3 hệ số a, b, c từ bàn phím. Giải phương trình ax2 + bx + c = 0.
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen c= ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("Vo so nghiem");
                    else Console.WriteLine("Vo nghiem");
                }
                else Console.WriteLine("x= " + (float)-c / b);
            }
            else
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0) Console.WriteLine("Vo nghiem");
                else if (delta == 0) Console.WriteLine("x= " + (float)-b / (2 * a));
                else
                {
                    Console.WriteLine("x1= " + (float)(-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x1= " + (float)(-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
    }
}
