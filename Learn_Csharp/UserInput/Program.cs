using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "He thong quan ly";
            Console.WriteLine("Nhap Thong Tin Sinh Vien");
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Nhap Ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap lop");
            string lop = Console.ReadLine();
            Console.WriteLine("Nhap diem");
            float GPA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("===============================");
            Console.WriteLine("Thong Tin Sinh Vien");
            Console.WriteLine("Ho va ten: " + name);
            Console.WriteLine("Ngay thang nam sinh: " + age);
            Console.WriteLine("Ma lop: " + lop);
            Console.WriteLine("GPA: " + GPA);
        }
    }
}
