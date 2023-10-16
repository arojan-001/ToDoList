namespace toDoList.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TaskImportance Importance { get; set; } // Importance level (e.g., low, medium, high)
        public DateTime PlanningDate { get; set; } // Date for planning the task
        public TaskSeverity Severity { get; set; } // Severity level (e.g., low, medium, high)
        public string Description { get; set; } // Task description
        public TaskStatus Status { get; set; } // Task status (enum)
        public DateTime ModifyDate { get; set; } // Date when the task was last modified

        // Constructor to initialize task properties
        public Task()
        {
            // You can set default values here if needed.
            Importance = TaskImportance.Low; // Default: Medium
            PlanningDate = DateTime.Now;
            Severity = TaskSeverity.High; // Default: Medium
            Status = TaskStatus.New; // Default: New
            ModifyDate = DateTime.Now;
        }

        internal static System.Threading.Tasks.Task Delay(int v)
        {
            throw new NotImplementedException();
        }
    }

    // Enum to represent task statuses
    public enum TaskStatus
    {
        New,         // New task
        IsOpen,      // Open but not yet in progress
        InProgress,  // Task is currently in progress
        Done,        // Task is completed
        IsDuplicate, // Duplicate of another task
        Documented   // Task is documented
    }

    // Enum to represent task Importances
    public enum TaskImportance
    {
        Low,       
        Medium,
        High
    }

    // Enum to represent task Severity
    public enum TaskSeverity
    {
        Low,
        Medium,
        High
    }
}
