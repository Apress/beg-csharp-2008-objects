using System;

public class WhileDemo
{
  public static void Main() {

    bool finished = false; 
    int i=0;

    //  do some stuff

    while ( !finished ) {
      Console.WriteLine("i = "+i);
      i++;
      if (i==3) {
        finished = true;  //  toggle the flag value
      }
    }
  }
}
