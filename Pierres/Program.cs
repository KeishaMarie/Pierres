using System;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("|------------------------------------------|");
    Console.WriteLine("        Welcome to Pierre's Bakery!");
    Console.WriteLine(" We offer savory bread and sugary pastries");
    Console.WriteLine("|------------------------------------------|");
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

    Console.WriteLine("You have " + totalLoaves + " loaves totaling $" + breadOrder.BreadPrice(totalLoaves) + " and " + totalPastries + " pastries totaling $" + pastryOrder.PastryPrice(totalPastries));
    Console.WriteLine("Your order total is $" + orderTotal);

    Console.WriteLine("Would you like to add more to your order? Enter yes or no");
    string response = Console.ReadLine();
    switch (response)
    {
      case "yes":
        Console.WriteLine("Enter the number of loaves you would like to add to your order.");
        int addLoaves = Int32.Parse(Console.ReadLine());
        Bread updatedLOrder = new Bread(addLoaves);
        Console.WriteLine("Enter the number of pastries you would like to add to your order.");
        int addPastries = Int32.Parse(Console.ReadLine());
        Pastry updatedPOrder = new Pastry(addPastries);
        int newOrderTotal = ((updatedLOrder.BreadPrice(addLoaves) + updatedPOrder.PastryPrice(addPastries) + orderTotal));
        Console.WriteLine("Your new total is $" + newOrderTotal);
        Console.WriteLine("Thank you for shopping Pierre's!");
        break;
      case "no":
        Console.WriteLine("Your order total is $" + orderTotal);
        Console.WriteLine("Thank you for shopping Pierre's!");
        break;
      default:
        Console.WriteLine("Your order total is $" + orderTotal);
        Console.WriteLine("Thank you for shopping Pierre's!");
        break;
    }

  }
}