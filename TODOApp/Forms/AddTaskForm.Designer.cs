namespace TODOApp.Forms
{
    partial class AddTaskForm
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
            taskNameLabel = new Label();
            cancelButton = new Button();
            addButton = new Button();
            taskNameTextBox = new TextBox();
            taskDescriptionTextBox = new TextBox();
            taskDescriptionLabel = new Label();
            taskDueDateLabel = new Label();
            dueDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(201, 54);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "TODO List";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new Point(12, 66);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(80, 20);
            taskNameLabel.TabIndex = 2;
            taskNameLabel.Text = "Task Name";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(529, 165);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(457, 165);
            addButton.Name = "addButton";
            addButton.Size = new Size(66, 29);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(134, 63);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(489, 27);
            taskNameTextBox.TabIndex = 5;
            // 
            // taskDescriptionTextBox
            // 
            taskDescriptionTextBox.Location = new Point(134, 96);
            taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            taskDescriptionTextBox.Size = new Size(489, 27);
            taskDescriptionTextBox.TabIndex = 7;
            // 
            // taskDescriptionLabel
            // 
            taskDescriptionLabel.AutoSize = true;
            taskDescriptionLabel.Location = new Point(12, 99);
            taskDescriptionLabel.Name = "taskDescriptionLabel";
            taskDescriptionLabel.Size = new Size(116, 20);
            taskDescriptionLabel.TabIndex = 6;
            taskDescriptionLabel.Text = "Task Description";
            // 
            // taskDueDateLabel
            // 
            taskDueDateLabel.AutoSize = true;
            taskDueDateLabel.Location = new Point(12, 132);
            taskDueDateLabel.Name = "taskDueDateLabel";
            taskDueDateLabel.Size = new Size(103, 20);
            taskDueDateLabel.TabIndex = 8;
            taskDueDateLabel.Text = "Task Due Date";
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(134, 129);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(324, 27);
            dueDateTimePicker.TabIndex = 9;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 221);
            Controls.Add(dueDateTimePicker);
            Controls.Add(taskDueDateLabel);
            Controls.Add(taskDescriptionTextBox);
            Controls.Add(taskDescriptionLabel);
            Controls.Add(taskNameTextBox);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(taskNameLabel);
            Controls.Add(titleLabel);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label taskNameLabel;
        private Button cancelButton;
        private Button addButton;
        private TextBox taskNameTextBox;
        private TextBox taskDescriptionTextBox;
        private Label taskDescriptionLabel;
        private Label taskDueDateLabel;
        private DateTimePicker dueDateTimePicker;
    }
}