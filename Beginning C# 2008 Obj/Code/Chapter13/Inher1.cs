using System;

public class Person {
  string name;

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }    
  }
}

// We derive the Student class from Person.
public class Student : Person {
  // If we define nothing in the body of this class, it will still have 
  // one field, name, and one property, Name, because these are
  // inherited from Person.
}
