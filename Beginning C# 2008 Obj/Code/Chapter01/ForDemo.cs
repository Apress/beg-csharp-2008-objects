using System;

public class ForDemo
{
  public static void Main() {

    //  Create a simple multiplication table

    for (int j=0; j<3; ++j) {
      for (int k=0; k<4; ++k) {
        Console.WriteLine(j+"*"+k+" = "+j*k);
      }
    }
  }
}
