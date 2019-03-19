using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementLibrary;

namespace ProjectManagementForms.UI {

    /// <summary>
    /// Creates a task from valid form input and adds it to a task list.
    /// </summary>
    public partial class TaskEditor : Form {

        /// <summary>
        /// Task list which holds all task information and logic.
        /// </summary>
        TaskList taskList;

        /// <summary>
        /// Constructor takes in a taskList to add to.
        /// </summary>
        /// <param name="taskList"></param>
        public TaskEditor(TaskList taskList) {
            InitializeComponent();
            this.taskList = taskList;
        }

        /// <summary>
        /// When the form is loaded the dropdown list is populated with all task types.
        /// A schedule form is also instantiated which shares the tasklist from this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskEditor_Load(object sender, EventArgs e) {
            foreach (TaskType taskType in Enum.GetValues(typeof(TaskType))) {
                cbTaskType.Items.Add(taskType);
            }
        }

        /// <summary>
        /// Validated the input for form elements then creates a task if inputs are valid. 
        /// Task is then added to the task list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTask_Click(object sender, EventArgs e) {
            string errors = ""; // Keeps track of errors for form inputs

            // Get form inputs

            // Ensure description has a value
            string description = txtTaskDescription.Text;
            if (String.IsNullOrEmpty(description)) {
                errors += "Description must have a value.\n";
            }

            // Ensure task type was selected
            string txtTaskType = cbTaskType.Text;
            TaskType taskType = 0;
            if (String.IsNullOrEmpty(description)) {
                errors += "Please select a task type.\n";
            } else {
                taskType = (TaskType)Enum.Parse(typeof(TaskType), txtTaskType);
            }

            // Ensure duration has value that is a number
            string txtDuration = txtTaskDuration.Text;
            double duration = 0;
            Regex regNumOnly = new Regex(@"^\d*\.?\d+$"); // regex for whole or decimal number
            if (String.IsNullOrEmpty(txtDuration)) {
                errors += "Duration must have a value.\n";
            } else if (!regNumOnly.IsMatch(txtDuration)) {
                errors += "Duration must contain either a whole or decimal number.\n";
            } else {
                duration = double.Parse(txtDuration);
            }

            // Retrieve checkbox selection
            bool highRisk = ckHighRisk.Checked;

            // Show errors if they occured, if so exit method
            if (!String.IsNullOrEmpty(errors)) {
                MessageBox.Show(errors);
                return;
            }

            // Add task to list
            ProjectManagementLibrary.Task task;
            if (highRisk) {
                task = new HighRiskTask(description, taskType, duration);
            } else {
                task = new ProjectManagementLibrary.Task(description, taskType, duration);
            }
            taskList.AddNewTask(task);

            MessageBox.Show("Task has been added.");
            clearAllFormElements();

            Close();
        }

        /// <summary>
        /// Clears the input for all form elements on the window.
        /// </summary>
        private void clearAllFormElements() {
            txtTaskDescription.Clear();
            cbTaskType.SelectedIndex = -1;
            txtTaskDuration.Clear();
            ckHighRisk.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
