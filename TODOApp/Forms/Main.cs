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
        public Main()
        {
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            this.tasksDataGridView.Rows.Clear();

            StreamReader r = new StreamReader("tasks.json");
            string json = r.ReadToEnd();
            var jobject = JObject.Parse(json);
            int count = jobject.Count;

            if (jobject != null)
            {
                for (int id = 0; id < count; id++)
                {
                    if (jobject[id.ToString()] is not null)
                    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        Task? task = JsonConvert.DeserializeObject<Task>(jobject[id.ToString()].ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.


                        if (task != null)
                        {
                            CultureInfo ci = new CultureInfo("en-US");
#pragma warning disable CS8604 // Possible null reference argument.
                            this.tasksDataGridView.Rows.Add
                                (
                                    task?.Name,
                                    task?.Description,
                                    task?.Status,
                                    task?.Priority,
                                    task?.DueDate?.ToString("MMMM dd yyyy", ci)
                                );
#pragma warning restore CS8604 // Possible null reference argument.
                        }
                    }
                }
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }
    }
}
