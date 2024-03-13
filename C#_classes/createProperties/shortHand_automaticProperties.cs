//  you can use { get; set; } as a short hand for creating automatic properties ✅

using System;

namespace BasicClasses
{
  class Forest
  {
    // public string name;
    // public string Name
    // {
    //   get { return name; }
    //   set { name = value; }
    // }
    public string Name { get; set; } ✅

    // public int trees;
    // public int Trees
    // {
    //   get { return trees; }
    //   set { trees = value; }
    // }
    public int Trees { get; set; } ✅
    
    
    public int age;
    public string biome;
    
    
    
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
  }

}
