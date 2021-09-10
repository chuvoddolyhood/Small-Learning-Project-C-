using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai10
    {
        //Giải và biện luận phương trình bậc 2 a𝑥2 + b𝑥1 + c = 0
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen c= ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("Vo so nghiem");
                    if (c != 0) Console.WriteLine("Vo nghiem");
                }
                else
                {
                    if (c == 0) Console.WriteLine("x = 0");
                    else Console.WriteLine($"x= {(float)-c / b}");
                }
            }
            else
            {
                float delta = Convert.ToSingle((Math.Pow(b, 2)) - (4 * a * c));
                Console.WriteLine("delta = "+delta);
                if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0) Console.WriteLine($"x={-b / (2 * a)}");
                else
                {
                    Console.WriteLine($"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)}");
                    Console.WriteLine($"x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                }
            }
        }
    }
}
