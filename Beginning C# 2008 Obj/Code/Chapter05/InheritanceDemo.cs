using System;

// Defining the superclass:
//
public class Person {
  // Fields common to Students and Professors.
  private string name;      // See note about use of 'private' visibility
  private string address;   // with inheritance after this code example.
  private string birthdate;

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }
  }

  // etc. for the other properties.

  static void Main() {
    Professor p = new Professor();
    p.Name = "Dinesh";
    Console.WriteLine("name = "+p.Name);
  }
}

// Creating one subclass of Person ...
//
public class Student : Person {
  // Fields specific only to a Student.
  private string studentId;
  private string majorField;
  private string degreeSought;

  public string StudentId {
    get {
      return studentId;
    }
    set {
      studentId = value;
    }
  }

  // etc. for the other properties associated with
  // fields majorField and degreeSought.
}

// ... and another subclass of Person!
//
public class Professor : Person {
  // fields specific only to a Professor.
  private string title;
  private string worksFor;      

  public string Title {
    get {
      return title;
    }
    set {
      title = value;
    }
  }

  // etc. for the other property associated with field
  // worksFor.
}
