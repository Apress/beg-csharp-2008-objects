using System;

public class EqualsDemo2 {
  static void Main() {
    Professor p = new Professor();

    Student s1 = new Student(); // first object ...
    s1.StudentId = "123-45-6789";

    Student s2 = new Student(); // second object ...
    s2.StudentId = "123-45-6789"; // same ID as s1

    Student s3 = new Student(); // third object!
    s3.StudentId = "987-65-4321"; // different ID as s1 and s2

    Console.WriteLine("Is s1 equal to s2?  " + s1.Equals(s2));
    Console.WriteLine("Is s1 equal to s3?  " + s1.Equals(s3));
    Console.WriteLine("Is s1 equal to p?  " + s1.Equals(p));
  }
}

public class Student
{
  // Field.
  private string studentId;

  // Property.
  public string StudentId {
    get { return studentId; }
    set { studentId = value; }
  }

  // Overriding the Equals method.
  public override bool Equals(object obj) {
    // Initialize a flag.
    bool isEqual = false;

    //  Use the as operator to try to cast the object
    //  argument into a Student object. This operator
    //  returns null if the cast was unsuccessful
    Student s = obj as Student;

    //  If the cast Student object reference is not null
    //  and if it has the same StudentId property value
    //  as the current Student object, set the isEqual
    //  flag to be true
    if ( s != null && s.StudentId == this.StudentId ) {
      isEqual = true;
    }

    return isEqual;
  }

  //  If you override Equals, the compiler wants you to
  //  override the GetHashCode method too. If you don't
  //  the compiler will give you a warning.
  public override int GetHashCode() {
     return int.Parse(StudentId);
  }
}

public class Professor
{
  // Field.
  private string name;

}

