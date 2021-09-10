using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class output
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("a + b= " + sum);
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"Max(10,25)");
        }
    }
}
