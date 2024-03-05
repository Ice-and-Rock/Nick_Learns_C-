// Password Checker
// The following code used if and switch statements to check a users password
// it is linked to an external function called 'Contains' in the Tools.cs file

// All works fine ✅

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 6;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "<>?:!@£$%^&*()[],.;'|" ;

      Console.WriteLine("please type a password...");
      string password = Console.ReadLine();

      int score = 0; 

      if (password.Length >= minLength) {
        score ++;
        // Console.WriteLine("length point " + score);
      } 
      if (Tools.Contains(password, uppercase)) {
        score ++;
        // Console.WriteLine("uppercase point " + score);
      }
      if (Tools.Contains(password, lowercase)) {
        score ++;
        // Console.WriteLine("lowercase point " + score);
      }
      if (Tools.Contains(password, digits)) {
        score ++;
        // Console.WriteLine("digits point " + score);
      }
       if (Tools.Contains(password, specialChars)) {
        score ++;
        // Console.WriteLine("specials point " + score);
      } 

      switch (score) {
        case 5:
        Console.WriteLine($"You scored: {score}. That is Extremely strong!");
        break;
        case 4:
        Console.WriteLine($"You scored: {score}. That is Extremely strong...");
        break;
        case 3:
        Console.WriteLine($"You scored: {score}. That is Strong.");
        break;
        case 2:
        Console.WriteLine($"You scored: {score}. That is Medium.");
        break;
        case 1:
        Console.WriteLine($"You scored: {score}. That is Weak. Do better, please.");
        break;
      }
    }
  }
}
