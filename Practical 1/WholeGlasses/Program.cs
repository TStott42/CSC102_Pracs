using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds>? ");

            String dripString = Console.ReadLine();
            int dripInt = Convert.ToInt16(dripString);
            int cups = Convert.ToInt16(Math.Floor((86400 / dripInt * 0.00025) * 4));

            Console.WriteLine("This wastes " + cups + " cups per day");

            Console.Read();
        }
    }
}
