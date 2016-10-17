using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            int ver=1;
            Console.WriteLine("Введите число:");
            try
            {
                digit = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Нужно было ввести число!");
                Console.ReadKey();
                return;
            }
            digit = Math.Abs(digit);
            while (digit > 9)
            {
                digit = digit / 10;
                ver++;
            }
            Console.WriteLine("Разрядность числа: "+ ver);
            Console.ReadKey();
        }
    }
}
