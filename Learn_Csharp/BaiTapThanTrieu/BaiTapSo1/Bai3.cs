using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai3
    {
        //Nhập vào hai số nguyên a, b. In ra màn hình kết quả các phép tính +, -, *, /,
        //%. Lưu ý khi xử lý các phép chia sẽ cần ép kiểu, kiểm tra mẫu khác 0. Xuất kết
        //quả ra màn hình trên từng dòng.

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            if (b == 0) Console.WriteLine("Khong the thuc hien phep chia vi mau so = 0");
            else Console.WriteLine($"{a}/{b}={(float)a / b}");
        }
    }
}
