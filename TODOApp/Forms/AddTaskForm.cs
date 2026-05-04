using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TODOApp.Forms
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Program.mainForm.FillData();
        }

        private bool CheckIfDataCorrect()
        {
            if (this.taskNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Task name cannot be empty.");
                return false;
            }
            else if (this.taskNameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Task name cannot be longer than 30 characters.");
                return false;
            }
            else if (this.taskDescriptionTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Task description cannot be empty.");
                return false;
            }
            else if (this.taskDescriptionTextBox.Text.Length > 67)
            {
                MessageBox.Show("Task description cannot be longer than 67 characters.");
                return false;
            }
            else if (this.dueDateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("Due date cannot be in the past.");
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CheckIfDataCorrect())
            {
                Task task = new Task()
                {
                    Name = this.taskNameTextBox.Text,
                    Description = this.taskDescriptionTextBox.Text,
                    DueDate = this.dueDateTimePicker.Value,
                    Status = false,
                    Priority = false
                };

                Program.mainForm.AddTask(task);
                this.Close();
            }
        }
    }
}
