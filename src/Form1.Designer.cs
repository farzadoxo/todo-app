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
        this.Icon = new Icon(@"C:\Users\Farzad\Desktop\todo-app\src\assets\form-icon.ico"); // set icon path (.ico)
        this.MainMenuStrip = mainMenuStrip;
        


        // Define control properties and Locations

        mainMenuStrip = new MenuStrip
        {
            BackColor = ColorTranslator.FromHtml("#f8f8f8")
        };
            // main menus
        ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");
        ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Edit");
            // sub menus
        ToolStripMenuItem newMenuItem = new ToolStripMenuItem("New");
        ToolStripMenuItem importTodos = new ToolStripMenuItem("Import");
        ToolStripMenuItem exportTodos = new ToolStripMenuItem("Export");
            // add main menus to menustrip
        mainMenuStrip.Items.Add(fileMenuItem);
        mainMenuStrip.Items.Add(editMenuItem);
            // add sub menus to main menus
        fileMenuItem.DropDownItems.Add(newMenuItem);
        fileMenuItem.DropDownItems.Add(importTodos);
        fileMenuItem.DropDownItems.Add(exportTodos);    




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


        // Add controls to main Form
        this.Controls.Add(addTaskButton);
        this.Controls.Add(textBoxLabel);
        this.Controls.Add(mainMenuStrip);
        this.Controls.Add(taskTextBox);
        this.Controls.Add(listBoxLabel);
        this.Controls.Add(line);
        this.Controls.Add(tasksListBox);
    }



    #endregion


private MenuStrip mainMenuStrip;
private Button addTaskButton;
private ListBox tasksListBox;
private TextBox taskTextBox;
// Labels
private Label listBoxLabel;
private Label textBoxLabel;
private Panel line;
}
