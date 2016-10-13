namespace PetStore
{
  public class Tarantula {
    // Field.
    private string name;

    // Constructor.
    public Tarantula(string n) {
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



