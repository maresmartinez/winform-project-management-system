using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectManagementLibrary {

    /// <summary>
    /// Holds the logic and information of a group of tasks.
    /// </summary>
    public class TaskList {

        /// <summary>
        /// Used to access and manage the task list.
        /// </summary>
        public List<Task> Tasks { get; private set; }

        /// <summary>
        /// Default constructor creates an empty taskList
        /// </summary>
        public TaskList() {
            Tasks = new List<Task>();
        }

        /// <summary>
        /// Constructor takes in a tasklist.
        /// </summary>
        /// <param name="taskList"></param>
        public TaskList(List<Task> taskList) {
            Tasks = taskList;
        }

        /// <summary>
        /// Calculates the total estimated duration of all tasks in the list.
        /// </summary>
        public double TotalEstimatedDuration {
            get {
                double total = 0;
                foreach (Task task in Tasks) {
                    total += task.calculateEstimatedDuration();
                }
                return total;
            }
        }

        /// <summary>
        /// Adds a task to the task list.
        /// The task object taken in as a paramater will be copied, so the list will
        /// reference a different object.
        /// </summary>
        /// <param name="task">The task information to be added to the list</param>
        public void AddNewTask(Task task) {
            // Changed from Assignment 2 Part 1
            Tasks.Add(new Task(task.TaskName, task.TaskType, task.Duration));
        }

        /// <summary>
        /// Removes task from task list
        /// </summary>
        /// <param name="taskName">Name of task to be removed</param>
        public void RemoveTask(string taskName) {
            Tasks.Remove(SearchTaskByName(taskName));
        }

        /// <summary>
        /// Searches the task list for a task with a specific name.
        /// </summary>
        /// <param name="taskName">Name of task to be returned</param>
        /// <returns>Either task object with same task name, or null.</returns>
        public Task SearchTaskByName(string taskName) {
            foreach (Task task in Tasks) {
                if (task.TaskName.Equals(taskName)) {
                    return task;
                }
            }
            return null;
        }

    }
}
