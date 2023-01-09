using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the sum of all elements.
            int sumLeft = 0;
            int sumRight = 0;

            // Declare the matrix.
            int[,] a = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    // Enter the elements.
                    Console.Write("Element [" + (i +1) + "][" + (j+1) + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());

                    // Sum of left-to-right diagonal.
                    if(i == j)
                    {
                        sumLeft += a[i, j];
                    }

                    // Sum of the right-to-left diagonal.
                    // 2: Number of elements + 1 && Sum of the elements location.
                    if((i + j) == 2)
                    {
                        sumRight += a[i, j];
                    }
                }
            }

            // Display the sum.
            Console.Write("Sum of the two diagonals: " + sumLeft + " and " + sumRight);

            // Display the absolute difference between those two.
            Console.Write("\nThe absolute difference between the sum of two diagonals: "); 
            Console.Write(Math.Abs(sumLeft - sumRight));

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
