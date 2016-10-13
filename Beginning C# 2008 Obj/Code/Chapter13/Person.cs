//  Person.cs

public class Person {
  // Field.
  private string name;

  // Constructor.
  public Person(string n) {
    name = n;
  }

  // Property.
  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }    
  }
}



