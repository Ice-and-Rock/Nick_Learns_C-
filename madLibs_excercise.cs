// The following code creates a MadLib story
// using dotNet and C# in the terminal with user interactions

using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is built to create a MadLib story.
      Author: Nick V
      */


      // Let the user know that the program is starting:
      Console.WriteLine("MadLib is starting...");

      // Give the Mad Lib a title:
      string title = "MadLib Story Creator";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      // No.6 Adjectives
      Console.Write("Enter an adjective (descriptive word): ");
      string adj1 = Console.ReadLine();
      Console.Write("Enter another adjective (descriptive word): ");
      string adj2 = Console.ReadLine();
      Console.Write("Enter a final adjective (descriptive word): ");
      string adj3 = Console.ReadLine();
      // No.8 Verb
      Console.Write("Enter a verb (an action word): ");
      string verb = Console.ReadLine();
      // No.9 Nouns
      Console.Write("Enter a noun (naming word): ");
      string noun1 = Console.ReadLine();
      Console.Write("Enter another noun (naming word): ");
      string noun2 = Console.ReadLine();

      // No.10 Specific things
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();  
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Enter a country: ");
      string country = Console.ReadLine();
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
