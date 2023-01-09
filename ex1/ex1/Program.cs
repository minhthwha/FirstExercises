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
            // Enter the values.
            Console.Write("Please enter the first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second value: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Display sum.
            Console.Write("Sum: " + (a + b));

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
