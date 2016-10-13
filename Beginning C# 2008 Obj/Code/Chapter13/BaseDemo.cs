using System;

public class Person 
{
  private string name;
  private string id;

  public Person(string name, string id) {
    Name = name;
    Id = id;
  }

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }    
  }

  public string Id {
    get {
      return id;
    }
    set {
      id = value;
    }    
  }

  public virtual string GetDescription() {
     return Name + " (" + Id + ")";
  }

  static void Main() {
    Student s = new Student("Jackson Palmer", "333-33-3333", "Game Programming");
    Console.WriteLine(s.GetDescription());
  }
}

public class Student : Person 
{
  private string major;

  //  Use the ": base" syntax to call the Person constructor.

  public Student(string name, string id, string major) : base(name, id) {
    Major = major;
  }

  public string Major {
    get {
      return major;
    }
    set {
      major = value;
    }    
  }

  //  Use the base keyword to call the Person class GetDescription() method.
  public override string GetDescription() {
     return base.GetDescription() + " [" + Major + "]";
  }

}





