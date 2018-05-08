using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            // ACC VR & AR Diploma
            // Gerges Romany
            int num;
            int x;
            for (num = 1; num <= 12; num++)
            {
                Console.WriteLine( "<--------- " + num + " ----------->");
                for (x = 1; x <= 12; x++)
                {
                    Console.WriteLine("\n" + num + "*" + x + "=" + (num * x));
                }
                x = 1;
                Console.WriteLine("\n");
            }
            sleep(500);
        }

        private static void sleep(int v)
        {
            throw new NotImplementedException();
        }
    }
}
