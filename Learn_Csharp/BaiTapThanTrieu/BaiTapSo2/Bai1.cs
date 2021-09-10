using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo2
{
    class Bai1
    {
        //Nhập số tự nhiên n sau đó in ra các số chẵn, lẻ <= n.
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen= ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day cac so chan la: ");
            for(int i = 1; i <= number; i++)
            {
                if (i % 2 == 0) Console.Write(i+"  ");
            }
            Console.Write("\nDay cac so le la: ");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1) Console.Write(i+"  ");
            }




        }
    }
}
