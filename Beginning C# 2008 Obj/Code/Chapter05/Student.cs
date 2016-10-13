using System;

public class Student {
  private string name;
  private string studentId;

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
    GraduateStudent gs = new GraduateStudent();
    gs.Name = "Dinesh";
    Console.WriteLine("name = "+gs.Name);
  }
}
