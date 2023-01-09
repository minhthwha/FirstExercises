using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3: Number of elements in input arrays.

            // Declare the first input array.
            int[] a = new int [3];
            Console.WriteLine("Please enter your rating for Alice's challenge about problem clarity, origionality and difficulty!");
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Element number " + (i + 1) + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display the first input array.
            Console.Write("Rating for Alice's challenge: ");
            for(int i = 0; i < 3; i++)
            {
                Console.Write(a[i] + " ");
            }

            // Declare the second input array.
            int[] b = new int[3];
            Console.WriteLine("\nPlease enter you rating for Bob's challenge about problem clarity, origionality and difficulty!");
            for(int j = 0; j < 3; j++)
            {
                Console.Write("Element number " + (j + 1) + ": ");
                b[j] = int.Parse(Console.ReadLine());
            }

            // Display the second input array.
            Console.Write("Rating for Bob's challenge: ");
            for(int j = 0; j < 3; j++)
            {
                Console.Write(b[j] + " ");
            }

            // 2: Number of elements in the output array.
            // Declare the output array and its elements (to make sure the code knows where should it count from).
            int[] c = new int[2];
            c[0] = 0;
            c[1] = 0;

            // Compare the two array and add each elements of the output array up.
            for(int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    c[0] += 1;
                    c[1] += 0;
                }
                else if (a[i] == b[i])
                {
                    c[0] += 0;
                    c[1] += 0;
                }
                else
                {
                    c[0] += 0;
                    c[1] += 1;
                }
            }

            // Display the output array.
            Console.Write("\nPoint of Alice and Bob: ");
            for(int k = 0; k < 2; k++)
            {
                Console.Write(c[k] + " ");
            }

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
