using System;
using System.Windows.Forms;
using System.Drawing;

public class PushMe : Form {

  Button pushMeButton;

  public PushMe() {

    // Create Button
    pushMeButton = new Button(); 
    pushMeButton.Text = "Push Me";
    pushMeButton.Height = 60;
    pushMeButton.Width = 80;
    pushMeButton.Top = 60;
    pushMeButton.Left = 60;

    // Assign an event handler to the Button
    //pushMeButton.Click += new EventHandler(ButtonClicked);
    pushMeButton.Click += ButtonClicked;

    // Add the Button to the Form
    this.Controls.Add(pushMeButton);

    // Size the Form and make it visible
    this.Height = 200;
    this.Width = 200;
    this.StartPosition = FormStartPosition.CenterScreen;
  }

  // event handling method for the "Push Me" Button
  public void ButtonClicked(object source, EventArgs e) {
    if ( pushMeButton.Text == "Push Me" ) {
      pushMeButton.Text = "Ouch";
    }
    else {
      pushMeButton.Text = "Push Me";
    }
  }

  static void Main() {
    Application.Run(new PushMe());
  }
}
