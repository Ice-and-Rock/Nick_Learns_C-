//  You know what a for loop is, nick!
// The following code pprints 16 reports listing the index at the top of each report

using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
    for (int i = 0; i < 17; i++){
      CreateTemplate(i);
    };
      

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
    
  }
}
