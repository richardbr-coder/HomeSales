using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              Sales Numbers Of All Sales Persons");
            Console.WriteLine("\n");

            //Two Array's that hold salesperson's name and sales 
            string[] salesPersons = new string[3];
            double[] sales = new double[3];
            double totalSales = 0;

            //Reading data from user and storing that data in the above arrays
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n  Enter Sales Person #" + (i + 1) + " Name: ");
                salesPersons[i] = Console.ReadLine();

                Console.Write("  Enter Sales of " + salesPersons[i] + ": ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\n");
            Console.WriteLine("   Total number of sales for each sales person:");


            //Displaying personal data and accumulating total sales
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n   " + salesPersons[i] + " \t " + sales[i]);
                totalSales += sales[i];
            }

            Console.WriteLine("\n\n      Combined Total Sales of all sales persons: " + totalSales + " \n\n");
            Console.ReadLine();
        }
    }
}
