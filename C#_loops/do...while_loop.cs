//  a do...while loop will always run once.
// Instead of checking the condition before the code block executes, the program in the block runs once and then checks the conditional statement. It will either stop or continue to execute until the condition is no longer true. do...while loops are good for when a program should execute at least once and then depending on the circumstances, continue to execute or stop.

// the following code will sound an alarm until the button is clicked

using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      
      do 
      {
        Console.WriteLine("BLARRRRRR");
      } while (!buttonClick);
      
      Console.WriteLine("You stopped the alarm!");

    }
  }
}