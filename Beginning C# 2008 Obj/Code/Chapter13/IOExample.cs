using System;
using System.IO;

public class IOExample
{
  static void Main() {   
    FileStream fs;
    StreamReader srIn;

    // Read operations should be placed in a try-catch block.
      // Create a FileStream and a StreamReader
      fs = new FileStream("data.dat", FileMode.Open );
      srIn = new StreamReader(fs);

      // Read the first line from the file. 
      string line = srIn.ReadLine();

      Console.WriteLine("line = "+line);
      srIn.Close();
  }
}
