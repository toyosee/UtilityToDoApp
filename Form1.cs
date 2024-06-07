using System;
using System.IO;
using System.Windows.Forms;

namespace ToDoApp;

public partial class Form1 : Form
{
    private const string FilePath = "tasks.txt";

    public Form1()
    {
        InitializeComponent();
        LoadTasksFromFile();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string taskDescription = textBoxTask.Text.Trim();
        if (!string.IsNullOrEmpty(taskDescription))
        {
            Task task = new Task(taskDescription);
            listBoxTasks.Items.Add(task);
            textBoxTask.Clear();
            textBoxTask.Focus();
            SaveTasksToFile();
        }
        else
        {
            MessageBox.Show("Please enter a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (listBoxTasks.SelectedIndex != -1)
        {
            listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            SaveTasksToFile();
        }
        else
        {
            MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
        listBoxTasks.Items.Clear();
        SaveTasksToFile();
    }

    private void buttonMarkCompleted_Click(object sender, EventArgs e)
    {
        if (listBoxTasks.SelectedItem is Task task)
        {
            task.CompletionDate = DateTime.Now;
            int selectedIndex = listBoxTasks.SelectedIndex;
            listBoxTasks.Items[selectedIndex] = task;
            SaveTasksToFile();
        }
        else
        {
            MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonPrint_Click(object sender, EventArgs e)
    {
        if (File.Exists(FilePath))
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                Verb = "print",
                FileName = FilePath
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }
        else
        {
            MessageBox.Show("No tasks to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadTasksFromFile()
    {
        if (File.Exists(FilePath))
        {
            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    var description = parts[0];
                    var creationDateString = parts[1];
                    var completionDateString = parts[2];
                    DateTime creationDate;
                    DateTime? completionDate = null;

                    // Parse creation date
                    if (DateTime.TryParse(creationDateString, out creationDate))
                    {
                        // Parse completion date if not "null"
                        if (completionDateString != "null" && DateTime.TryParse(completionDateString, out DateTime tempCompletionDate))
                        {
                            completionDate = tempCompletionDate;
                        }

                        var task = new Task(description)
                        {
                            CreationDate = creationDate,
                            CompletionDate = completionDate
                        };
                        listBoxTasks.Items.Add(task);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid date format for task: {description}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    private void SaveTasksToFile()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (Task task in listBoxTasks.Items)
            {
                string completionDate = task.CompletionDate.HasValue ? $"Completed on: {task.CompletionDate.Value}" : "PENDING";
                writer.WriteLine($"{task.Description}|{task.CreationDate}|{completionDate}");
            }
        }
    }

}
