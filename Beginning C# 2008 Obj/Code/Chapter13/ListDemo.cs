using System;
using System.Collections.Generic;
using System.Collections;

public class ListDemo {
  static void Main() {

    List<Course> coursesTaken = new List<Course>();
    Console.WriteLine("Initial capacity = "+coursesTaken.Capacity);
    Console.WriteLine("Initial count = "+coursesTaken.Count);

    Course c1 = new Course("Math 101");
    Course c2 = new Course("Physics 250");
    Course c3 = new Course("Management 283");

    coursesTaken.Add(c1);  
    coursesTaken.Add(c2); 
    coursesTaken.Add(c3);

    Course c4 = new Course("Ballroom Dancing");
    coursesTaken.Insert(1,c4);
    //coursesTaken[0] = c1;
    //coursesTaken[1] = c2;
    //coursesTaken[2] = c3;

    // Insert Course object references into the ArrayList, which  
    // treats them as generic Object references.
    //coursesTaken.Add(c1);  
    //coursesTaken.Add(c2); 
    //coursesTaken.Add(c3);
    //Console.WriteLine("New capacity = "+coursesTaken.Capacity);
    //Console.WriteLine("New count = "+coursesTaken.Count);

    //Course[] courses = new Course[3];
    //courses[0] = new Course("Math 101");
    //courses[1] = new Course("Physics 250");
    //courses[2] = new Course("Management 283");
    //List<Course> coursesTaken = new List<Course>(courses);

    Console.WriteLine("New capacity = "+coursesTaken.Capacity);
    Console.WriteLine("New count = "+coursesTaken.Count);

    // Let's now pull them back out! 
    for (int i=0; i < coursesTaken.Count; i++) {
      // Use the indexer to retrieve each element of the ArrayList
      // Cast a generic Object reference back into a Course reference.
      Course c = coursesTaken[i]; 
 
      // We now can invoke the methods of a Course on c.
      Console.WriteLine(c.Name);
    }

    Console.WriteLine("\nUsing foreach\n");

    //  Use foreach loop to iterate through the List.
    foreach ( Course course in coursesTaken ) {
      //course = new Course("Math 101");  //  This line won't compile
      Console.WriteLine(course.Name);
    }

  }
}

public class Course {
  //private string name;

  public Course(String n) {
    Name = n;
  }

  public String Name { get; set;}
}


