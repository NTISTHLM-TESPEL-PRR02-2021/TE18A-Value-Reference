using System;

namespace Reference
{
  class Program
  {
    static void Main(string[] args)
    {
      int y = 100;

      int u = y;

      int[] g = {100};
      int[] b = g;

      Enemy e1 = new Enemy();

      DoThing(e1);

      Console.WriteLine(e1.hp);

      Console.ReadLine();

    }

    static void DoThing(Enemy k)
    {
      k.hp++;
    }
  }
}
