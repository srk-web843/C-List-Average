using System;
using System.Collections.Generic;

namespace ListAverage
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input five numbers: ");
      List<float> numList = new List<float>();
      for (int i = 0; i < 5; i++) {
      	string? input = Console.ReadLine();
        if (!float.TryParse(input, out float val)) {
            Console.WriteLine("Error: Invalid number entered.");
            return;
        }
        numList.Add(val);
      }
      float finalAverage = Average(numList);
      Console.WriteLine("The average of your numbers is " + finalAverage);
    }
    static float Average(List<float> valList) {
      float sum = 0;
      foreach (float val in valList) {
      	sum += val;
      }
      float average = sum/valList.Count;
      return average;
    }
  }
}