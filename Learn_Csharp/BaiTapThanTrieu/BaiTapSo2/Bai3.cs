using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo2
{
    class Bai3
    {
        // Nhập số tự nhiên n rồi tính tổng(lưu ý phép chia các số nguyên): S= 1+ 1/2 + 1/3 + 1/4 + ... + 1/n

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen= ");
            int number = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + (float)1/i;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
