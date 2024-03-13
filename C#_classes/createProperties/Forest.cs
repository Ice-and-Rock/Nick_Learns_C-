using System;

namespace BasicClasses
{
  class Forest
  {
    public string name;
    // define a basic name property ✅
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int trees;
    // define a basic trees property ✅
    public int Trees 
    {
      get { return trees; }
      set { trees = value; }
    }
    public int age;
    public string biome;
    // define a biome property that only allows three values ✅
    public string Biome 
    {
      get { return biome; }
      set 
       { 
        if (value == "Temperate") { biome = value; }
        else if (value == "Boreal") { biome = value; }
        else if (value == "Tropical") { biome = value; }
        else { biome = "Unknown"; }
       }
    }
  }

}
