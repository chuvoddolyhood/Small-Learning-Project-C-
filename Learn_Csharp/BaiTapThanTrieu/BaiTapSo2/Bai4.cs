using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo2
{
    class Bai4
    {
        // Nhập vào một số tự nhiên n rồi tính:
        //a) Trung bình cộng các số tự nhiên không lớn hơn n.
        //b) Trung bình cộng các số tự nhiên lẻ không lớn hơn n.
        //c) Trung bình cộng các số tự nhiên chẵn không lớn hơn n

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen= ");
            int number = Convert.ToInt32(Console.ReadLine());
            float sum1=0; //Trung bình cộng các số tự nhiên không lớn hơn n.
            float sum2=0; //Trung bình cộng các số tự nhiên lẻ không lớn hơn n.       
            float sum3=0; //Trung bình cộng các số tự nhiên chẵn không lớn hơn n
            int count_le = 0; //dem so phan tu mang gia tri le
            int count_chan = 0; //dem so phan tu mang gia tri le
            for (int i = 1; i <= number; i++)
            {
                sum1 = sum1 +  i;
                if (i % 2 != 0)
                {
                    count_le ++;
                    sum2 = sum2 + i;
                }
                if (i % 2 == 0)
                {
                    count_chan++;
                    sum3 = sum3 + i;
                }
            }
            Console.WriteLine($"Trung binh cong cac so tu nhien nho hon n la : {sum1/number}");
            Console.WriteLine($"Trung binh cong cac so tu nhien le nho hon n la : {sum2 / count_le}");
            Console.WriteLine($"Trung binh cong cac so tu nhien chan nho hon n la : {sum3 / count_chan}");
        }
    }
}
