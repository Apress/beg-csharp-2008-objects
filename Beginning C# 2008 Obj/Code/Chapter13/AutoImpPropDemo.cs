using System;

public class EqualsDemo2 {
  static void Main() {
    Person p = new Person("Jackson");
    Console.WriteLine("Name is "+p.Name);
  }
}

public class Person
{
    //  The name field has been eliminated!

    //  constructor
    public Person (string name) {
        Name = name;
    }

    //  auto-implemented property
    public string Name { get; set; }

    //  Other Person class members omitted.
}
