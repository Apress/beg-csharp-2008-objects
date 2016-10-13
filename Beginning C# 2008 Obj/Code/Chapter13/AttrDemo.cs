using System;

public class AttrDemo {

  // We're adding an attribute to OldMethod()
  [Obsolete()]
  public void OldMethod() {
    // do some obsolete stuff
  }

  public static void Main(String[] args) {
    AttrDemo ad = new AttrDemo();
    // we're trying to call a method that has been
    // tagged as obsolete
    ad.OldMethod();
  }
}

