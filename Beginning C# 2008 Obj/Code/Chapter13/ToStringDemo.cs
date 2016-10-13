using System;

public class ToStringDemo {
  static void Main() {
    Student s = new Student("Cheryl Richter");
    Console.WriteLine(s);
  }
}

public class Student
{
  private String name;

  public Student(String n) {
    name = n;
  }

  public string Name{
    get {
      return name;
    }
    set {
      name = value;
    }
  }

  public override String ToString() {
    return "Student: name="+Name;
  }
}


