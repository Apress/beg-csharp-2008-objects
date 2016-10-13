using System;
using System.Windows.Forms;
using System.Drawing;

public class PushMe2 : Form {

  Button pushMeButton;

  public PushMe2() {

    // Create Button
    pushMeButton = new Button(); 
    pushMeButton.Text = "Push Me";
    pushMeButton.Height = 60;
    pushMeButton.Width = 80;
    pushMeButton.Top = 60;
    pushMeButton.Left = 60;

    // Assign an event handler to the Button
    pushMeButton.Click += delegate(object source, EventArgs e) {
      if ( pushMeButton.Text == "Push Me" ) {
        pushMeButton.Text = "Ouch";
      }
      else {
        pushMeButton.Text = "Push Me";
      }
    };

    // Add the Button to the Form
    this.Controls.Add(pushMeButton);

    // Size the Form and make it visible
    this.Height = 200;
    this.Width = 200;
    this.StartPosition = FormStartPosition.CenterScreen;
  }

  static void Main() {
    Application.Run(new PushMe2());
  }
}
