// TestForm3.cs

using System;
using System.Windows.Forms;
using System.Drawing;

public class TestForm3A : Form {

  private Label labelOne;
  private Label labelTwo;
  private Label labelThree;
 
  // Constructor: we "assemble" the GUI here
  public TestForm3A() {
    // Set the size of the Form using the Height
    // and Width properties.
    this.Height = 200;
    this.Width = 200;

    // Add a title to the Form using the Text property.
    this.Text = "Students Enrolled in OBJ101";
    this.BackColor = Color.White;

    // Create left-hand side labels
    int labelVertSpace = 18;
    int labelLeft = 5;

    labelOne = new Label();
    labelOne.Text = "Zachary Palmer (111-11-1111)";
    labelOne.AutoSize = true;
    labelOne.Top = 5;
    labelOne.Left = labelLeft;
    labelOne.TextAlign = ContentAlignment.MiddleLeft;

    labelTwo = new Label();
    labelTwo.Text = "Gerson Lopez (222-22-2222)";
    labelTwo.AutoSize = true;
    labelTwo.Top = labelOne.Top + labelVertSpace;
    labelTwo.Left = labelLeft;
    labelTwo.TextAlign = ContentAlignment.MiddleLeft;

    labelThree = new Label();
    labelThree.Text = "Mary Smith (333-33-3333)";
    labelThree.AutoSize = true;
    labelThree.Top = labelTwo.Top + labelVertSpace;
    labelThree.Left = labelLeft;
    labelThree.TextAlign = ContentAlignment.MiddleLeft;

    // Add the GUI components to the form
    this.Controls.Add(labelOne);
    this.Controls.Add(labelTwo);
    this.Controls.Add(labelThree);

    // Center the Form on the desktop.
    this.StartPosition = FormStartPosition.CenterScreen;
  }

  static void Main() {
    // The Main() method has become quite simple,
    // just call the Run() method.
    Application.Run(new TestForm3A());
  }
}
