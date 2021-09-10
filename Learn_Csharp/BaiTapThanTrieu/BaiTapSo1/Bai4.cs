using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai4
    {
        //Nhập vào hai số nguyên a, b. So sánh xem số nào lớn hơn, số nào nhỏ hơn
        //hay hai số bằng nhau.In kết quả ra màn hình.
        static void Main(string[] args)
        {
            //string test = default;
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            //test= (a > b) ? "a lon hon b" : "a nho hon b";
            //Console.WriteLine(test);
            //if (a == b) Console.WriteLine("a bang b");

            if (a > b) Console.WriteLine("a>b");
            else if (a<b) Console.WriteLine("a<b");
            else Console.WriteLine("a=b");
        }
    }
}
