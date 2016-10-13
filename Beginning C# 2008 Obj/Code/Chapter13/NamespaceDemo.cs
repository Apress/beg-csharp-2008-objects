using System;
using PetStore;

//  Compile command is:
//
//  csc NamespaceDemo.cs PetStore\PetRat.cs PetStore\Tarantula.cs

public class NamespaceDemo {
  static int Main() {
    PetRat bailey = new PetRat("Bailey");
    Console.WriteLine("name is "+bailey.Name);

    Tarantula elvis = new Tarantula("Elvis");
    Console.WriteLine("name is "+elvis.Name);

    return 0;
  }
}
