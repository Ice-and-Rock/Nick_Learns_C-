using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Oak";
      f.biome = "evergreen";
      f.trees = 100;
      f.age = 500;

      Console.WriteLine(f.name);
    }
  }
}
