using System;

public class ArrayDemo {
  static void Main() {

    // create a string array using the "standard" syntax
//    string[] names = new string[3];
    string[] names = {"Vijay", "Tiger", "Phil"};

    // set the values of the array elements using the
    // SetValue() method
//    names.SetValue("Vijay",0);
//    names.SetValue("Tiger",1);
//    names.SetValue("Phil",2);

    

    // sort the array using the Sort() method. Remember
    // that Sort() is a static method.
    Array.Sort(names);

    // Print out the elements of the array using the
    // Length property and the GetValue() method
    for(int i=0; i<names.Length; ++i) {
      Console.WriteLine("Name "+i+" is "+names.GetValue(i));
    }

    Array.Reverse(names, 0, names.Length);
    for(int i=0; i<names.Length; ++i) {
      Console.WriteLine("Name "+i+" is "+names.GetValue(i));
    }

    Array.Clear(names, 0, names.Length);

    double[][] values = new double[3][];
    values[0] = new double[4];
    values[1] = new double[2];
    values[2] = new double[3];

    Console.WriteLine("number of rows = "+values.Length);
    for(int i=0; i<values.Length; ++i) {
      Console.WriteLine("number of columns in row "+i+" is "+values[i].Length);
    }

    double[] data = new double[10];  //  Initial array size is 10 elements

    int numData = 13;
    for(int i=0; i<numData; ++i) {  //  oh, oh, we're going to overflow the array
      if ( i == data.Length ) {
         Array.Resize(ref data, data.Length+5);  //  increase array size by 5
      }
      data[i] = 1.0;
    }

    Console.WriteLine("Array size = "+data.Length);

    //  Use Resize again to reduce array size to match amout of data
    Array.Resize(ref data, numData);

    Console.WriteLine("New array size = "+data.Length);

  }
}


