using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCollector
{
    class Program
    {
        static int taxCalc(int citAgeInt, double citEarnDbl)
        {
            int taxCode = 0, tax = 0;

            //This code deals with the "age" aspect of deducing a citizen's tax
            if (citAgeInt <= 100 && citAgeInt >= 75)
            {
                taxCode = 1;
            }
            else if (citAgeInt < 75 && citAgeInt >= 65)
            {
                taxCode = 2;
            }
            else if (citAgeInt < 65 && citAgeInt >= 20)
            {
                taxCode = 3;
            }
            else
            {
                Console.Write("<Invalid age>\n");
                return -1;
            }

            //This code deals with the "salary" aspect of a citizen's tax
            if(citEarnDbl > 0)
            {
                if (taxCode == 1)
                {
                    if (citEarnDbl > 60000.0)
                    {
                        tax = 17000;
                    }
                    else if (citEarnDbl > 40000.0)
                    {
                        tax = 15400;
                    }
                    else if (citEarnDbl > 20000.0)
                    {
                        tax = 7300;
                    }
                    else if (citEarnDbl > 17900.0)
                    {
                        tax = 1800;
                    }
                    else if (citEarnDbl > 13500.0)
                    {
                        tax = 1200;
                    }
                    else if (citEarnDbl > 10000.0)
                    {
                        tax = 400;
                    }
                    else
                    {
                        tax = 0;
                    }
                }
                else if (taxCode == 2)
                {
                    if (citEarnDbl > 60000.0)
                    {
                        tax = 17050;
                    }
                    else if (citEarnDbl > 40000.0)
                    {
                        tax = 15600;
                    }
                    else if (citEarnDbl > 20000.0)
                    {
                        tax = 7500;
                    }
                    else if (citEarnDbl > 17900.0)
                    {
                        tax = 2000;
                    }
                    else if (citEarnDbl > 13500.0)
                    {
                        tax = 1500;
                    }
                    else if (citEarnDbl > 10000.0)
                    {
                        tax = 600;
                    }
                    else
                    {
                        tax = 0;
                    }
                }
                else
                {
                    if (citEarnDbl > 60000.0)
                    {
                        tax = 20000;
                    }
                    else if (citEarnDbl > 40000.0)
                    {
                        tax = 16000;
                    }
                    else if (citEarnDbl > 20000.0)
                    {
                        tax = 8000;
                    }
                    else if (citEarnDbl > 17900.0)
                    {
                        tax = 2700;
                    }
                    else if (citEarnDbl > 13500.0)
                    {
                        tax = 2100;
                    }
                    else if (citEarnDbl > 10000.0)
                    {
                        tax = 1200;
                    }
                    else if (citEarnDbl > 7800.0)
                    {
                        tax = 620;
                    }
                    else if (citEarnDbl > 6500.0)
                    {
                        tax = 250;
                    }
                    else if (citEarnDbl > 5000.0)
                    {
                        tax = 13;
                    }
                    else
                    {
                        tax = 0;
                    }
                }
            }
            else
            {
                Console.Write("<Invalid salary>\n");
                return -1;
            }
            return tax;
        }

        static void Main(string[] args)
        {
            int count = 0, ageCount = 0, taxCount = 0, salCount = 0;
            int age = 0, ageSum = 0;
            double salary = 0, salSum = 0, taxSum = 0;
            int avgAge = 0;
            double avgSal = 0, avgTax = 0;
            bool validArgs = false;

            while(count != args.Length)
            {
                if(args[count].Contains(".") == false)
                {
                    ageSum += Convert.ToInt32(args[count]);
                    ageCount++;
                    count++;
                }
                else
                {
                    salSum += Convert.ToDouble(args[count]);
                    salCount++;
                    count++;
                }
            }
            for(int i = 0; i < args.Length; i=i+2)
            {
                salary = Convert.ToDouble(args[i]);
                age = Convert.ToInt32(args[i+1]);
                int tax = taxCalc(age, salary);
                if(tax != -1)
                {
                    taxSum += tax;
                    taxCount++;
                    validArgs = true;
                }
                else
                {
                    validArgs = false;
                    break;
                }
            }
            if(validArgs == true)
            {
                avgAge = ageSum / ageCount;
                avgSal = salSum / salCount;
                avgTax = taxSum / taxCount;

                Console.Write("Average age of taxpayers was {0}\nAverage monthly salary of taxpayers was R{1}\nAverage tax of all taxpayers was R{2}\n", avgAge, avgSal, avgTax);

                Console.Write("\nPress ENTER to continue ...");
            }
            else
            {
                Console.Write("An invalid argument exists");
            }

            Console.ReadLine();
        }
    }
}
