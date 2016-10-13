using System;
using System.Collections;

public class ArrayListDemo
{
  public static void Main() {
    ArrayList list = new ArrayList();
    Student s1 = new Student("Frank");
    Student s2 = new Student("Rameesh");

    list.Add(s1);
    list.Add(s2);

    //  Must cast list element to a Student.
    Student s3 = (Student)list[1];
    Console.WriteLine("name = "+s3.Name);
  }
}


