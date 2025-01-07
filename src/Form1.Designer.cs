using System.Drawing.Design;
using System.Net;

namespace todo_app;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(360, 455);
        this.Text = "TodoApp";
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.Fixed3D;
        this.BackColor = Color.White;
        // this.Icon = new Icon(@""); // set icon path (.ico)
        this.MainMenuStrip = mainMenuStrip;
        


        // Define control properties and Locations

        addTaskButton = new Button
        {
            Text = "Add",
            BackColor = Color.LightBlue,
            // Size = new Size(5,2),
            Location = new Point(255,48)
        };

        textBoxLabel = new Label
        {
            Text = "Title:",
            Location = new Point(3,25)
        };

        taskTextBox = new TextBox
        {
            Size = new Size(250,0),
            Location = new Point(3,48)
        };

        listBoxLabel = new Label
        {
            Text = "Tasks:",
            Location = new Point(3,82)
        };

        line = new Panel
        {
            BorderStyle = BorderStyle.FixedSingle,
            Height = 2,
            Width = this.Width,
            Location = new Point(0,75)
        };

        tasksListBox = new ListBox
        {
            Size = new Size(354,349),
            Location = new Point(3,105)
        };

        importOpenFileDialog = new OpenFileDialog
        {
            Title = "Select a text file",
            Filter = "Text files (*.txt)|*.txt"
        };
        
        exportSaveFileDialog = new SaveFileDialog
        {
            Title = "Pick a name",
            Filter = "Text files (*.txt)|*.txt"
        };


        // Add controls to main Form
        this.Controls.Add(addTaskButton);
        this.Controls.Add(textBoxLabel);
        this.Controls.Add(taskTextBox);
        this.Controls.Add(listBoxLabel);
        this.Controls.Add(line);
        this.Controls.Add(tasksListBox);
    }



    #endregion


private Button addTaskButton;
private ListBox tasksListBox;
private TextBox taskTextBox;
// Labels
private Label listBoxLabel;
private Label textBoxLabel;
private Panel line;
private OpenFileDialog importOpenFileDialog;
private SaveFileDialog exportSaveFileDialog;
}
