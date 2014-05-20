using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //print amounts into equivalent change values
            //ChangeMaker(3.18);
            //ChangeMaker(0.99);
            //ChangeMaker(12.93);
            ChangeMaker(1.24);

            Console.ReadKey();
        }
        //create ChangeMaker function
        static void ChangeMaker(double amount)
        {
            double v = amount;
            //create variables to contain the number of each coin type
            int Quarters = 0;
            int Dimes = 0;
            int Nickels = 0;
            int Pennies = 0;
            //create loop to go through amount for each coin value type
            while (v > 0.25)
            {
                v = v - 0.25;
                Quarters++;
            }
            while (v > 0.10)
            {
                v = v - 0.10;
                Dimes++;
            }
            while (v > 0.05)
            {
                v = v - 0.05;
                Nickels++;
            }
            while (v > 0.01)
            {
                v = v - 0.01;
                Pennies++;
            }
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + Quarters);
            Console.WriteLine("Dimes: " + Dimes);
            Console.WriteLine("Nickels: " + Nickels);
            Console.WriteLine("Pennies: " + Pennies);
        }
    }
}
