using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите 0 или 1");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректные данные");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(a == 0 ? "Плохо" : (a == 1 ? "Хорошо" : "Неверное число"));
            Console.ReadKey();
        }
    }
}
