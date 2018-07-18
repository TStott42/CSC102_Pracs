using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidatio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds>? ");

            String dripString = Console.ReadLine();

            if (Int32.TryParse(dripString, out int dripInt) == true)
            {
                int cups = Convert.ToInt16(Math.Floor((86400 / dripInt * 0.00025) * 4));
                Console.WriteLine("This wastes " + cups + " cups per day");
                Console.Read();
            } else
            {
                Console.WriteLine("\nPlease enter a valid input <integer>");
                Console.Read();
            }
            
        }
    }
}
