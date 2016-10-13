using System;
using System.Collections.Generic;
using System.Collections;

public class MethodHideDemo {
  static void Main() {

    List<Student> students = new List<Student>();

    Student c1 = new Student("Fred");
    Student c2 = new GradStudent("Elvis");
    Student c3 = new UndergradStudent("Callie");

    students.Add(c1);  
    students.Add(c2); 
    students.Add(c3);

    // Let's now pull them back out! 
    for (int i=0; i < students.Count; i++) {
      Console.WriteLine(students[i].printMessage());
    }

  }
}

public class Student {
  //private string name;

  public Student(string n) {
    Name = n;
  }

  public string Name { get; set;}

  public virtual string printMessage() {
      return "Student talking to you";
  }

}

public class GradStudent : Student {

  public GradStudent(string n): base(n) {}

  public override string printMessage() {
      return "Grad student talking to you";
  }

}

public class UndergradStudent : Student {

  public UndergradStudent(string n): base(n) {}

  public override string printMessage() {
      return "Undergrad student talking to you";
  }

}



