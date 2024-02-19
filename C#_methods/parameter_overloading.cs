using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
        //  the following lines will default to their method upon overload
      NamePets("john", "steve");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }

    static void NamePets(string 1, string 2) {
      Console.WriteLine("Your pets Laika and Albert will be joining your voyage across space!");
    }

    static void NamePets(string 1, string 2, string 3) {
      Console.WriteLine("Your pets Mango, Puddy, and Bucket will be joining your voyage across space!");
    }

     static void NamePets() {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
    
  }
}
