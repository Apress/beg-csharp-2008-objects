// TestForm2.cs

using System;
using System.Windows.Forms;
using System.Drawing;

public class TestForm2 {
  static void Main() {
    // Create a Form.
    Form simpleForm = new Form();

    // Set the size of the Form using the Height.
    // and Width properties
    simpleForm.Height = 300;
    simpleForm.Width = 300;

    // Set the title to the Form using the Text property.
    simpleForm.Text = "Whee!!!";

    // Center the Form on the Desktop.
    simpleForm.StartPosition = FormStartPosition.CenterScreen;

    // Use the Application class Run() method to launch
    // the Form
    Application.Run(simpleForm);
  }
}
