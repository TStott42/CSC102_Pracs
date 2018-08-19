using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxCode = 0;

            //This code deals with the "age" aspect of deducing a citizen's tax
            Console.Write("How old are you? ");
            string citAgeStr = Console.ReadLine();
            int citAgeInt;
            while(Int32.TryParse(citAgeStr, out citAgeInt) == false)
            {
                Console.Write("This is not a valid integer\nHow old are you? ");
                citAgeStr = Console.ReadLine();
            }
            if(citAgeInt >= 75)
            {
                taxCode = 1;
            }
            else if(citAgeInt < 75 && citAgeInt >= 65)
            {
                taxCode = 2;
            }
            else if(citAgeInt < 65 && citAgeInt >= 0)
            {
                taxCode = 3;
            }
            else
            {
                Console.Write("This is not a valid age");
            }

            //This code deals with the "salary" aspect of a citizen's tax
            Console.Write("How much do you earn? ");
            string citEarnStr = Console.ReadLine();
            int citEarnInt;
            while(Int32.TryParse(citEarnStr, out citEarnInt) == false)
            {
                Console.Write("This is not a valid integer\nHow much do you earn? ");
                citEarnStr = Console.ReadLine();
            }
            if(taxCode == 1)
            {
                if(citEarnInt > 60000)
                {
                    Console.Write("\nYour monthly payable tax is 17000");
                }
                else if(citEarnInt > 40000)
                {
                    Console.Write("\nYour monthly payable tax is 15400");
                }
                else if(citEarnInt > 20000)
                {
                    Console.Write("\nYour monthly payable tax is 7300");
                }
                else if(citEarnInt > 17900)
                {
                    Console.Write("\nYour monthly payable tax is 1800");
                }
                else if(citEarnInt > 13500)
                {
                    Console.Write("\nYour monthly payable tax is 1200");
                }
                else if(citEarnInt > 10000)
                {
                    Console.Write("\nYour monthly payable tax is 400");
                }
                else
                {
                    Console.Write("\nYour monthly payable tax is 0");
                }
            }
            else if(taxCode == 2)
            {
                if (citEarnInt > 60000)
                {
                    Console.Write("\nYour monthly payable tax is 17050");
                }
                else if (citEarnInt > 40000)
                {
                    Console.Write("\nYour monthly payable tax is 15600");
                }
                else if (citEarnInt > 20000)
                {
                    Console.Write("\nYour monthly payable tax is 7500");
                }
                else if (citEarnInt > 17900)
                {
                    Console.Write("\nYour monthly payable tax is 2000");
                }
                else if (citEarnInt > 13500)
                {
                    Console.Write("\nYour monthly payable tax is 1500");
                }
                else if (citEarnInt > 10000)
                {
                    Console.Write("\nYour monthly payable tax is 600");
                }
                else
                {
                    Console.Write("\nYour monthly payable tax is 0");
                }
            }
            else
            {
                if (citEarnInt > 60000)
                {
                    Console.Write("\nYour monthly payable tax is 20000");
                }
                else if (citEarnInt > 40000)
                {
                    Console.Write("\nYour monthly payable tax is 16000");
                }
                else if (citEarnInt > 20000)
                {
                    Console.Write("\nYour monthly payable tax is 8000");
                }
                else if (citEarnInt > 17900)
                {
                    Console.Write("\nYour monthly payable tax is 2700");
                }
                else if (citEarnInt > 13500)
                {
                    Console.Write("\nYour monthly payable tax is 2100");
                }
                else if (citEarnInt > 10000)
                {
                    Console.Write("\nYour monthly payable tax is 1200");
                }
                else if(citEarnInt > 7800)
                {
                    Console.Write("\nYour monthly payable tax is 620");
                }
                else if(citEarnInt > 6500)
                {
                    Console.Write("\nYour monthly payable tax is 250");
                }
                else if(citEarnInt > 5000)
                {
                    Console.Write("\nYour monthly payable tax is 13");
                }
                else
                {
                    Console.Write("\nYour monthly payable tax is 0");
                }
            }

            Console.ReadLine();
        }
    }
}
