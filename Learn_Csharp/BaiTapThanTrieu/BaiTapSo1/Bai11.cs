using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai11
    {
        //Nhập vào ba số thực a, b, c đều dương. Kiểm tra xem đó có phải là ba cạnh
        //của một tam giác hay không.Nếu có hãy chỉ ra đó là loại tam giác nào?

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 canh de kiem tra tam giac");
            Console.Write("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen c= ");
            int c = Convert.ToInt32(Console.ReadLine());


            if ((a + b > c) || (a + c > b) || (c + b > a))
            {
                if (a == b && b == c)
                    Console.WriteLine("Day la tam giac deu");
                else if ((a == b) || (a == c) || (b == c))
                    Console.WriteLine("Day la tam giac can");
                else if (c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) || a == Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2))
                    || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)))
                    Console.WriteLine("Day la tam giac vuong");
                else if ((c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) && a == b)
                    || (a == Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2)) && c == b)
                    || (b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) && a == c))
                    Console.WriteLine("Day la tam giac vuong can");
                else Console.WriteLine("Day la tam giac thuong");
                
            }
            else Console.WriteLine("Day khong phai la tam giac");
        }
    }
}
