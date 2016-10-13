using System;

public class SwitchDemo
{
  public static void Main() {
    string capital;
    string country1 = "Ind";
    string country2 = "ia";

    //  A switch statement compares the value 
    //  of the variable country against the value
    //  of three case labels. If no match is 
    //  found the code after the default label is
    //  executed.

    switch (country1+country2)
    {
      case("England"):
        capital = "London";
        break;
      case("India"):
        capital = "New Delhi";
        break;
      case("US"):
        capital = "Washington";
        break;
      default:
        capital = "not in database";
        break;
    }
    Console.WriteLine("capital of {0} is {1}",country1+country2,capital);

    for (int j = 1; j <= 4; j++) {
      for (int k = 1; k <= 4; k++) {
        Console.WriteLine("" + j + " * " + k + " = " + (j * k));
      }
    }

  }
}
