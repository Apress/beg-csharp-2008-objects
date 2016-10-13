using System;

public class IfDemo
{
  public static void Main() {
    double sales = 40000.0;
    int lengthOfService = 12;
    double bonus;

    //  An if-else statement is used to determine
    //  the size of an employee's bonus

    if ( sales > 30000.0 && lengthOfService >= 10 ) {
      bonus = 2000.0;
    } 
    else if ( sales > 20000.0 ) { 
        bonus = 1000.0;
    } 
    else {
        bonus = 0.0;
    }

    Console.WriteLine("Bonus = "+bonus);
  }
}
