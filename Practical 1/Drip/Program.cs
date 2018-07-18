using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop <in seconds>? ");

            String dripString = Console.ReadLine();
            int dripInt = Convert.ToInt16(dripString);

            Console.WriteLine("This wastes " + (3600 / dripInt * 0.00025) + " litres per hour");
            Console.WriteLine("This wastes " + (86400 / dripInt * 0.00025) + " litres per day");
            Console.WriteLine("This wastes " + (604800 / dripInt * 0.00025) + " litres per week");

            Console.Read();


        }
    }
}
