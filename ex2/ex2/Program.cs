using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare number of elements in an array.
            int n;

            // Enter number of elements in an array from keyboard.
            do
            {
                Console.Write("Please enter the number of elements in your array: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 1 || n > 1000);

            // Declare an array.
            int[] a = new int[n];

            // Enter the elements.
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Element number " + (i + 1) + ": ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (a[i] < 1 || a[i] > 1000);
            }

            // Declare the sum.
            int sum = 0;

            // Add each element up in each loop.
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            // Return sum.
            Console.Write("Sum: " + sum);

            // Return result on screen.
            Console.ReadLine();
        }
    }
}
