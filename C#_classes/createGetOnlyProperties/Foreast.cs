using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    // define a public getter and a private setter ✅
    //  this still allows Age METHODS to set Age
    public int Age 
    { 
    get {return age;}
    private set { age = value; } 
    } 

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
    
    
  }

}
