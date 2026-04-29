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
            Program.mainForm.FillData();
        }
    }
}
