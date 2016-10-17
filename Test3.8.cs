using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string truPass = "root";
            string usPass;
            bool go = false;
            Console.WriteLine("Пожалуйста введите пароль!");
            while (!go)
            {
                usPass = Console.ReadLine();
                go = string.Equals(truPass, usPass);
                if (!go)
                {
                    Console.WriteLine("Пароль неверный!Попробуйте еще раз!");
                }
                else
                {
                    Console.WriteLine("Пароль верный");
                    Console.ReadKey();
                }

            }
        }
    }
}
