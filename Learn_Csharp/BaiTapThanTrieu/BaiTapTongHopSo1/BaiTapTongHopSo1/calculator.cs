using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTongHopSo1
{
    class calculator
    {
        //Tạo menu tùy chọn cho phép người dùng thực hiện các phép tính toán cộng trừ
        //nhân chia, lấy dư, lũy thừa a^b từ hai số a, b nhập từ bàn phím.Khi thực hiện phép
        //chia, lấy dư cần kiểm tra mẫu số phải đảm bảo khác 0 thì mới cho thực hiện, ngược
        //lại yêu cầu người dùng nhập lại giá trị tử, mẫu hoặc thoát chức năng hoặc thoát
        //khỏi chương trình.
        static void Main(string[] args)
        {
            string choose; //chon cong viec tiep theo
            do
            {
                Console.WriteLine("==========DANH SACH CAC CHUC NANG==========");
                Console.WriteLine("1. Cong hai so");
                Console.WriteLine("2. Tru hai so");
                Console.WriteLine("3. Nhan hai so");
                Console.WriteLine("4. Chia hai so");
                Console.WriteLine("5. Chia lay du hai so");
                Console.WriteLine("6. Luy thua hai so");
                Console.Write("Chon chuc nang: ");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            Console.WriteLine("=====Chuc Nang So 1: Cong Hai So Nguyen");
                            Console.Write("Nhap so nguyen a= ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so nguyen b= ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Tong hai so= {a + b}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("=====Chuc Nang So 2: Tru Hai So Nguyen");
                            Console.Write("Nhap so nguyen a= ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so nguyen b= ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Hieu hai so= {a - b}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("=====Chuc Nang So 3: Nhan Hai So Nguyen");
                            Console.Write("Nhap so nguyen a= ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so nguyen b= ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Tich hai so= {a * b}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("=====Chuc Nang So 4: Chia Hai So Nguyen");
                            int tuSo;
                            int mauSo;
                            do
                            {
                                Console.Write("Nhap tu so a= ");
                                tuSo = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Nhap mau so b= ");
                                mauSo = Convert.ToInt32(Console.ReadLine());
                                if (mauSo == 0) Console.WriteLine("Nhap lai!!!");
                            } while (mauSo == 0);

                            Console.WriteLine($"Thuong hai so= " + (float)tuSo / mauSo);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("=====Chuc Nang So 5: Chia Lay Du Hai So Nguyen");
                            int tuSo;
                            int mauSo;
                            do
                            {
                                Console.Write("Nhap tu so a= ");
                                tuSo = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Nhap mau so b= ");
                                mauSo = Convert.ToInt32(Console.ReadLine());
                                if (mauSo == 0) Console.WriteLine("Nhap lai!!!");
                            } while (mauSo == 0);

                            Console.WriteLine($"Thuong hai so= " + (float)tuSo % mauSo);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("=====Chuc Nang So 6: Luy Thua Hai So Nguyen");
                            Console.Write("Nhap so nguyen a= ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nhap so nguyen b= ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Luy thua hai so= {Math.Pow(a,b)}");
                            break;
                        }
                }

                Console.WriteLine("Co muon thuc hien tiep tuc ko? Y/N");
                choose = Console.ReadLine();
                if (choose.Equals("n") || choose.Equals("N")) Console.WriteLine("Cam on ban da su dung chuong trinh!!!");
            } while (choose.Equals("y") || choose.Equals("Y"));
        }
    }
}