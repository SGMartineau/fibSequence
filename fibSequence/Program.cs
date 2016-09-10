using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibSequence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer of the nth number in the fibbonaci sequence you want to see:");

            int x = 0;
            string strNum = Console.ReadLine();
            Int32.TryParse(strNum, out x);

            if (x == 0)
            {
                Console.WriteLine("Please enter a positive integer next time.");
            }

            int a = 1;
            int b = 0;

            for (int i = 1; i < x; i++)
            {
                int add = a + b;
                b = a;
                a = add;
            }

            Console.WriteLine("The number in position " + strNum + " of the fibbonaci sequence is: " + a);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
