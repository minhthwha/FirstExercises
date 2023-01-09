using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an array.
            // 5: Number of elements in an array.
            int[] a = new int[5];
            int i;
            Console.WriteLine("Please enter your array!");
            for(i = 0; i <= 4; i++)
            {
                Console.Write("Element number " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // Declare the sum.
            int sum = 0;
            for(i = 0; i <= 4; i++)
            {
                sum += a[i];
            }

            // Find the max and the min values.
            int max = a[0];
            int min = a[0];
            for(i = 0; i <= 4; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            // Sum of the max values.
            int sumMax = sum - min;
            Console.Write("Sum of the max values: " + sumMax);

            // Sum of the min values.
            int sumMin = sum - max;
            Console.Write("\nSum of the min values: " + sumMin);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
