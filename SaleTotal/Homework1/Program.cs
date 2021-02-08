using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1 SaleTotal
            
            // Setting the tax constant
            const double tax = 1.085;

            //Get user input
            Console.WriteLine("What is the product name of the item you are purchasing?");

            string productName = Console.ReadLine();

            Console.WriteLine("How many " + productName + "(s) are you purchasing?");

            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the price of each " + productName + "?");

            double productPrice = Convert.ToDouble(Console.ReadLine());

            //Setting up output variables
            double subtotal = quantity * productPrice;

            double salesTax = subtotal * tax - subtotal;

            double total = subtotal * tax;

            //Giving user outputs
            Console.WriteLine("Your subtotal is: " + subtotal);

            Console.WriteLine("Your sales tax is: " + salesTax);

            Console.WriteLine("Your total is: " + total);
        }
    }
}
