//  We can design custom 'out' parameters in our functions: 

using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      bool result;
      string whisperPhrase = Whisper("DOES THIS WORK?", out result);

      Console.WriteLine($"Was it called: {result}. Whispered phrase: {whisperPhrase}");
    } 

    // The out parameter must have the out keyword and its expected type
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      // The out parameter must be set to a value before the method ends
      wasWhisperCalled = true;
      return phrase.ToLower();
    }

	}
}

// The resulting output 
  // Was it called: True. Whispered phrase: does this work?
