using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            int natDigit =1;
            double square = 1;
            Console.WriteLine("Введите целое число:");
            try
            {
                digit = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Нужно было ввести целое число!");
                Console.ReadKey();
                return;
            }
            while (digit > square)
            {
                
                Console.WriteLine(square);
                natDigit++;
                square = Math.Pow(natDigit, 2);
            }
            
            Console.ReadKey();
        }
    }
}
