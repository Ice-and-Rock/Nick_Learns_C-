using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      // return the function with a string value
      Console.WriteLine(DecoratePlanet("Jupiter"));    
    }
    
    // write a funtion with a return statement
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    
  	}
  }
}
