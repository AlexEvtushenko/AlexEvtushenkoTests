using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int ranDigit;
            int sum=0;
            for (int i=1; i <=5; i++)
            {
                ranDigit = rand.Next();
                sum += ranDigit;
                Console.WriteLine("Число"+i+":"+sum);
            }
            Console.WriteLine("Среднее арифметическое:" + sum / 5);
            Console.ReadKey();

        }
    }
}
