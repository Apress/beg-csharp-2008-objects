using System;

public class StringDemo {
  static void Main() {
    char[] chars = { 'L', 'i', 's', 'a' };
    string name2 = new string(chars);
    Console.WriteLine(name2);

//    string str = "This line should break here \n"+
//                 "and can contain backslashes (\\), etc.";
    string str = @"This line should break here,
and can contain backslashes (\), etc.";

    Console.WriteLine(str);

    string name = "Jim Chen";
    if (name == "Jim Chen") {
      Console.WriteLine("This is Jim Chen");
    }

    Console.WriteLine("name has "+name.Length+" characters");

    string s = "foobar";
    if ( s.StartsWith("foo") ) {
      Console.WriteLine("starts with foo");
    }

    string s2 = "foobar";
    int i = s2.IndexOf("bar");  // i will equal 3
    int j = s2.IndexOf("cat");  // j will be less than 0, because 
                           // "cat" is not found in "foobar"
    string t = "oo";
    int k = s2.IndexOf(t);      // k will equal 1

    Console.WriteLine("i = "+i);
    Console.WriteLine("j = "+j);
    Console.WriteLine("k = "+k);

    string s3 = "o1o2o3o4";
    // Note use of single quotes around characters 
    // vs. double quotes around strings.
    string p = s3.Replace('o', 'x');   // p now equals "x1x2x3x4", and
    Console.WriteLine("p is "+p);

    string s4 = "Jose Cruz";
    string p2 = s4.ToLower();
    Console.WriteLine(p2);
    string s5 = "Jose Cruz";
    string p5 = s5.ToUpper();
    Console.WriteLine(p5);

    string str8 = "Tom Servo";
    Console.WriteLine("length is "+str8.Length);
    int ii = 0;
    Console.WriteLine("First character is "+str8[2*ii]);

    string tt = "foobar";
    string ss = tt.Replace("bar","me");
    Console.WriteLine("ss is "+ss);

  }
}


