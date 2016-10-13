using System;
using System.Collections.Generic;
using System.Collections;

public class ObjectIdentity {
  static void Main() {

    Student s1 = new Student("Callie");

    Console.WriteLine("type is "+s1.GetType().FullName);

    if ( s1.GetType() == typeof(Student) ) {
      Console.WriteLine(s1.Name+" is a Student");
    }

    if ( s1 is Student) {
      Console.WriteLine(s1.Name+" is a Student");
    }
  }
}

public class Student {

  public Student(string n) {
    Name = n;
  }

  public string Name { get; set;}
}

