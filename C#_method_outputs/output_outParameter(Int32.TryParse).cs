using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      
      int ageAsInt;
      bool outcome;
      
      // using Int32.TryParse() = produces boolean + number (0 if false)
      outcome = Int32.TryParse(ageAsString, out ageAsInt);
      
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);
        // result should be:
          // True
          // 102

      int nameAsInt;
      bool outcome2;

      outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

      Console.WriteLine(outcome2);
      Console.WriteLine(nameAsInt);
        // result should be:
          // False
          // 0

    }    
	}
}
