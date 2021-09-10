using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai7
    {
        //Viết chương trình nhập vào hai cạnh của hình chữ nhật và tính chu vi và
        //diện tích của hình chữ nhật đó.Hiển thị kết quả lên màn hình
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap canh a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            int chuvi = 2 * (a + b);
            int s = a * b;
            Console.WriteLine("Chu vi hcn= "+chuvi);
            Console.WriteLine("Dien tich hcn= " + s);
        }
    }
}
