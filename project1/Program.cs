using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write("1 ");
            for (int i = 2; i <= number; i++)
            {
                bool b = true;
                for (int i2 = 2; i2 < i; i2++)
                {
                    if (i % i2 == 0 & i % 1 == 0)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    
                    Console.Write("{0} ", i);
                }
                    
            }
            Console.ReadKey();
            return 0;
        }

    }
}