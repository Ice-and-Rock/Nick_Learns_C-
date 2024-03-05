// True or False game
// the following game promps the user to take part in a true or false quiz 
// - based on hard-coded data
// - Mixture of 'if', 'foreach' and 'while' statements 

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"eggplant is a veggie", "eggplants are a species in the nightshade family", "you love eggplants", "you eat them for breakfast"};
      bool[] answers = {true, true, true, true};
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length) 
        {
          Console.WriteLine("Warning, questions doens't equal answers");
        }

      int askingIndex = 0;

      foreach (string question in questions) {
        string input;
        bool isBool = true;
        bool inputBool = true;
        
        Console.WriteLine($"{question}");
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
      
      while(isBool == false)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
      responses[askingIndex] = inputBool;
      askingIndex ++;
      // if(askingIndex == answers.Length) {
      //   Console.WriteLine("your answers:");
      //   foreach(bool response in responses)
      //     {
      //   Console.WriteLine(response);
      //     }
      // }

      // Scoring and EndGame section
      int scoringIndex = 0;
      int score = 0;

      if (askingIndex == questions.Length) {
          foreach(bool answer in answers)
            {
              bool response = responses[scoringIndex];
              // Console.WriteLine($"input: {response} | answer: {answer}");
              if (response == answer) {
                score ++;
              }
              scoringIndex ++;
            }
          Console.WriteLine("⭐️ Well done for finishing!");  
          Console.WriteLine($"You got {score} out of {questions.Length} correct");
        }
      }

    }
  }
}
