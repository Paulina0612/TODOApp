using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TODOApp.Forms
{
    public partial class Main : Form
    {
        private JSONHandler handler;
        private JObject? jobject;

        public Main()
        {
            handler = new JSONHandler();
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            this.tasksDataGridView.Rows.Clear();

            StreamReader r = new StreamReader("tasks.json");
            string json = r.ReadToEnd();
            jobject = JObject.Parse(json);
            int count = jobject.Count;

            if (jobject != null)
            {
                for (int id = 0; id < count; id++)
                {
                    if (jobject[id.ToString()] is not null)
                    {
                        #pragma warning disable CS8602 // Dereference of a possibly null reference.
                        Task? task = JsonConvert.DeserializeObject<Task>(jobject[id.ToString()].ToString());
                        task?.Id = id;
                        #pragma warning restore CS8602 // Dereference of a possibly null reference.


                        if (task != null)
                        {
                            CultureInfo ci = new CultureInfo("en-US");
                            #pragma warning disable CS8604 // Possible null reference argument.
                            this.tasksDataGridView.Rows.Add
                                (
                                    task?.Id,
                                    task?.Name,
                                    task?.Description,
                                    //task?.Status,
                                    this.tasksDataGridView.Columns[2].Selected = task?.Status == true ? true : false,
                                    // TODO: Cross out the task name and description if the task is completed
                                    this.tasksDataGridView.Columns[3].Selected = task?.Priority == true ? true : false,
                                    // TODO: Put priority tasks at the top of the list
                                    // TODO: Change the background color of the task row if the task is a priority task
                                    task?.DueDate?.ToString("MMMM dd yyyy", ci)
                                // TODO: Change the background color of the task row if the task is overdue
                                );
                                #pragma warning restore CS8604 // Possible null reference argument.
                        }
                    }
                }
            }

            r.Close();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }

        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit button column index
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Cell edited: " + e.RowIndex + ", " + e.ColumnIndex);
            }
            else if (e.ColumnIndex == 7)
            {
                if (jobject != null)
                {
                    jobject = handler.RemoveTask(jobject, e.RowIndex);
                    FillData();
                }
                else MessageBox.Show("An error occurred while trying to remove the task.");
            }
        }
    }
}
