using System;

public class IfDemo
{
  public static void Main() {
    int x = 2;
    int y = 3;
    int z = 1;

    if (x >= 0) {
      if (y > x) {
        if (y > 2) // missing opening brace here, but ...
          Console.WriteLine("A");
          z = x + y;
        }
        else {
          Console.WriteLine("B");
          z = x - y;
        }
      }
      else {
        Console.WriteLine("C");
        z = y - x;
      }
    }
    else Console.WriteLine("D");  // compiler first complains here!  (line 23)
  }
}
  }
}
