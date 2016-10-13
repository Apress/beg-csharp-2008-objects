using System;

// Compile command:
//
//  csc ExceptionDemo.cs Student.cs InvalidStudentIdException.cs

public class ExceptionDemo
{
  public static void Main() {
    Student s;

    try {
      //  This is a valid student ID
      //s = new Student("123-45-6789");

      //  This is an invalid student ID
      s = new Student("123-45-67");
    }
    catch (InvalidStudentIdException ex) {
      Console.WriteLine(ex.Message);
      s = new Student("???-??-????");
    }

    // Write out the student ID
    Console.WriteLine("Student ID = "+s.Id);
  }
}
