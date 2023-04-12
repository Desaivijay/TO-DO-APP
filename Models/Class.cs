namespace TO_DO_APP.Models
{
    public class TodoItem
    {
        public int Id { get; set; } // Unique identifier for the to-do item
        public string? Title { get; set; } // Title of the to-do item
        public bool IsCompleted { get; set; } // Status of the to-do item (completed or not)
    }
}
   
