using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FillData()
        {
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
#pragma warning disable CS8604 // Possible null reference argument.
                            this.tasksDataGridView.Rows.Add
                                (
                                    task?.Name,
                                    task?.Description,
                                    task?.Status,
                                    task?.Priority,
                                    task?.DueDate
                                );
#pragma warning restore CS8604 // Possible null reference argument.
                        }
                    }
                }
            }
        }
    }
}
