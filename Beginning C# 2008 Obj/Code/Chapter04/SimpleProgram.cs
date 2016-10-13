using System;

// This simple program shows some C# basic syntax
//
//  The compile command is:
//
//  csc SimpleProgram.cs Student.cs Student2.cs

public class SimpleProgram
{
  public static void Main() {

    // This Student uses get/set methods
    Student s = new Student();
    s.SetName("Fred");
    Console.WriteLine("Name is "+s.GetName());

    // This Student uses properties
    Student2 s2 = new Student2();
    s2.Name = "Maria";
    Console.WriteLine("Name is "+s2.Name);
  }

}