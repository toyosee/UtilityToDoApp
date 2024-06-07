namespace ToDoApp;

public class Task
{
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? CompletionDate { get; set; }

    public Task(string description)
    {
        Description = description;
        CreationDate = DateTime.Now;
        CompletionDate = null;
    }

    public override string ToString()
    {
        string status = CompletionDate.HasValue ? $" (Completed on: {CompletionDate.Value})" : " (Pending)";
        return $"{Description} (Created on: {CreationDate}){status}";
    }
}
