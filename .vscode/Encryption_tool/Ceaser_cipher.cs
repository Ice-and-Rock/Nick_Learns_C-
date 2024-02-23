// Ceaser Cipher 🥷
// The following code will prompt the user to input a sentence, then return an encrypted version of their message
// Enjoy!

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("Please type your secret message...");
      string message = Console.ReadLine();

      char[] secretMessageArr = message.ToCharArray();

      char[] encryptedMessage = new char[secretMessageArr.Length];

      for (int i = 0; i < secretMessageArr.Length; i++) {
        char currentChar = secretMessageArr[i];
        int alphaIndex = Array.IndexOf(alphabet, currentChar);
        int newAlphaIndex = (alphaIndex + 3) % alphabet.Length; 
        char newEncryptedChar = alphabet[newAlphaIndex];
        encryptedMessage[i] = newEncryptedChar;
      }
      string finishedEncryption = String.Join("", encryptedMessage);
      Console.WriteLine(finishedEncryption);
    }
  }
}