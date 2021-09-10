using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo2
{
    class Bai5
    {
        //Nhập số nguyên dương n và tính tổng: S = 1 + 1.2 + 1.2.3 + ... + 1.2.3...n.
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen= ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            for(int i = 1; i <= number; i++)
            {
                int j = 1;
                int tich = 1; //tich cac so
                do
                {
                    tich = tich * j;
                    j++;
                    
                } while (j <= i);
                sum = sum + tich;
            }
            Console.WriteLine($"Tong = {sum}");
        }
    }
}
