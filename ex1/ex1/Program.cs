using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the values.
            int a, b;

            // Enter the values.
            do
            {
                Console.Write("Please enter the first value: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 1 || a > 1000);

            do
            {
                Console.Write("PLease enter the second value: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b < 1 || b > 1000);

            // Display sum.
            int sum = a + b;
            Console.Write("Sum: " + a + " + " + b + " = ");
            Console.WriteLine(sum);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
