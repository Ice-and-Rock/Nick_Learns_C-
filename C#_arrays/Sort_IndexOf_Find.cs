// SORT()
// Array.Sort() sorts an array. 
// This method is a quick way to further organize array data into a logical sequence

// IndexOf()
// Array.IndexOf() takes a value and returns its index. 
// IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!).


// Find()
// Array.Find() searches a one-dimensional array for a specific value or set of values that match a certain condition and returns the first occurrence in the array.

using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      //  find the position for the first 3-star rated song
      int first3star = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {first3star+1} is rated three stars");

      // Find the first song that has more than 10 characters in its title
      string first10chars = Array.Find(summerStrut, name => name.Length >= 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {first10chars}");

      Array.Sort(summerStrut);
      Console.WriteLine($"alphabetical ordered array: no1. {summerStrut[0]} & no2. {summerStrut[7]}");
    }
  }
}
