// The code below is a game method that:
// - takes in user input
// - passes array data into a newly created game method
// - provides a fun game with logic loops and arrays !

// EDIT
// the else statement in the mian method stops the method instead of continually prompting the user
// use a 'while' statement to only pass to arrays to the game method while it's true?

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args) 
    {
      // Main Method Logic | data
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      Console.WriteLine("Would you prefer an eggplant OR potato quiz?");
      string quizName = Console.ReadLine();

      // Eggplant Quiz
      string[] eggplantQuestions = {"eggplant is a veggie", "eggplants are a species in the nightshade family", "you love eggplants", "you eat them for breakfast"};
      bool[] eggplantAnswers = {true, true, true, true};
      // Potato Quiz
      string[] potatoQuestions = {"Potatoes are a type of root vegetable", "Potatoes originated in South America", "You can eat potato skins", "Potatoes are naturally blue in color"};
      bool[] potatoAnswers = {true, true, true, false};

      // User selection - pass data into game method 
      if (quizName == "eggplant") {
       PlayTrueOrFalseGame(eggplantQuestions, eggplantAnswers);
      } else if (quizName == "potato") {
        PlayTrueOrFalseGame(potatoQuestions, potatoAnswers);
      } else {
        Console.WriteLine("Please type either 'eggplant' OR 'potato'...");
      }
    }

    // GAME LOGIC
    static void PlayTrueOrFalseGame(string[] questions, bool[] answers) 
    {
      // Type your code below
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
        
        Console.WriteLine($"Question {askingIndex + 1}: {question}");
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

      // 15.
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
