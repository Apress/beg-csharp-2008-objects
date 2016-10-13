using System;

public class Student {
  // Fields.
  private string name;
  private string studentId;
  private string majorField;
  private double gpa;

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

  public string MajorField {
    get {
      return majorField;
    }
    set {
      majorField = value;
    }
  }

  public double Gpa {
    get {
      return gpa;
    }
    set {
      gpa = value;
    }
  }

  //  The Student class Print() method is declared to be virtual
  public virtual void Print() {
    // We print out all the fields that the Student class
    // knows about.
    Console.WriteLine("Student Name:  " + Name + "\n" +
                       "Student No.:  " + StudentId + "\n" +
                       "Major Field:  " + MajorField + "\n" +
                       "GPA:  " + Gpa);
  }

  static void Main() {
    GraduateStudent gs = new GraduateStudent();
    gs.Name = "Dinesh";
    gs.StudentId = "111-11-1111";
    gs.MajorField = "Gender Studies";
    gs.Gpa = 3.95;
    gs.UndergraduateDegree = "PhD";
    gs.UndergraduateInstitution = "Cal";
    gs.Print();
  }
}

public class GraduateStudent : Student {
  private string undergraduateDegree;
  private string undergraduateInstitution;

  public string UndergraduateDegree {
    get {
      return undergraduateDegree;
    }
    set {
      undergraduateDegree = value;
    }
  }

  public string UndergraduateInstitution {
    get {
      return undergraduateInstitution;
    }
    set {
      undergraduateInstitution = value;
    }
  }

  public override void Print() {
    // Reuse code by performing the Print() method defined by the Student
    // superclass ...
    base.Print();

    // ... and then go on to print this subclass's specific fields.
    Console.WriteLine("Undergrad. Deg.:  " + UndergraduateDegree + "\n" +
                      "Undergrad. Inst.:  " + UndergraduateInstitution);
  }
}
