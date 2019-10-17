using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
  static void Main(string[] args)
  {
    int speed = int.Parse(Console.ReadLine());
    int lightCount = int.Parse(Console.ReadLine());
    List<int> PossibleSpeeds = new List<int>(50);
    for (int k = 1; k <= 200; k++) { PossibleSpeeds.Add(k); }


    for (int i = 0; i < lightCount; i++)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      int distance = int.Parse(inputs[0]);
      int duration = int.Parse(inputs[1]);
      List<int> Speeds = new List<int>();

      for (int j = speed; j > 0; j--) {
        if(Math.Floor((distance* 3.6)/(j*duration)) % 2 == 0)
        {
          Speeds.Add(j);
        }
      }
      PossibleSpeeds = PossibleSpeeds.Intersect(Speeds).ToList();
    }

    // Write an action using Console.WriteLine()
    // To debug: Console.Error.WriteLine("Debug messages...");
    
    Console.WriteLine(Convert.ToString(PossibleSpeeds.Max()));
  }
}
