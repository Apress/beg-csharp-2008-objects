public class ScopeDemo
{
  public static void Main() {
    double cost = 2.65;

    if ( cost < 5.0 ) {
      double discount = 0.05;  // declare a variable inside the
                          // block of code
      // do some other stuff
    }

    // When the if statement block exits, the variable discount
    // is out of scope. If we try to use it in a statment,
    // the compiler will generate an error.

    double refund = cost*discount;   //  this won't work
  }
}
