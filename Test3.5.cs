using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            int sum=0;
            for (int i =1; i <= 5; i++)
            {
                Console.WriteLine("Введите число:");
                try
                {
                    digit = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Необходимо было ввести число!");
                    Console.ReadKey();
                    return;
                }
                sum += digit;
            }
            Console.WriteLine("Среднее арифметическое:" + sum/5);
            Console.ReadKey();
        }
    }
}
