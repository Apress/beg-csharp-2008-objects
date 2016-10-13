public abstract class Course {
  private string courseName;
  // etc.

  // Other details omitted.
 
  public abstract void EstablishCourseSchedule (string startDate, 
                                                string endDate);
}


// Deriving a class from an abstract base class.
public class LectureCourse : Course {
  // Details omitted.

  // Override the abstract method with a concrete method.
  public override void EstablishCourseSchedule(string startDate, string endDate) {
    // Logic specific to the business rules for a LectureCourse … details omitted.
  }

}

