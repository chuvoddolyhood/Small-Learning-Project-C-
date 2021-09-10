using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //import the library

namespace Buoi1
{
    class bookSell
    {
        /*Một cửa hàng sách cần quản lý thông tin về các loại sách sẽ bán của mình. Một số thông
         *  tin cần quản lý là: tên sách, số lượng, giá bán. Hãy thiết kế lớp sách bán cho phép có các
         *  dữ liệu thành viên (có chỉ thị truy cập là public) là các thông tin trên. Bên cạnh đó, lớp
         *  này nên phương thức tính tiền dựa vào số lượng sách và giá bán mỗi quyển.
         *  Thí dụ: Quyển Mật mã của Da Vinci bán cho 1 khách hàng là 20 quyển, giá bán 1
         *  quyển là 99000đ. Vậy số tiền phải trả là 1.980.000 đ.
         *  Viết chương trình cho phép tạo một đối tượng sách bán và nhập từ bàn phím tên
         *  sách bán, số lượng và giá bán mỗi quyển. Tính tiền phải trả.
         */
        public string nameOfBook; //ten sach
        public int amount; //so luong
        public int price; //gia

        public bookSell() : this("",0,0) { }

        public bookSell(string name, int amount, int price)
        {
            this.nameOfBook = name;
            this.amount = amount;
            this.price = price;
        }

        public virtual int calculateOfBook() => amount * price;

        public virtual void input()
        {
            WriteLine("Nhap ten sach: ");
            nameOfBook = ReadLine();
            WriteLine("Nhap so luong sach: ");
            amount = Convert.ToInt32(ReadLine());
            WriteLine("Nhap gia sach: ");
            price = Convert.ToInt32(ReadLine());
        }

        public virtual void output()
        {
            WriteLine("Quyen " + nameOfBook + " ban cho 1 khach hang la " + amount + " quyen, " + "gia ban 1 quyen la "
                + price + "đ. Vay so tien phai tra la " + calculateOfBook() + " đ.");
        }

        //static void Main(string[] args)
        //{
        //    bookSell book = new bookSell();
        //    book.input();
        //    book.output();
        //}
    }
}
