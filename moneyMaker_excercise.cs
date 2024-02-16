// The following code takes a number and tells you the lowest number of coins it takes to devide into that number
// Have fun! 

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please write a number to convert to coins:");

      string numberAsString = Console.ReadLine();

      //Convert the captured value (a string) to a number
      double numberAsDouble = Convert.ToDouble(numberAsString);

      Console.WriteLine($"{numberAsDouble} is equal to...");

      // define the coins
      int goldCoin = 10;
      int silverCoin = 5;

      // Divide the number by the goldCoins
      double goldCoins = Math.Floor(numberAsDouble / goldCoin);
      // use modolo operator to find the next amount
      double leftOver = numberAsDouble % goldCoin;
      // find the max number of silver coins
      double silverCoins = Math.Floor(leftOver / silverCoin);
      // use modolo again to find the final remainder
      double remainder = leftOver % silverCoin;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}
