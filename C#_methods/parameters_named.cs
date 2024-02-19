using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      // the following line calls the function with ONLY 2 names parameters 
      // the rest are not mandatory
      VisitPlanets(numberOfPlanets: 2, name: "nick");
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
