using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementLibrary;

namespace ProjectManagementForms.UI {

    /// <summary>
    /// This will show the tasks that have already been created and can estimate the total duration for the project.
    /// Create Task button was removed from UI because the Task Editor is always open in this application.
    /// </summary>
    public partial class ScheduleForm : Form {

        /// <summary>
        /// Task list to be displayed by form.
        /// </summary>
        TaskList taskList;

        /// <summary>
        /// Constructor creates an empty tasklist
        /// </summary>
        public ScheduleForm() {
            InitializeComponent();
            this.taskList = new TaskList();
        }

        /// <summary>
        /// Form loads to display tasks in tasklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleForm_Load(object sender, EventArgs e) {
            lstTasks.DataSource = taskList.Tasks;
            lstTasks.DisplayMember = "TaskName";
        }

        /// <summary>
        /// Instantiates a TaskEditor form to create a task and refreshes to display it in this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTask_Click(object sender, EventArgs e) {
            TaskEditor taskEditor = new TaskEditor(taskList);
            taskEditor.ShowDialog();

            CurrencyManager manager = (CurrencyManager)(lstTasks.BindingContext[taskList.Tasks]);
            manager.Refresh();
        }

        /// <summary>
        /// Shows the duration of the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstTasks.SelectedItem != null) {
                txtTaskEstimation.Text = 
                    // Casts list item as a Task object, and displays duration of task
                    ((ProjectManagementLibrary.Task) lstTasks.SelectedItem).Duration.ToString();
            }
        }

        /// <summary>
        /// Shows the total estimated duration for all tasks in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateEstimatedTime_Click(object sender, EventArgs e) {
            txtTotalEstimatedTime.Text = taskList.TotalEstimatedDuration.ToString();
        }
    }
}
