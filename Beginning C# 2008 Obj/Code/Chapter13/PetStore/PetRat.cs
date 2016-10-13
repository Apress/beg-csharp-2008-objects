namespace PetStore
{
  public class PetRat {
    // Field.
    private string name;

    // Constructor.
    public PetRat(string n) {
      name = n;
    }

    // Property.
    public string Name {
      get {
        return name;
      }
      set {
        name = value;
      }    
    }
  }
}



