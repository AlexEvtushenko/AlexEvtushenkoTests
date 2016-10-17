using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Неверный формат!");
                Console.ReadKey();
                return;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(a + " это не простое число");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine(a + " простое число");
            Console.ReadKey();
            
        }
    }
}
