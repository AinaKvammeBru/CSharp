using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Cents to coins converter!");
      Console.WriteLine("In this program we calculate the smallest amount of coins worth the same as the cents entered.");      
      
      // Prints the value of the coins
      Console.WriteLine(" The value of the coins is as such: ");
      Console.WriteLine(" - A bronze coin is worth 1 cent");
      Console.WriteLine(" - A silver coin is worth 5 cent");
      Console.WriteLine(" - A gold coin is worth 10 cent");

      // User input of the cents they want converted, that value is converted from string to double and then floored down to the nearest whole number
      Console.WriteLine("Enter the amount of cents you want to transfer into coins: ");
      double cents = Math.Floor(Convert.ToDouble(Console.ReadLine()));
      Console.WriteLine($"{cents} cents is equal to...");

      // The values of gold and silver coins, bronze is not needed due to it being equal to 1. 
      int goldValue = 10;
      int silverValue = 5;

       // Divides the user input by the gold value then floors it down to nearest whole number to get the gold coins
      double goldCoins = Math.Floor(cents / goldValue);
      
      // What did not fit into the gold coins gets bound to remainder variable
      double remainder  = cents % goldValue; 

      // Divides what did not fit into the gold coins with the value of silver and then floors it down to nearest whole number to get the silver coins
      double silverCoins = Math.Floor(remainder  / silverValue);
      
      // Finds what did not fit into the silver coins to find the value of the bronze coins
      remainder  = remainder  % silverValue;

      // Printing the results to the console
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");


    }
  }
}
