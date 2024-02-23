// The foreach loop is used to iterate over collections, such as an array.
// the code below prints each item to the console 'foreach' todo array item

using System;

namespace ForEachLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
      
      foreach (string item in todo) {
        CreateTodoItem(item);
      }

    }
    
    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
  }
}
