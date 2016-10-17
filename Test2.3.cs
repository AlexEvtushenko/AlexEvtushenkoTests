using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cat = "мяу";
            string dog = "гав";
            string result = "";
            Console.WriteLine("Введите мяу или гав");
            string words = Console.ReadLine();
            if (String.Equals(cat, words, StringComparison.OrdinalIgnoreCase))
            {
                result = "Покорми кота, раб!";
            } else if (String.Equals(dog, words, StringComparison.OrdinalIgnoreCase))
                {
                result = "Погуляй с собакой";
                } else {
                result = "Дыши свободно";
                
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
