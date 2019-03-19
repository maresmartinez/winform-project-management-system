namespace ProjectManagementForms.UI {
    partial class TaskEditor {
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.ckHighRisk = new System.Windows.Forms.CheckBox();
            this.cbTaskType = new System.Windows.Forms.ComboBox();
            this.txtTaskDuration = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskDuration = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(139, 159);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(125, 23);
            this.btnCreateTask.TabIndex = 25;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // ckHighRisk
            // 
            this.ckHighRisk.AutoSize = true;
            this.ckHighRisk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckHighRisk.Location = new System.Drawing.Point(322, 122);
            this.ckHighRisk.Name = "ckHighRisk";
            this.ckHighRisk.Size = new System.Drawing.Size(72, 17);
            this.ckHighRisk.TabIndex = 24;
            this.ckHighRisk.Text = "High Risk";
            this.ckHighRisk.UseVisualStyleBackColor = true;
            // 
            // cbTaskType
            // 
            this.cbTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskType.FormattingEnabled = true;
            this.cbTaskType.Location = new System.Drawing.Point(139, 80);
            this.cbTaskType.Name = "cbTaskType";
            this.cbTaskType.Size = new System.Drawing.Size(255, 21);
            this.cbTaskType.TabIndex = 23;
            // 
            // txtTaskDuration
            // 
            this.txtTaskDuration.Location = new System.Drawing.Point(139, 120);
            this.txtTaskDuration.Name = "txtTaskDuration";
            this.txtTaskDuration.Size = new System.Drawing.Size(163, 20);
            this.txtTaskDuration.TabIndex = 22;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(139, 13);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(255, 49);
            this.txtTaskDescription.TabIndex = 21;
            // 
            // lblTaskDuration
            // 
            this.lblTaskDuration.AutoSize = true;
            this.lblTaskDuration.Location = new System.Drawing.Point(11, 123);
            this.lblTaskDuration.Name = "lblTaskDuration";
            this.lblTaskDuration.Size = new System.Drawing.Size(107, 13);
            this.lblTaskDuration.TabIndex = 20;
            this.lblTaskDuration.Text = "Task Duration (mins):";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(11, 83);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(61, 13);
            this.lblTaskType.TabIndex = 19;
            this.lblTaskType.Text = "Task Type:";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(11, 16);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(90, 13);
            this.lblTaskDescription.TabIndex = 18;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.ckHighRisk);
            this.Controls.Add(this.cbTaskType);
            this.Controls.Add(this.txtTaskDuration);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblTaskDuration);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblTaskDescription);
            this.Name = "TaskEditor";
            this.Text = "Task Editor";
            this.Load += new System.EventHandler(this.TaskEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.CheckBox ckHighRisk;
        private System.Windows.Forms.ComboBox cbTaskType;
        private System.Windows.Forms.TextBox txtTaskDuration;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTaskDuration;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnCancel;
    }
}