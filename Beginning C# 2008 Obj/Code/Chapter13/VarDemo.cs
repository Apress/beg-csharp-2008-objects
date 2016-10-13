using System;
using System.Collections.Generic;

// This simple program shows some var syntax

public class VarDemo
{
  //  This won't compile
  //private var id = "111-11-111.dat";

  static void Main() {
    //  name is compiled as a string
    var name = "Lisa";    

    //  names is compiled as a List<string>
    var names = new List<string>();

    // Use var in foreach statement
    foreach(var item in names ) {
      //  Do something with item
    }

    //  This example won't compile
    //
    //var nameArray = { "Math 101", "Ballroom Dancing", "Physics 245" };  

  }
}
