using System;

public class Teacher
{
  public static void Main() {
    Professor p = new Professor();
    ITeacher t;
    IAdministrator a;
    t = p;  // We store a handle on the Professor in a reference variable of
            // type Teacher! 
    a = p;  // We store a handle on the Professor in a reference variable of

    ITeacher i = new Professor();
  }
}

internal interface ITeacher
{
  void AgreeToTeach(Course c);
  void DesignateTextbook(TextBook b, Course c);
  Syllabus DefineSyllabus(Course c);
  bool ApproveEnrollment(Student s, Course c);
}

public interface IAdministrator
{
  bool ApproveNewCourse(Course c);
}

public class Professor : ITeacher,IAdministrator {
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

  // But, we've failed to provide an implementation of the
  // approveEnrollment() method!
  public bool ApproveEnrollment(Student s, Course c) {
    return true;
  }

  public bool ApproveNewCourse(Course c) {
    return true;
  }
}


public class Course {}
public class TextBook {}
public class Student {}
public class Syllabus {}

