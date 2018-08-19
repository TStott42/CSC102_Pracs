using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("---- Please enter an amount: ");
            string cashStr = Console.ReadLine();
            while (Double.TryParse(cashStr, out double dbltest) == false)
            {
                Console.Write("This input does not make sense!!\n\nPress ENTER to continue ...\n");
                Console.ReadLine();
                Console.Write("---- Please enter an amount: ");
                cashStr = Console.ReadLine();
            }
            double cashDbl = Convert.ToDouble(cashStr) * 100;
            int cashInt = Convert.ToInt32(cashDbl);

            int numR200 = 0, numR100 = 0, numR50 = 0, numR20 = 0, numR10 = 0, numR5 = 0, numR2 = 0, numR1 = 0;
            int num50c = 0, num20c = 0, num10c = 0, num5c = 0, num2c = 0, num1c = 0;

            while(cashInt >= 20000)
            {
                cashInt -= 20000;
                numR200++;
            }
            if(numR200 != 0)
            {
                Console.Write(string.Format("Return {0} x R200 note(s)\n", numR200));
            }

            while (cashInt >= 10000)
            {
                cashInt -= 10000;
                numR100++;
            }
            if(numR100 != 0)
            {
                Console.Write(string.Format("Return {0} x R100 note(s)\n", numR100));
            }

            while (cashInt >= 5000)
            {
                cashInt -= 5000;
                numR50++;
            }
            if(numR50 != 0)
            {
                Console.Write(string.Format("Return {0} x R50 note(s)\n", numR50));
            }
            
            while (cashInt >= 2000)
            {
                cashInt -= 2000;
                numR20++;
            }
            if(numR20 != 0)
            {
                Console.Write(string.Format("Return {0} x R20 note(s)\n", numR20));
            }
            
            while (cashInt >= 1000)
            {
                cashInt -= 1000;
                numR10++;
            }
            if(numR10 != 0)
            {
                Console.Write(string.Format("Return {0} x R10 note(s)\n", numR10));
            }
            
            while (cashInt >= 500)
            {
                cashInt -= 500;
                numR5++;
            }
            if(numR5 != 0)
            {
                Console.Write(string.Format("Return {0} x R5 note(s)\n", numR5));
            }
            
            while (cashInt >= 200)
            {
                cashInt -= 200;
                numR2++;
            }
            if(numR2 != 0)
            {
                Console.Write(string.Format("Return {0} x R2 note(s)\n", numR2));
            }
            
            while (cashInt >= 100)
            {
                cashInt -= 100;
                numR1++;
            }
            if(numR1 != 0)
            {
                Console.Write(string.Format("Return {0} x R1 note(s)\n", numR1));
            }
            
            while (cashInt >= 50)
            {
                cashInt -= 50;
                num50c++;
            }
            if(num50c != 0)
            {
                Console.Write(string.Format("Return {0} x 50c coin(s)\n", num50c));
            }
            
            while (cashInt >= 20)
            {
                cashInt -= 20;
                num20c++;
            }
            if(num20c != 0)
            {
                Console.Write(string.Format("Return {0} x 20c coin(s)\n", num20c));
            }
            
            while (cashInt >= 10)
            {
                cashInt -= 10;
                num10c++;
            }
            if(num10c != 0)
            {
                Console.Write(string.Format("Return {0} x 10c coin(s)\n", num10c));
            }
            
            while (cashInt >= 5)
            {
                cashInt -= 5;
                num5c++;
            }
            if(num5c != 0)
            {
                Console.Write(string.Format("Return {0} x 5c coin(s)\n", num5c));
            }
            
            while (cashInt >= 2)
            {
                cashInt -= 2;
                num2c++;
            }
            if(num2c != 0)
            {
                Console.Write(string.Format("Return {0} x 2c coin(s)\n", num2c));
            }
            
            if (cashInt >= 1)
            {
                cashInt -= 1;
                num1c++;
            }
            if(num1c != 0)
            {
                Console.Write(string.Format("Return {0} x 1c coin(s)\n", num1c));
            }
            
            Console.ReadLine();
        }
    }
}
