using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLibrary {

    /// <summary>
    /// Holds information about a task in a project.
    /// </summary>
    public class Task {

        /// <summary>
        /// Name of task
        /// </summary>
        private string taskName;

        /// <summary>
        /// Type of task
        /// </summary>
        private TaskType taskType;

        /// <summary>
        /// How long the task should take (in minutes)
        /// </summary>
        private double duration;

        /// <summary>
        /// Name of task. Ensures that task name has a value.
        /// </summary>
        public string TaskName {
            get { return taskName; }
            set {
                if (!String.IsNullOrEmpty(value)) {
                    taskName = value;
                } else {
                    throw new Exception("TaskName cannot be empty");
                }
            }
        }

        /// <summary>
        /// Type of task. 
        /// </summary>
        public TaskType TaskType {
            get {
                return taskType;
            }
            private set {
                taskType = value;
            }
        }

        /// <summary>
        /// How long task should take (in minutes). Ensures that duration is a positive value, and not zero.
        /// </summary>
        public double Duration {
            get { return duration; }
            set {
                if (value > 0) {
                    duration = value;
                } else {
                    throw new Exception("Duration must be greater than 0");
                }
            }
        }

        /// <summary>
        /// Constructor for task.
        /// </summary>
        /// <param name="taskName">Name of task</param>
        /// <param name="taskType">Type of task</param>
        /// <param name="duration">How long task should take (in minutes)</param>
        public Task(string taskName, TaskType taskType, double duration) {
            TaskName = taskName;
            TaskType = taskType;
            Duration = duration;
        }

        /// <summary>
        /// Calculates the estimated duration in minutes based on type of task.
        /// </summary>
        /// <returns>The amount of time (in minutes) that the task should take.</returns>
        public virtual double calculateEstimatedDuration() {
            switch (taskType) {
                // Research tasks 100% longer than duration
                case TaskType.RESEARCH:
                    return duration * 2;

                // Requirements and Design take 20% longer than duration
                case TaskType.REQUIREMENTS:
                case TaskType.DESIGN:
                    return duration * 1.2;

                // Implementation takes 50% longer than duration
                case TaskType.IMPLEMENTATION:
                    return duration * 1.5;

                // Testing takes 10% longer than duration
                case TaskType.TESTING:
                    return duration * 1.1;

                // Used for cases when duration is as expected
                default:
                    return duration;
            }
        }

    }
}
