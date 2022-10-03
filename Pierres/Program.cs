using System;


class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("Are you craving Bread or Pastries? Please choose one.");
    string response = Console.ReadLine();

    if (response == "bread")
    {
      Console.WriteLine("One loaf of bread is $5, two loaves is $10. Or buy multiple and take advantage of our Buy two get one free deal!");
      Console.WriteLine("Three loaves for $10 or six loaves for $20!");
      Console.WriteLine("Enter the number of loaves you would like.");
      int breadAmount = Int32.Parse(Console.ReadLine());
    }
    else (response == "pastries")
    {
      Console.WriteLine("One pastry is $2, two pastries is $4 and every third pastry is $1!")
    }

    


  
  }
}