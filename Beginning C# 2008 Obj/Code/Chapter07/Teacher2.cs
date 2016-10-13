using System;

public interface ITeacher
{
  void AgreeToTeach(Course c);
  void DesignateTextbook(TextBook b, Course c);
  Syllabus DefineSyllabus(Course c);
  bool ApproveEnrollment(Student s, Course c);
}

public class Professor : Student,ITeacher {
  String name;
  String employeeId;
  // etc. 

  // Get/set methods omitted.
 
  // We override three of the four method signatures called for by the
  // Teacher interface, to provide method bodies.

  public void AgreeToTeach(Course c) {
    // Logic for the method body goes here; details omitted. 
  }

  public virtual void DesignateTextbook(TextBook b, Course c) {
    // Logic for the method body goes here; details omitted.
  }

  public Syllabus DefineSyllabus(Course c) { 
    // Logic for the method body goes here; details omitted.  
    return new Syllabus();
  }

  // Now we provide an implementation of the approveEnrollment() method
  public bool ApproveEnrollment(Student s, Course c) {
    return true;
  }

  public static void Main() {
    Professor p = new Professor();
  }
}


public class Course {}
public class TextBook {}
public class Student {}
public class Syllabus {}

