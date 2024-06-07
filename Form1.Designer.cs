namespace ToDoApp;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private Label label1;
    private TextBox textBoxTask;
    private Button buttonAdd;
    private ListBox listBoxTasks;
    private Button buttonRemove;
    private Button buttonClear;
    private Button buttonMarkCompleted;
    private Button buttonPrint;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new Label();
        this.textBoxTask = new TextBox();
        this.buttonAdd = new Button();
        this.listBoxTasks = new ListBox();
        this.buttonRemove = new Button();
        this.buttonClear = new Button();
        this.buttonMarkCompleted = new Button();
        this.buttonPrint = new Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(15, 11);
        this.label1.Margin = new Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(139, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "Enter New Task :";
        // 
        // textBoxTask
        // 
        this.textBoxTask.Location = new Point(172, 8);
        this.textBoxTask.Margin = new Padding(4);
        this.textBoxTask.Name = "textBoxTask";
        this.textBoxTask.Size = new Size(322, 31);
        this.textBoxTask.TabIndex = 1;
        // 
        // buttonAdd
        // 
        this.buttonAdd.Location = new Point(502, 8);
        this.buttonAdd.Margin = new Padding(4);
        this.buttonAdd.Name = "buttonAdd";
        this.buttonAdd.Size = new Size(118, 36);
        this.buttonAdd.TabIndex = 2;
        this.buttonAdd.Text = "Add Task";
        this.buttonAdd.UseVisualStyleBackColor = true;
        this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
        // 
        // listBoxTasks
        // 
        this.listBoxTasks.FormattingEnabled = true;
        this.listBoxTasks.ItemHeight = 25;
        this.listBoxTasks.Location = new Point(15, 56);
        this.listBoxTasks.Margin = new Padding(4);
        this.listBoxTasks.Name = "listBoxTasks";
        this.listBoxTasks.Size = new Size(604, 229);
        this.listBoxTasks.TabIndex = 3;
        // 
        // buttonRemove
        // 
        this.buttonRemove.Location = new Point(15, 294);
        this.buttonRemove.Margin = new Padding(4);
        this.buttonRemove.Name = "buttonRemove";
        this.buttonRemove.Size = new Size(138, 36);
        this.buttonRemove.TabIndex = 4;
        this.buttonRemove.Text = "Remove Task";
        this.buttonRemove.UseVisualStyleBackColor = true;
        this.buttonRemove.Click += new EventHandler(this.buttonRemove_Click);
        // 
        // buttonClear
        // 
        this.buttonClear.Location = new Point(160, 294);
        this.buttonClear.Margin = new Padding(4);
        this.buttonClear.Name = "buttonClear";
        this.buttonClear.Size = new Size(138, 36);
        this.buttonClear.TabIndex = 5;
        this.buttonClear.Text = "Clear Tasks";
        this.buttonClear.UseVisualStyleBackColor = true;
        this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
        // 
        // buttonMarkCompleted
        // 
        this.buttonMarkCompleted.Location = new Point(306, 294);
        this.buttonMarkCompleted.Margin = new Padding(4);
        this.buttonMarkCompleted.Name = "buttonMarkCompleted";
        this.buttonMarkCompleted.Size = new Size(152, 36);
        this.buttonMarkCompleted.TabIndex = 6;
        this.buttonMarkCompleted.Text = "Mark Completed";
        this.buttonMarkCompleted.UseVisualStyleBackColor = true;
        this.buttonMarkCompleted.Click += new EventHandler(this.buttonMarkCompleted_Click);
        // 
        // buttonPrint
        // 
        this.buttonPrint.Location = new Point(466, 294);
        this.buttonPrint.Margin = new Padding(4);
        this.buttonPrint.Name = "buttonPrint";
        this.buttonPrint.Size = new Size(152, 36);
        this.buttonPrint.TabIndex = 7;
        this.buttonPrint.Text = "Print Tasks";
        this.buttonPrint.UseVisualStyleBackColor = true;
        this.buttonPrint.Click += new EventHandler(this.buttonPrint_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(635, 345);
        this.Controls.Add(this.buttonPrint);
        this.Controls.Add(this.buttonMarkCompleted);
        this.Controls.Add(this.buttonClear);
        this.Controls.Add(this.buttonRemove);
        this.Controls.Add(this.listBoxTasks);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.textBoxTask);
        this.Controls.Add(this.label1);
        this.Margin = new Padding(4);
        this.Name = "Form1";
        this.Text = "ToDo App";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
