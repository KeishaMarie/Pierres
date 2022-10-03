using System;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("We offer bread and pastries");
    Console.WriteLine("One loaf of bread is $5, two loaves is $10. Or buy multiple and take advantage of our Buy Two Get One Free deal!");
    Console.WriteLine("One pastry is $2, two pastries are $4 and every third pastry is $1!");
    Console.WriteLine("<------------------------------------------->");
   
    Console.WriteLine("Enter the number of loaves you would like.");
    int totalLoaves = Int32.Parse(Console.ReadLine());
    Bread breadOrder = new Bread(totalLoaves);

    Console.WriteLine("Enter the number of pastries you would like.");
    int totalPastries = Int32.Parse(Console.ReadLine());
    Pastry pastryOrder = new Pastry(totalPastries);

    int orderTotal = (breadOrder.BreadPrice(totalLoaves) + pastryOrder.PastryPrice(totalPastries));

    Console.WriteLine("Your order is $" + orderTotal);

    Console.WriteLine("You have " + totalLoaves + " loaves at $" + breadOrder.BreadPrice(totalLoaves) + " and " + totalPastries + " pastries at $" + pastryOrder.PastryPrice(totalPastries));
    Console.WriteLine("Your order total is $" + orderTotal);
    
    // Console.WriteLine("Would you like to add more to your order?");
    // string response2 = Console.ReadLine();
    // switch (response2)
    // {

    // }

  }
}