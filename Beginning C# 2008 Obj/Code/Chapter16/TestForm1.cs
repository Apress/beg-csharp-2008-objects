// TestForm1.cs

using System;
using System.Windows.Forms;
using System.Drawing;

public class TestForm1 {
  static void Main() {
    // Create a Form.
    Form simpleForm = new Form();

    // Set the size of the Form using the Height.
    // and Width properties
    simpleForm.Height = 300;
    simpleForm.Width = 300;

    // Set the title to the Form using the Text property.
    simpleForm.Text = "Whee!!!";

    // Use the Application class Run() method to launch
    // the Form
    Application.Run(simpleForm);
  }
}
