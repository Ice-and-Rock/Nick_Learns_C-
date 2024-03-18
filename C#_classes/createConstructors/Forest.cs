// write a method that’s run every time an object is created to set those values at once.
// C# has a special type of method, called a constructor, that does just that. 

// We can add code in the constructor to set values to fields:

// class Forest
// {
//   public int Area;
 
//   public Forest(int area)
//   {
//     Area = area;
//   }
// }

// This constructor method is used whenever we instantiate an object with the new keyword:

// Constructor is called here (in MAIN):
// Forest f = new Forest(400);

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
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
// Define a constructor for the Forest class. It should have two parameters:
// name, which sets the Name property
// biome, which sets the Biome property
// It should also set the value of Age to 0.
    public Forest(string name, string biome){
      Name = name;
      Biome = biome;
      Age = 0;
    }
    
  }

}
