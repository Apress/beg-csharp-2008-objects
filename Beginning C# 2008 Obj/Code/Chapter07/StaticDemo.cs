using System;

public class Student {

  private string name;
  private static int totalStudents;

  private const double blah = 3.0;

  public Student(string name) {
    this.name = name;
    //totalStudents += 1;
  }

  public string Name {
    get {
      return name;
    }
    set {
      name = value;
    }
  }

  // details omitted ...

  public static int GetTotalStudents() {
    return totalStudents;
  }

  public static void setTotalStudents(int t) { 
    totalStudents = t;
  }

  public static void IncrementEnrollment() {
    totalStudents = totalStudents + 1;
    Console.WriteLine("totalStudents = "+totalStudents);
  }

  public static void Main() {
    Student s1 = new Student("bob");
    Student s2 = new Student("Liz");
    Student s3 = new Student("Soo");

//    s1.IncrementEnrollment();
//    s2.IncrementEnrollment();
//    s3.IncrementEnrollment();

    Student.IncrementEnrollment();
    Student.IncrementEnrollment();
    Student.IncrementEnrollment();

    Console.WriteLine("Total no. of students:  "+Student.GetTotalStudents());

  }
}

