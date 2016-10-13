using System;

// This simple program shows some C# basic syntax

public class Student
{
  private string name;

  public Student(string name) {
    this.name = name;
  }

  public string Name{
    get {
      return name;
    }
    set {
      name = value;
    }
  }


  private void PrintInfo() {
    return;
  }
}