// Student.cs

public class Student {

  // Constructor
  public Student(string id) {
    // Test to see if the string passed to the constructor
    // has 11 characters. If the string doesn't, it doesn't
    // represent a proper student ID and an 
    // InvalidStudentIdException is thrown.
    if ( id.Length != 11 ) {
      throw new InvalidStudentIdException(id);
    }

    // If the string passed to the constructor has 11 
    // characters, assign the Id property to it.
    Id = id;
  }

  // Declare an auto-implemented property representing a student ID.
  public string Id { get; set; }
}



