using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo2
{
    class Bai2
    {
        // Nhập số tự nhiên n rồi tính tổng: S = 1 + 2 + ... + n.
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen= ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Sum = {sum}");
                
        }
    }
}
