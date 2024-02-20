// Return Errors
// As we mentioned before, we don’t like surprises — they lead to mistakes. So, when we call a method, we’d like to know what type of value will be returned. This is done in the method definition.

// The method definition must contain the type of the return value: if a method returns an integer, its return type must be int; if it returns text, it must be string, and so on. If the method returns nothing, use void.

// If a method returns a type different from its stated return type, it will throw an error. Here are some common errors you may see —

// This error means you must state a return type before the method name:

    // error CS1520: Method must have a return type

// This error means that your method doesn’t return a value, when it should:

    // error CS0161: [MethodName]: not all code paths return a value

// In some cases, this error means that your method returns a string when it should be an int (this one can be caused by a lot of things outside of methods):

    // error CS0029: Cannot implicitly convert type 'string' to 'int'

using System;

namespace ReturnErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Mars")); 
      Console.WriteLine("Is Pluto really a dwarf...?");
      Console.WriteLine(IsPlutoADwarf());
      Console.WriteLine("Then how many planets are there in the galaxy...?");
      Console.WriteLine(CountThePlanets());
    }
    
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    static bool IsPlutoADwarf()
    {
      return true;
    }
    
    static string CountThePlanets()
    {
      return "8 planets, usually";
    }
	}
}
