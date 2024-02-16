// The following code is a logic operator to decide between true and false statements
// - use the truth_table for reference

using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      // You want it to have a beach and a city.
      bool yourNeeds = beach && city;
      // Your friend wants a beach or hiking.
      bool friendNeeds = beach || hiking;

      // Your current pick is Barcelona, which is a city that has a beach.
      // Write a logical comparison for yourNeeds and friendNeeds and save it to tripDecision
      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);
    }
  }
}


