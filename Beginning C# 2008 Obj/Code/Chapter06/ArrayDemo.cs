using System;

public class ArrayDemo
{
  public static void Main() {
    int[] array1 = new int[5];

    Console.WriteLine("array1[1] = "+array1[1]);

    string[] array2 = (string[])Array.CreateInstance(typeof(string), 10);

    array2[0] = "blah";
    Console.WriteLine("array2[0] = "+array2[0]);

    Object x = Array.CreateInstance(typeof(string), 10);

    string str = "yuck";
    array2[1] = str;
    str = "hey";
    array2[2] = str;
    Console.WriteLine("array2[1] = "+array2[1]);
    Console.WriteLine("array2[2] = "+array2[2]);

    float[] array3 = new float[5];
    double temp2 = 23.45;
    array3[1] = (float)temp2;

    int[] data2 = new int[3];
    data2[0] = 4;
    int temp3 = data2[0];

    string[] names2 = {"Lisa", "Jackson", "Zachary"};
    Console.WriteLine("name 0 = "+names2[0]);

    double[,] data = new double[2,3];
    data[0,1] = 23.4;
    double temp = data[1,2];
    Console.WriteLine("temp = "+temp);

    string[][] names = new string[3][];
    names[0] = new string[2];
    names[1] = new string[5];
    names[2] = new string[3];
    names[2][2] = "Cheryl";
    Console.WriteLine("name is "+names[2][2]);
    
    double[] squareRoot = new double[11];  // we'll skip over cell 0

    for (int i = 1; i <= 10; i++) {
      squareRoot[i] = Math.Sqrt(i);  // the int is automatically cast
                                 // to a double 
    }

    Console.WriteLine("The square root of 5 is " + squareRoot[5]);

    int[,] blah2 = { {1, 2, 3},
                     {4, 5, 6} };
    for(int i=0; i<2; ++i ) {
      for(int j=0; j<3; ++j ) {
        Console.WriteLine("blah["+i+"]["+j+"] = "+blah2[i,j]);
      }
    }

    int[][] blah3 = new int[2][];
    blah3[0] = new int[] { 17, 3, 24 };
    blah3[1] = new int[] { 6, 37, 108, 99 };

    for(int i=0; i<2; ++i ) {
      for(int j=0; j<blah3[i].Length; ++j ) {
        Console.WriteLine("blah3["+i+"]["+j+"] = "+blah3[i][j]);
      }
    }

  }
}


