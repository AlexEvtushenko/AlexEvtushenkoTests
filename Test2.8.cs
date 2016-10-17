using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            Random rand = new Random();
            int cube = rand.Next(1, 13);
            string result = "Твой выиграш: ";
            Console.WriteLine("Введите сумму Вашей ставки!");
            try
            {
                money = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Нам нужны только деньги, а не вот это вот!!!");
                Console.ReadKey();
                return;
            }
            if (cube <= 5)
            {
                result = result + 0 + ".\nТы проиграл свои деньги)\nНа кубике выпало: "+ cube;
            }
            else if (cube >= 6 && cube <= 8)
            {
                result = result + money + ".\nТы вернул свои деньги!\nНа кубике выпало: " + cube;
            }
            else if (cube >= 9 && cube <= 11)
            {
                result = result + money * 2 + ".\nСегодня тебе повезло!\nНа кубике выпало: " + cube;
            }
            else
            {
                result = result + money*10 + ".\nДа ты король!!!!\nНа кубике выпало: " + cube;
                
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}