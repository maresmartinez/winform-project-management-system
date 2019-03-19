using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLibrary {

    /// <summary>
    /// Holds information about a task in a project. High risk projects are of more importance than regular tasks.
    /// </summary>
    public class HighRiskTask : Task {

        /// <summary>
        /// Constructor for task.
        /// </summary>
        /// <param name="taskName">Name of task</param>
        /// <param name="taskType">Type of task</param>
        /// <param name="duration">How long task should take (in minutes)</param>
        public HighRiskTask(string taskName, TaskType taskType, double duration)
                : base(taskName + " (high risk)", taskType, duration) {
        }

        /// <summary>
        /// Calculates the estimated duration in minutes based on type of task.
        /// </summary>
        /// <returns>The amount of time (in minutes) that the task should take. It is double the amount 
        /// of the base class because this is high risk.</returns>
        public override double calculateEstimatedDuration() {
            return base.calculateEstimatedDuration() * 2;
        }

    }
}
