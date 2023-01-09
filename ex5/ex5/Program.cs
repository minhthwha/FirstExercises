using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the size of the staircase.
            int n;

            // Enter the size.
            do
            {
                Console.Write("Please enter the size of the staircase: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 0 || n > 100);

            // Display the staircase.
            // i: Number of #.
            for(int i = 1; i <= n; i++)
            {
                // j: Number of whitespaces.
                for (int j = 1; j <= n; j++)
                {
                    // Whitespaces = Size - Number of #.
                    if(j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                // Insert new line after each row.
                Console.WriteLine();
            }

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
