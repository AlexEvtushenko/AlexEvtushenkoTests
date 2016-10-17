using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            string valuta;
            Console.WriteLine("Введите сумму которую хотите конвертировать");
            try
            {
                money = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Мы просили ввести сумму!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите тип валюты ваших денег:\nd-если это доллары.\ne-евро.\ng-гривна.");
            valuta = Console.ReadLine();
            switch (valuta)
            {
                case "d":
                    Console.WriteLine("В гривнах: "+ Math.Round(money * 26, 2) + "\nВ евро: "+ Math.Round(money *0.9,2));
                    Console.ReadKey();
                    break;
                case "e":
                    Console.WriteLine("В гривнах: " + Math.Round(money * 29,2) + "\nВ долларах: " + Math.Round(money * 1.2, 2));
                    Console.ReadKey();
                    break;
                case "g":
                    
                   Console.WriteLine("В долларах: " + Math.Round(money /26, 2) + "\nВ евро: " + Math.Round(money /29, 2));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Мы не поддерживаем данную валюту");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
