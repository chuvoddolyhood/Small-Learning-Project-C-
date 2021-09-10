using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapSo1
{
    class Bai2
    {
//        Nhập vào một số nguyên n, hãy cho biết số đó chẵn hay lẻ, chia hết cho 3
//       không, in kết quả kiểm tra ra màn hình.Mỗi kết luận trên một dòng.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("So chan");
            else Console.WriteLine("So le");
            if (number % 3 == 0) Console.WriteLine("Chia het cho 3");
            else Console.WriteLine("Khong chia het cho 3");
        }
    }
}
