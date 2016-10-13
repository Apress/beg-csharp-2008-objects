using System;

public class ObjectInitDemo {
  static void Main() {
    Person p = new Person{ Name="Emile Sanchez", Age=21 };
    Console.WriteLine("name = {0}  age = {1}",p.Name,p.Age);
  }
}

public class Person
{
    private string name;
    private int age;

    //  constructors
    public Person() {
        Name = "??";
        Age = 0;
    }

    public Person(string n, int age) {
        Name = n;
        Age = age;
    }

    //  properties
    public string Name { 
        get { 
            return name;
        }
        set {
            name = value;
        }
    }

    public int Age { 
        get { 
            return age;
        }
        set {
            age = value;
        }
    }

    //  Other Person class members omitted.
}
