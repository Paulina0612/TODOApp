namespace TODOApp.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            addTaskButton = new Button();
            tasksDataGridView = new DataGridView();
            taskName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            dueDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            titleLabel.Location = new Point(24, 33);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(201, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "TODO List";
            // 
            // addTaskButton
            // 
            addTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            addTaskButton.Location = new Point(24, 90);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(168, 39);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "Add A Task";
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // tasksDataGridView
            // 
            tasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksDataGridView.Columns.AddRange(new DataGridViewColumn[] { taskName, Description, Status, Priority, dueDate });
            tasksDataGridView.Location = new Point(24, 135);
            tasksDataGridView.Name = "tasksDataGridView";
            tasksDataGridView.RowHeadersWidth = 51;
            tasksDataGridView.Size = new Size(1230, 456);
            tasksDataGridView.TabIndex = 2;
            // 
            // taskName
            // 
            taskName.HeaderText = "Task";
            taskName.MinimumWidth = 6;
            taskName.Name = "taskName";
            taskName.Width = 350;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 550;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 75;
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.Width = 75;
            // 
            // dueDate
            // 
            dueDate.HeaderText = "Due Date";
            dueDate.MinimumWidth = 6;
            dueDate.Name = "dueDate";
            dueDate.Width = 125;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 629);
            Controls.Add(tasksDataGridView);
            Controls.Add(addTaskButton);
            Controls.Add(titleLabel);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button addTaskButton;
        private DataGridView tasksDataGridView;
        private DataGridViewTextBoxColumn taskName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn dueDate;
    }
}