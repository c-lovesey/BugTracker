using BugTrackerLibrary.DataAccess;
using BugTrackerLibrary.Models;
using BugTrackerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackerUI
{
    public partial class AddEnvironmentForm : Form
    {
        public AddEnvironmentForm()
        {
            InitializeComponent();
        }

        private void AddEnvironmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormHeader_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EnvironmentModel model = new EnvironmentModel(EnvironmentTextBox.Text);


                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateEnvironment(model);
                }
                EnvironmentTextBox.Text = "";


              
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (EnvironmentTextBox.Text.Length == 0)
            {
                //say input version
                output = false;
            }
            return output;

        }
    }
    
}
