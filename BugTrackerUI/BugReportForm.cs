using BugTrackerLibrary;
using BugTrackerLibrary.DataAccess;
using BugTrackerLibrary.Models;
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
    public partial class BugReportForm : Form
    {
        public BugReportForm()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                BugModel model = new BugModel(
                    ApplicationCombobox.Text, 
                    VersionTextbox.Text,
                    true, "Unresolved", 
                    EnvironmentCombobox.Text, 
                    PriorityCombobox.Text, 
                    DescriptionTextbox.Text);

                GlobalConfig.Connection.CreateBugReport(model);
                ApplicationCombobox.Text = "";
                VersionTextbox.Text = "";
                EnvironmentCombobox.Text = "";
                PriorityCombobox.Text = "";
                DescriptionTextbox.Text = "";
                //AttatchmentRichTextbox = "";

                //model.Application = ApplicationCombobox.Text;
                //model.Version = VersionTextbox.Text;
                //model.BugStatus = true;
                //model.BugResolution = "Unresolved";
                //model.BugEnvironment = EnvironmentCombobox.Text;
                //model.BugPriority = PriorityCombobox.Text;
                //model.BugDescription = DescriptionTextbox.Text;

                //TODO figure out attatchments and if extra fields are necesarry
                //model.BugTitle
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (VersionTextbox.Text.Length == 0)
            {
                //say input version
                output = false;
            }
            if (DescriptionTextbox.Text.Length == 0)
            {
                //say input Description
                output = false;
            }
            if (EnvironmentCombobox.Text.Length == 0)
            {
                //say input Description
                output = false;
            }
            return output;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
