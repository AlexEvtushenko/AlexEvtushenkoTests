using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            string result = " is more!";
            string error = "It isn't a digit";
            Console.WriteLine("Please, Enter digit a");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(error);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Please, Enter digit b");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(error);
                Console.ReadKey();
                return;
            }
            if (a > b)
            {
                result = a + result;
            }
            else if (b > a)
            {
                result = b + result;
            }
            else
            {
                result = "Digits are equal";
                
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
