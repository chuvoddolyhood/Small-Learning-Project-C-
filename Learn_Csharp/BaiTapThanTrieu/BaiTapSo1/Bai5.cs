using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai5
    {
        //Hãy nhập 4 số nguyên a, b, c, d. Tìm giá trị nhỏ nhất trong đó và in ra màn
        //hình.Trong trường hợp 4 số bằng nhau thì in ra: không có số nhỏ nhất.

        //TIM GIA TRI NHO NHAT
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen c= ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen d= ");
            int d = Convert.ToInt32(Console.ReadLine());
            int min = Math.Min(a,Math.Min(b,Math.Min(c,d)));
            Console.WriteLine("Gia tri nho nhat: " + min);
            if(a==b &&a==c&&c==d) Console.WriteLine("Gia tri bang nhau");
        }
    }
}
