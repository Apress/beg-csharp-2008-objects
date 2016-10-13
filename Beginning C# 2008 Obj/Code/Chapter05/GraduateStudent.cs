using System;

public class GraduateStudent : Student {
  // Declare two new attributes above and beyond
  // what the Student class declares ...

  private string undergraduateDegree;
  private string undergraduateInstitution;

  // ... and properties for each of the new attributes.

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

  // etc.
}

