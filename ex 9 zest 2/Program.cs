using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9_zest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definitions 
            Random rnd = new Random();
            int a = rnd.Next(0, 100);

            //Printing
            string text = (a % 2 == 0 ? "even" : "odd");
            Console.WriteLine("Number {0} is {1}", a, text);

            Console.ReadKey();

        }
    }
}
