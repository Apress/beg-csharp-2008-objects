using System;

public class SwitchDemo
{
  public static void Main() {
    string country, capital;
    country = "India";

    //  A switch statement compares the value 
    //  of the variable country against the value
    //  of three case labels. If no match is 
    //  found the code after the default label is
    //  executed.

    switch (country)
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
    Console.WriteLine("capital of {0} is {1}",country,capital);
  }
}
