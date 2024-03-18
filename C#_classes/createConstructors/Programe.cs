using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      
      // The code below passes in to the Constructor "Forest" two values
      // the lines commented out are no longer useful because they are set in the constructor!
      Forest f = new Forest("Congo", "Tropical");
      // f.Name = "Congo";
      // f.Biome = "Desert";
      // f.Trees = 0;
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
      
    }
  }
}
