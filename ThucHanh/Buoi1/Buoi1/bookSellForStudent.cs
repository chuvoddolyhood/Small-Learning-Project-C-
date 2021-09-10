using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class bookSellForStudent : bookSell
    {
        /*
         Hằng năm, đến mùa khai trường; cửa hàng sách bán giảm giá 10% cho đối tượng là sinh viên học sinh.
        Thiết kế lớp sách bán cho sinh viên, lớp này kế thừa từ lớp sách bán ở câu 2; bên
        cạnh đó lớp này còn có 1 thành viên kiểu Boolean cho biết đó có phải là sinh viên hay
        không? Dĩ nhiên, phương thức tính tiền của lớp dẫn xuất này phải được thiết kế lại: nếu
        là sinh viên thì giá bán giảm 10%, ngược lại sách được bán với giá gốc; để ý rằng phương
        thức tính tiền của lớp con (sách bán cho sinh viên) sẽ ghi đè (trùng tên) phương thức
        tính tiền của lớp cơ sở (sách bán).
        Viết chương trình cho phép tạo một đối tượng sách bán cho sinh viên và nhập từ
        bàn phím tên sách bán, số lượng, giá bán, người mua có là sinh viên hay không? Tính tiền phải trả
         */
        private Boolean isStudent;

        public bookSellForStudent(string name, int amount, int price) : base(name, amount, price) //Goi ham xay dung bookSell
        {
            isStudent = true;
        }

        public bookSellForStudent() : base() //Goi ham xay dung bookSell
        {
            isStudent = true;
        }

        public override int calculateOfBook() //Su dung overload : override/virtual
        {
            int price;
            int o = base.calculateOfBook();
            if (isStudent == true) 
                price = (int)(o - (o * 0.1));
            else price =o;
            return price;  
        }
        public override void input() 
        {
            base.input();
            Console.WriteLine("Ban co phai sinh vien ko? true/false");
            isStudent = Convert.ToBoolean(Console.ReadLine());

        }
        public override void output()
        {
            base.output();
            if(isStudent==true) Console.WriteLine("Khach hang la sinh vien. Giam gia!!!");
            else Console.WriteLine("Khong giam gia!!!");
        }

        static void Main(string[] args)
        {
            bookSellForStudent book = new bookSellForStudent();
            book.input();
            book.output();
        }



    }


}
