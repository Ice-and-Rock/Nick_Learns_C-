// The following code creates a random animal to the terminal when the RandomMode() is called
// have fun!

using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Origional tests ✅:
        // MonsterHead();
        // GhostBody();
        // BugFeet();
      // BuildACreature("bug", "monster", "bug");
      // SwitchCase(1,3,1);
      RandomMode();
    }

// Below was deleted because it's no used for the current TASKS ✅
    // static void BuildACreature(string head, string body, string feet) 
    // {
    //   Console.WriteLine("build a creature running");
    //   int headInt = TranslateToNumber(head);      
    //   int bodyInt = TranslateToNumber(body);      
    //   int feetInt =  TranslateToNumber(feet); 

    //   Console.WriteLine($"selection: {head}, {body}, {feet}");     
      // switch(head) {
      //   case "ghost":
      //   MonsterHead();
      //   break;
      //   case "bug":
      //   BugHead();
      //   break;
      //   case "monster":
      //   MonsterHead();
      //   break;
      // };
      // switch(body) {
      //   case "ghost":
      //   MonsterBody();
      //   break;
      //   case "bug":
      //   BugBody();
      //   break;
      //   case "monster":
      //   MonsterBody();
      //   break;
      // }
      // switch(feet) {
      //   case "ghost":
      //   MonsterFeet();
      //   break;
      //   case "bug":
      //   BugFeet();
      //   break;
      //   case "monster":
      //   MonsterFeet();
      //   break;
      // }
    // }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int headNo = randomNumber.Next(1, 4);
      int bodyNo = randomNumber.Next(1, 4);
      int feetNo = randomNumber.Next(1, 4);
      // call the new random method here:
      SwitchCase(headNo, bodyNo, feetNo);

      Console.WriteLine($"selection numbers: {headNo}, {bodyNo}, {feetNo}");  
    }

    static void SwitchCase(int headInt, int bodyInt, int feetInt) 
    {
      switch(headInt) {
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
      }
        switch(bodyInt) {
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
      }
        switch(feetInt) {
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      switch(creature) {
        case "ghost":
          return 1;
        case "bug":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
