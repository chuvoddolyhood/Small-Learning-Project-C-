using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.Write("Ban muon dang ky chung chi A hay B: ");
            string cer = Console.ReadLine();
            if (String.Compare(cer, "A", true) == 0) //true ko phan biet hoa thuong, false phan biet hoa thuong
            {
                Console.WriteLine("Ban co phai la sinh vien khong? Y/N");
                string isStudent = Console.ReadLine();
                if (String.Compare(isStudent, "Y", true) == 0) Console.WriteLine($"So tien ban phai tra la: {400000 - 400000 * 10 / 100}");
                else Console.WriteLine("So tien ban phai tra la: 400000");
            }
            else
            {
                Console.WriteLine("Ban hoc lop Visual Basic (VB) hay Access (AC): ");
                string subject = Console.ReadLine();
                if (String.Compare(subject, "VB", true) == 0)
                {
                    Console.WriteLine("Ban co phai la sinh vien khong? Y/N");
                    string isStudent = Console.ReadLine();
                    if (String.Compare(isStudent, "Y", true) == 0) Console.WriteLine($"So tien ban phai tra la: {350000 - 350000 * 10 / 100}");
                    else Console.WriteLine("So tien ban phai tra la: 350000");
                }
                if (String.Compare(subject, "AC", true) == 0)
                {
                    Console.WriteLine("Ban co phai la sinh vien khong? Y/N");
                    string isStudent = Console.ReadLine();
                    if (String.Compare(isStudent, "Y", true) == 0) Console.WriteLine($"So tien ban phai tra la: {450000 - 450000 * 10 / 100}");
                    else Console.WriteLine("So tien ban phai tra la: 450000");
                }
            }
        }
    }
}
