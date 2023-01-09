using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare number of elements of an array.
            int n;
            do
            {
                Console.Write("Please enter the number of an array: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n > 100);

            // Declare an array.
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Element number " + (i + 1) + ": ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                while (a[i] < -100 || a[i] > 100);
            }

            // Count the positive elements.
            int countPositive = 0;
            int countNegative = 0;
            int countZero = 0;
            for(int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    countPositive++;
                }
                else if(a[i] == 0)
                {
                    countZero++;
                }
                else
                {
                    countNegative++;
                }
            }

            // Display the ratios.
            float positiveRatio = (float)countPositive / n;
            Console.Write("" + positiveRatio);
            float zeroRatio = (float)countZero / n;
            Console.Write("\n" + zeroRatio);
            float negativeRatio = (float)countNegative / n;
            Console.Write("\n" + negativeRatio);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
