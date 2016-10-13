using System;
using System.Collections.Generic;

public class ListDemo
{
  public static void Main() {
    List<Student> list = new List<Student>();
    Student s1 = new Student("Frank");
    Student s2 = new Student("Rameesh");

    list.Add(s1);
    list.Add(s2);

    //  No cast required.
    Student s3 = list[1];
    Console.WriteLine("name = "+s3.Name);
  }
}


