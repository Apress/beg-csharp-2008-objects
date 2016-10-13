using System;

public class EqualsTest {
  static void Main() {
    // We'll create one Person object ...
    Person p1 = new Person("222-22-2222", "Fred");

    // ... and maintain two handles on it (p1 and p2).
    Person p2 = p1;

    // We'll create a second different Person object with exactly the same
    // attribute values as the first Person object that we created, and will
    // use variable p3 to maintain a handle on this second object.
    Person p3 = new Person("222-22-2222", "Fred");

if (p1 == p2) Console.WriteLine("p1 == p2 is true");
if (p1.Equals(p2)) Console.WriteLine("p1.equals(p2) is true");

if (p1 == p3) Console.WriteLine("p1 == p3 is true");
if (p1.Equals(p3)) Console.WriteLine("p1.equals(p3) is true");

    char[] c = {'b','o','o'};
    String s1 = new String(c);
    String s2 = s1;
    String s3 = new String(c);

    if (s1 == s2) Console.WriteLine("s1 == s2 is true");
    if (s1.Equals(s2)) Console.WriteLine("s1.equals(s2) is true");

    if (s1 == s3) Console.WriteLine("s1 == s3 is true");
    if (s1.Equals(s3)) Console.WriteLine("s1.equals(s3) is true");

  }
}

public class Person {
  String name, id;

  public Person(String n, String s) {
    name = n;
    id = s;
  }

  public String GetName() { return name; }
  public void SetName(String name) { this.name = name; }
}

