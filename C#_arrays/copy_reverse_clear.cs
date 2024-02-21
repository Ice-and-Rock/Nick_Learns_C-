// Following code uses Array.Copy() .Reverse() .Clear()

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      // initiate a new array with max length of summerStrut ✅
      string[] summerStrutCopy = new string[summerStrut.Length];
      // use Array.Copy(sourceArray, destinationArray, length) ✅
      Array.Copy(summerStrut, summerStrutCopy, summerStrut.Length);
      Console.WriteLine($"First value of summerStrutCopy: {summerStrutCopy[0]}");

      // use Array.Reverse() and print
      Array.Reverse(summerStrut);
      Console.WriteLine($"Reversed summerStrut: {summerStrut[0]}");

      // use Array.Clear() entire ratings array ✅
      Array.Clear(ratings, 0, ratings.Length);
      Console.WriteLine($"Cleared ratings no1: {ratings[0]}");
    }
  }
}
