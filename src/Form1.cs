using System.IO;
namespace todo_app;

public partial class Form1 : Form
{
    private MenuStrip mainMenuStrip;
    public Form1()
    {
        InitializeComponent();
        InitializeMenu();
        addTaskButton.Click += addTaskButton_Click;
        
    }

    private void InitializeMenu()
    {
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

        ToolStripMenuItem deleteTodo = new ToolStripMenuItem("Delete");
        ToolStripMenuItem checkMark = new ToolStripMenuItem("Checkmark");
            // add main menus to menustrip
        mainMenuStrip.Items.Add(fileMenuItem);
        mainMenuStrip.Items.Add(editMenuItem);
            // add sub menus to main menus
        fileMenuItem.DropDownItems.Add(newMenuItem);
        fileMenuItem.DropDownItems.Add(importTodos);
        fileMenuItem.DropDownItems.Add(exportTodos); 

        editMenuItem.DropDownItems.Add(deleteTodo);
        editMenuItem.DropDownItems.Add(checkMark);

        this.Controls.Add(mainMenuStrip);

        // Event handling
        newMenuItem.Click += new EventHandler(newMenuItem_Click);
        importTodos.Click += new EventHandler(importOpenFileDialog_Click);
        exportTodos.Click += new EventHandler(exportSaveFileDialog_Clicl);

        deleteTodo.Click += new EventHandler(deleteTodo_Click);
        checkMark.Click += new EventHandler(checkMark_Click);
    }

    private void newMenuItem_Click(object sender , EventArgs e)
    {
        DialogResult resault = MessageBox.Show("Are you sure? all your todos will be deleted !","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        if(resault == DialogResult.Yes)
        {
            taskTextBox.Clear();
            tasksListBox.Items.Clear();
        }
        
    }


    private void importOpenFileDialog_Click(object sender , EventArgs e)
    {
        DialogResult resault = importOpenFileDialog.ShowDialog();
        if(resault == DialogResult.OK)
        {
            try
            {
                string text = File.ReadAllText(importOpenFileDialog.FileName);
                string[] todos = text.Split("\n");
                foreach(var todo in todos)
                {
                    tasksListBox.Items.Add(todo);
                }
            }
            catch 
            {
                MessageBox.Show("Somthing went wrong !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }


    private void exportSaveFileDialog_Clicl(object sender , EventArgs e)
    {
        DialogResult resault = exportSaveFileDialog.ShowDialog();
        if(resault == DialogResult.OK)
        {
            try
            {
                string[] todos = new string[tasksListBox.Items.Count];

                for(int i=0;i < tasksListBox.Items.Count;i++)
                {
                    todos[i] = tasksListBox.Items[i].ToString();
                }

                // write file
                for(int i=0;i<todos.Length;i++)
                {
                    File.AppendAllText(exportSaveFileDialog.FileName,String.Format("{0}\n",todos[i]));
                }
                
            }
            catch
            {
                MessageBox.Show("Somthing went wrong!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }



    private void deleteTodo_Click(object sender , EventArgs e)
    {
        if(tasksListBox.SelectedItem != null)
        {
            DialogResult resault = MessageBox.Show("Are you sure?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(resault == DialogResult.Yes)
            {
                tasksListBox.Items.Remove(tasksListBox.SelectedItem.ToString());
            }
        }
        else
        {
            MessageBox.Show("Please select a task!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
    }


    private void checkMark_Click(object sender , EventArgs e)
    {
        if(tasksListBox.SelectedItem != null)
        {
            string todo = tasksListBox.Items[tasksListBox.SelectedIndex].ToString();
            if(todo[0] != '✅')
            {
                tasksListBox.Items[tasksListBox.SelectedIndex] = String.Format("✅{0}",tasksListBox.Items[tasksListBox.SelectedIndex]);
            }
            else
            {
                string uncheckemarked_todo = todo.Remove(0,1);
                tasksListBox.Items[tasksListBox.SelectedIndex] = String.Format(uncheckemarked_todo);
            }   
            
        }
        else
        {
            MessageBox.Show("Please select a task!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
    }


    private void addTaskButton_Click(object sender , EventArgs e)
    {
        string taskTitle = taskTextBox.Text;
        if(taskTitle.Length < 1 || String.IsNullOrWhiteSpace(taskTitle))
        {
            MessageBox.Show("Task Title cant be empty!","Invalid title",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }      
        else
        {
            taskTextBox.Clear();
            // add taks to list box 
            tasksListBox.Items.Add(taskTitle);  
        }
            
    }


}
