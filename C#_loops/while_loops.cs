// the following code deletes one email 'while' the emails are more than 0

using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;  
      while(emails > 0) {
        emails --; 
        Console.WriteLine($"Number of emails: {emails}");
      }
      
        Console.WriteLine("INBOX ZERO ACHEIVED!");
      
    }
  }
}
