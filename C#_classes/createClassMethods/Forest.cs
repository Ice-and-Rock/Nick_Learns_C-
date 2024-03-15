// the following code includes new public methods
// they can be called like this:

// Forest f = new Forest();
// int result = f.IncreaseArea(2);         <----- method being used
// Console.WriteLine(result); // Prints 2

using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    // define a new public class, adds to trees and Age ✅
    public int Grow() {
      Trees = Trees + 30;
      Age ++;
      return Trees;
    }
    // define a new public class, decreases Trees and adds to Age ✅
    public int Burn() {
      Trees = Trees - 20;
      Age ++;
      return Trees;
    }
  }

}
