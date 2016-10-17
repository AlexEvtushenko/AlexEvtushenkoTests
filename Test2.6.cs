using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double run;
            double wait;
            double sum;
            Console.WriteLine("Сколько километров нужно проехать?");
            try
            {
                run = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Неверный формат!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Сколько минут придется ждать?");
            try
            {
                wait = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат!");
                Console.ReadKey();
                return;
            }
            if (run <= 5)
            {
                run = 20;
            } else
            {
                run = 20 + ((run - 5) * 3);
            }
            sum = wait + run;
            Console.WriteLine("Стоимость проезда: "+ sum);
            Console.ReadKey();
        }
    }
}
