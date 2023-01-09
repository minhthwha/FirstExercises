using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            // Declare the number of elements of an array.
            int n;
            do
            {
                Console.Write("Please enter the number of elements of an array: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);

            // Declare an array.
            int[] a = new int[n];
            for(i = 0; i < n; i++)
            {
                Console.Write("Element number " + (i + 1) + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find the max value.
            int max = a[0];
            for(i = 0; i < n; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }

            // Count the max values.
            int count = 0;
            for (i = 0; i < n; i++)
            {
                if (a[i] == max)
                {
                    count++;
                }
            }
            // Display the max values.
            Console.Write("Quantity of the max values: " + count);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
