using System;

public class Student {
  private string name;
  private string studentId;

  //  Overloaded constructors
  public Student() {
    Name = "??";
    StudentId = "??";
  }

  public Student(string name) {
    Name = name;
    StudentId = "??";
  }

  public Student(string name, string id) {
    Name = name;
    StudentId = id;
  }

  //  Properties
  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }
  }

  public string StudentId {
    get {
      return studentId;
    }
    set {
      studentId = value;
    }
  }

  public void DisplayAllFields() {
    Console.WriteLine(Name);
    Console.WriteLine(StudentId);
  }

  static void Main() {
    Student s1 = new Student();
    s1.DisplayAllFields();
    Console.WriteLine("");

    Student s2 = new Student("Kuo");
    s2.DisplayAllFields();
    Console.WriteLine("");

    Student s3 = new Student("Jackson", "222-22-2222");
    s3.DisplayAllFields();
    Console.WriteLine("");
  }
}
