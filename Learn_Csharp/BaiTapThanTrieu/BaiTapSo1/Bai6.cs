using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai6
    {
        //Hãy nhập 4 số nguyên bất kì sau đó lưu vào 4 biến a, b, c, d. Tìm giá trị lớn
        //thứ hai trong số chúng, in kết quả ra màn hình.Trường hợp tất cả cùng giá
        //trị thì không có số lớn thứ hai.

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen c= ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen d= ");
            int d = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(a, Math.Max(b, Math.Max(c, d)));
            Console.WriteLine("Gia tri lon thu 2: " + max);
            if (a == b && a == c && c == d) Console.WriteLine("Gia tri bang nhau");
        }
    }
}
