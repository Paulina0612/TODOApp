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
                int id = 3;
                if (jobject[id.ToString()] is not null)
                {
                    Task? task = JsonConvert.DeserializeObject<Task>(jobject[id.ToString()].ToString());
                    MessageBox.Show(task?.Name);
                }
                else
                {
                    MessageBox.Show("Task with id " + id + " not found.");
                }
            }
        }
    }
}
