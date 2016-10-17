using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int someDigit = rand.Next(1, 147);
            int guess;
            Console.WriteLine("Угадайте загаданное компьютером число от 1 до 146");
            do
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно было ввести число!");
                    Console.ReadKey();
                    return;
                }
                if (guess>someDigit)
                {
                    Console.WriteLine("Ваше число больше!");
                    
                } else
                {
                    Console.WriteLine("Ваше число меньше!");
                }
            } while (guess != someDigit) ;
                Console.WriteLine("Вы угадали! Ваше число: "+ guess + "\nИ число компьютера: "+ someDigit);
            Console.ReadKey();
        }
    }
}
