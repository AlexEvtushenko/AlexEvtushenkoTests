using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число:");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Мы просили ввести число!");
                Console.ReadKey();
                return;
            }
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(n * i);
            }
            Console.ReadKey();
        }
    }
}
