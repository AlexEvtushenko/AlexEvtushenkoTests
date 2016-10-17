using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int krol = 64 / 4; krol >= 0; krol--)
            {
                Console.WriteLine("{0}.\t кроликов = {1}\tгусей = {2}", ++count, krol, (64 - krol * 4) / 2);
            
            }
            Console.ReadKey();
        }
    }
}
