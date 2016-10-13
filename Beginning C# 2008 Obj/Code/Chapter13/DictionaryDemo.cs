using System;
using System.Collections.Generic;

public class DictionaryDemo {
  static void Main() {

Dictionary<string, Student> students = new Dictionary<string, Student>();  

// Create several Student objects.
Student s1 = new Student("123-45-6789", "David Chen");
Student s2 = new Student("987-65-4321", "Mary Jones");
Student s3 = new Student("654-32-1987", "Gerson Lopez");


// Store Student objects in the Dictionary.
students.Add(s1.Id, s1);
students.Add(s2.Id, s2);
students.Add(s3.Id, s3);

//  Retrieve a particular Student based on the ssn key.
Student s4 = students["654-32-1987"];
Console.WriteLine("student name is "+s4.Name);

if ( students.ContainsKey("987-65-4321") ) {
    Console.WriteLine("Key already exists ");
}

foreach( KeyValuePair<string, Student> kv in students ) {
    Student s = kv.Value;
    Console.WriteLine("key is "+kv.Key+"  Student name is "+s.Name);
}

Dictionary<string, Student>.ValueCollection valColl = students.Values;

foreach( Student s in valColl ) {
    Console.WriteLine("Student name is "+s.Name);
}

Dictionary<string, Student>.KeyCollection keyColl = students.Keys;

foreach( string key in keyColl ) {
    Console.WriteLine("key name is "+key);
}


  }
}

public class Student {

  public Student(String s, String n) {
    //ssn = s;
    //name = n;
    Name = n;
    Id = s;
  }

  public String Name {get; set;}
  public String Id {get; set;}

}

public class Course {
  private string name;

  public Course(String n) {
    name = n;
  }

  public String Name {get; set;}
}


