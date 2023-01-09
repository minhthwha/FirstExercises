using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a time.
            Console.WriteLine("Please enter the time: ");
            DateTime d = DateTime.Parse(Console.ReadLine());

            // Turn into 24h format.
            Console.WriteLine("24h time is {0:HH:mm}", d);

            // Display result on screen.
            Console.ReadLine();
        }
    }
}
