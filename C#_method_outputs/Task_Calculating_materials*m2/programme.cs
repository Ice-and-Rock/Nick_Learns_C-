// The following code is 

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // inital tests ✅
        // Console.WriteLine(rectangle(4, 5));
        // Console.WriteLine(circleHalf(4));
        // Console.WriteLine(triangle(10, 9));
      
      // call the function/method
      CalculateTotalCost();
      
    }
    // Rectangle area
    static double rectangle(double length, double width) 
    {
      return length * width;
    }
    static double circleHalf(double radius)
    {
      return 0.5 * Math.Pow(radius, 2) * Math.PI;
    }
    // Triangle area
    static double triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }

    static void CalculateTotalCost() 
    {
       double totalShapesArea = Math.Round(rectangle(1500, 2500) + circleHalf(375) + triangle(750, 500), 2);

       double totalMaterialCost = Math.Round(totalShapesArea * 180, 2);

      Console.WriteLine($"The total floor space is {totalShapesArea} m2 so the total Material Cost is {totalMaterialCost} pesos");
    }
  }
}

// RESULT

// The total floor space is 4158393.23 m2 so the total Material Cost is 748510781.4 pesos