// Student.cs

using System;

public class Student {
  private string name;
  private string id;
  private Professor facultyAdvisor;

  // Constructors.

  // This version takes three arguments.
  public Student(string n, string s, Professor p) {
    name = n;
    id = s;
    facultyAdvisor = p;
  }

  // This "flavor" takes two arguments.
  public Student(string n, string s) {
    name = n;
    id = s;

    // Since we aren't getting a Professor object handed in to us in
    // this version, we set this field to null for the time being.

    facultyAdvisor = null;
  }

  // We must explicitly provide the "default" constructor (if we want
  // to be able to use it) if we have created ANY other constructors.
  public Student() {
    // Note here that we've decided to invent some "placeholder"
    // values for the name and id fields in the case where
    // specific values are not being passed in.

    name = "???";
    id = "???-??-????";
    facultyAdvisor = null;
  }

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }    
  }

  // etc. for other properties

  public string GetFacultyAdvisorName() {
    // Note: since some of our constructors initialize facultyAdvisor with 
    // a Professor object, and others do not, we cannot assume that the 
    // attribute has been initialized to a Professor reference when the 
    // GetFacultyAdvisorName() method is invoked. To avoid the possibility 
    // of throwing a NullReferenceException, we check to make sure that the
    // facultyAdvisor attribute is NOT null before proceeding.
    if (facultyAdvisor != null) {
      return facultyAdvisor.Name;
    } else {
      return "TBD";
    }
  }
}

// Professor.cs 

public class Professor {
  // Declare the attributes.

  private string name;

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }    
  }
}

public class MyProgram {
  static void Main() {
    Student[] students = new Student[3];
    Professor p;

    p = new Professor();
    p.Name = "Dr. Oompah";

    // We'll try out the various constructor signatures.
    students[0] = new Student("Joe", "123-45-6789", p);
    students[1] = new Student("Bob", "987-65-4321");
    students[2] = new Student();

    Console.WriteLine("Advisor Information\n");
    for (int i=0; i < students.Length; i++) {
      Console.WriteLine("Name:  " + students[i].Name + 
        "    Advisor:  " +
        students[i].GetFacultyAdvisorName());
    }
  }
}

