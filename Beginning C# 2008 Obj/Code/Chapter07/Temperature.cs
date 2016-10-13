using System;

public class Temperature {

  public const double FahrenheitFreezing = 32.0;
  public const double CentigradeFreezing = 0.0;
  public readonly double someValue;

  public Temperature( double value ) {
    someValue = value;
  }

  public static double FahrenheitToCentigrade(double tempF) {
    double tempC = (tempF - 32.0) * (5.0/9.0);
    return tempC;
  }

  public static double CentigradeToFahrenheit(double tempC) {
    double tempF = tempC * (9.0/5.0) + 32.0;
    return tempF;
  }

  public double someMethod() {
    const double blah = 12.3;
    return blah;
  }

  static void Main() {
    Console.WriteLine("45 degree celsius is "+
                      Temperature.CentigradeToFahrenheit(45.0)+" degrees Fahrenheit");
  }
} 



