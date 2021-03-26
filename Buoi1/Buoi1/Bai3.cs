using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Bai3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem so: ");
            float mark = Convert.ToSingle(Console.ReadLine());
            if (mark >= 8.5) Console.WriteLine("A");
            else if (mark >= 7.0 && mark < 8.5) Console.WriteLine("B");
            else if (mark >= 5.5 && mark < 7.0) Console.WriteLine("C");
            else if (mark >= 4.0 && mark < 5.5) Console.WriteLine("D");
            else Console.WriteLine("F");
        }
    }
}
