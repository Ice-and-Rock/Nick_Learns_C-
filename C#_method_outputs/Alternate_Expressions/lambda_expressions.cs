// the following code replaces a method as an argument with a lambda expression
// With a lambda expression, we can define method() directly in the method call. 
// We don’t even need to give it a name

using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      //  Lambda expression:
      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
      // Replaces...
      // bool makesContact = Array.Exists(spaceRocks, HitGround);
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite"; 
    }
  }
}
