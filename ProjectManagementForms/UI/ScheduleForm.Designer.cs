namespace ProjectManagementForms.UI {
    partial class ScheduleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCalculateEstimatedTime = new System.Windows.Forms.Button();
            this.txtTotalEstimatedTime = new System.Windows.Forms.TextBox();
            this.txtTaskEstimation = new System.Windows.Forms.TextBox();
            this.lblTotalEstimatedTime = new System.Windows.Forms.Label();
            this.lblTaskEstimation = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateEstimatedTime
            // 
            this.btnCalculateEstimatedTime.Location = new System.Drawing.Point(320, 178);
            this.btnCalculateEstimatedTime.Name = "btnCalculateEstimatedTime";
            this.btnCalculateEstimatedTime.Size = new System.Drawing.Size(109, 56);
            this.btnCalculateEstimatedTime.TabIndex = 20;
            this.btnCalculateEstimatedTime.Text = "Total Estimated Time";
            this.btnCalculateEstimatedTime.UseVisualStyleBackColor = true;
            this.btnCalculateEstimatedTime.Click += new System.EventHandler(this.btnCalculateEstimatedTime_Click);
            // 
            // txtTotalEstimatedTime
            // 
            this.txtTotalEstimatedTime.Location = new System.Drawing.Point(192, 214);
            this.txtTotalEstimatedTime.Name = "txtTotalEstimatedTime";
            this.txtTotalEstimatedTime.ReadOnly = true;
            this.txtTotalEstimatedTime.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEstimatedTime.TabIndex = 19;
            // 
            // txtTaskEstimation
            // 
            this.txtTaskEstimation.Location = new System.Drawing.Point(192, 181);
            this.txtTaskEstimation.Name = "txtTaskEstimation";
            this.txtTaskEstimation.ReadOnly = true;
            this.txtTaskEstimation.Size = new System.Drawing.Size(100, 20);
            this.txtTaskEstimation.TabIndex = 18;
            // 
            // lblTotalEstimatedTime
            // 
            this.lblTotalEstimatedTime.AutoSize = true;
            this.lblTotalEstimatedTime.Location = new System.Drawing.Point(10, 217);
            this.lblTotalEstimatedTime.Name = "lblTotalEstimatedTime";
            this.lblTotalEstimatedTime.Size = new System.Drawing.Size(139, 13);
            this.lblTotalEstimatedTime.TabIndex = 17;
            this.lblTotalEstimatedTime.Text = "Total Estimated Time (mins):";
            // 
            // lblTaskEstimation
            // 
            this.lblTaskEstimation.AutoSize = true;
            this.lblTaskEstimation.Location = new System.Drawing.Point(10, 184);
            this.lblTaskEstimation.Name = "lblTaskEstimation";
            this.lblTaskEstimation.Size = new System.Drawing.Size(160, 13);
            this.lblTaskEstimation.TabIndex = 16;
            this.lblTaskEstimation.Text = "Selected Task Estimation (mins):";
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(13, 44);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(416, 121);
            this.lstTasks.TabIndex = 15;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(10, 14);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(55, 13);
            this.lblSchedule.TabIndex = 14;
            this.lblSchedule.Text = "Schedule:";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(320, 9);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(109, 23);
            this.btnCreateTask.TabIndex = 21;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 247);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.btnCalculateEstimatedTime);
            this.Controls.Add(this.txtTotalEstimatedTime);
            this.Controls.Add(this.txtTaskEstimation);
            this.Controls.Add(this.lblTotalEstimatedTime);
            this.Controls.Add(this.lblTaskEstimation);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.lblSchedule);
            this.Name = "ScheduleForm";
            this.Text = "Schedule Form";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateEstimatedTime;
        private System.Windows.Forms.TextBox txtTotalEstimatedTime;
        private System.Windows.Forms.TextBox txtTaskEstimation;
        private System.Windows.Forms.Label lblTotalEstimatedTime;
        private System.Windows.Forms.Label lblTaskEstimation;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Button btnCreateTask;
    }
}