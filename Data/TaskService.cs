namespace toDoList.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TaskService
    {
        private List<Task> tasks;

        public TaskService()
        {
            // Initialize the task list
            tasks = new List<Task>();
            // Add some sample tasks for testing
            AddSampleTasks();
        }

        public List<Task> GetTasks()
        {
            // Return a list of tasks
            return tasks;
        }

        public void AddTask(Task newTask)
        {
            // Generate a unique ID for the new task
            newTask.Id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;

            // Set the modification date to the current date
            newTask.ModifyDate = DateTime.Now;

            // Add the new task to the list
            tasks.Add(newTask);
        }

        public void UpdateTask(Task updatedTask)
        {
            // Find the task in the list by ID
            var existingTask = tasks.FirstOrDefault(t => t.Id == updatedTask.Id);

            if (existingTask != null)
            {
                // Update task properties
                existingTask.Title = updatedTask.Title;
                existingTask.Importance = updatedTask.Importance;
                existingTask.PlanningDate = updatedTask.PlanningDate;
                existingTask.Severity = updatedTask.Severity;
                existingTask.Description = updatedTask.Description;
                existingTask.Status = updatedTask.Status;
                existingTask.ModifyDate = DateTime.Now;
            }
        }

        public void DeleteTask(int taskId)
        {
            // Remove the task from the list by ID
            tasks.RemoveAll(t => t.Id == taskId);
        }
        private void AddSampleTasks()
        {
            var sampleTasks = new List<Task>
        {
            new Task
            {   Id = 1,
                Title = "Task 1",
                Importance = TaskImportance.Low, 
                PlanningDate = DateTime.Now.Date,
                Severity = TaskSeverity.High, 
                Description = "Sample task 1 description",
                Status = TaskStatus.Documented,
                ModifyDate = DateTime.Now
            },
            new Task
            {   Id = 2,
                Title = "Task 2",
                Importance = TaskImportance.Low, 
                PlanningDate = DateTime.Now.Date.AddDays(1),
                Severity = TaskSeverity.High,
                Description = "Sample task 2 description",
                Status = TaskStatus.InProgress,
                ModifyDate = DateTime.Now
            },
            new Task
            {   Id = 3,
                Title = "Task 3",
                Importance = TaskImportance.Low, 
                PlanningDate = DateTime.Now.Date.AddDays(2),
                Severity = TaskSeverity.High,
                Description = "Sample task 3 description",
                Status = TaskStatus.Done,
                ModifyDate = DateTime.Now
            }
        };

            tasks.AddRange(sampleTasks);
        }
    }
}
