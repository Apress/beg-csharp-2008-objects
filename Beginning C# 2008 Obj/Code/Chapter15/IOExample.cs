using System;
using System.IO;

public class IOExample
{
  static void Main() {   
    FileStream fs;
    StreamReader reader;
    StreamWriter writer;

    // Read operations should be placed in a try-catch block.
    try {
      // Create a FileStream and a StreamReader
      fs = new FileStream("data.dat", FileMode.Open );
      reader = new StreamReader(fs);

      // Read the first line from the file. 
      string line = reader.ReadLine();

      Console.WriteLine("line = "+line);

      // Open a StreamWriter based on the same FileStream. 
      fs = new FileStream("data2.dat", FileMode.OpenOrCreate );
      writer = new StreamWriter(fs);

      // write a line to the file
      string newLine = "Not so different from you and me";
      writer.WriteLine(newLine);

      //  Close the input and output streams.
      if ( reader != null ) {
        reader.Close();
      }
      if ( writer != null ) {
        writer.Close();
      }
    }
    catch (FileNotFoundException fnfe) {
      Console.WriteLine("FileNotFoundException occurred: "+fnfe);
      // Perform exception handling details omitted.
    }
    catch (IOException ioe) {
      Console.WriteLine("IOException occurred: "+ioe.Message);
      // Perform exception handling details omitted.
    }
  }
}
