// InvalidStudentIdException.cs

using System;

public class InvalidStudentIdException : Exception {

  //  This message will be assigned to the Message property
  //  of the InvalidStudentIdException. It's declared to be
  //  a const (and therefore static) string.
  const string baseMessage = "Error: Invalid student ID: ";

  // The constructors call the Exception constructor
  // changing the default Message property of the 
  // Exception class.

  //  Zero-parameter constructor assigns baseMessage to Message
  public InvalidStudentIdException() : base(baseMessage) {
  }

  //  One-parameter constructor adds the invalid Student ID.
  public InvalidStudentIdException(string id) : base(baseMessage+id) {
  }

}



