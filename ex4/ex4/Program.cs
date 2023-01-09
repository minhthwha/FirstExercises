using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            // Declare the number of elements in an array.
            int n;
            do
            {
                Console.Write("Please enter the number of elements in an array: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 1 || n > 10);

            // Declare an array.
            Console.WriteLine("Please enter the elements of your array: ");
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Element number " + (i + 1) + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Declare the sum.
            long sum = 0;

            // Add each elements in each loop.
            for(i = 0; i < n; i++)
            {
                sum += a[i];
            }

            // Return sum.
            Console.Write("The sum of all array elements: " + sum);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
