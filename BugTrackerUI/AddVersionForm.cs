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
    public partial class AddVersionForm : Form
    {
        private List<ApplicationModel> availableApplications = GlobalConfig.Connection.GetApplication_All();
        public AddVersionForm()
        {
            InitializeComponent();
            //SampleData();
            WireUpLists();
        }

        private void SampleData()
        {
            availableApplications.Add(new ApplicationModel("Application 1", "A1"));
        }
        private void WireUpLists()
        {
            ApplicationCombobox.DataSource = null;
            ApplicationCombobox.DataSource = availableApplications;
            ApplicationCombobox.DisplayMember = "ApplicationName";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save button clicked");
            if (ValidateForm())
            {

                ApplicationModel app = (ApplicationModel)ApplicationCombobox.SelectedItem;
                VersionModel model = new VersionModel(VersionTextbox.Text, ApplicationCombobox.Text);
                GlobalConfig.Connection.CreateVersion(model, app.id);
                ApplicationCombobox.Text = "";
                VersionTextbox.Text = "";
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
            if (ApplicationCombobox.Text.Length == 0)
            {
                //say input application
                output = false;
            }
            return output;

        }


        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                ApplicationModel app = (ApplicationModel)ApplicationCombobox.SelectedItem;
                int appid = app.id;
                VersionModel model = new VersionModel(VersionTextbox.Text, ApplicationCombobox.Text);
                GlobalConfig.Connection.CreateVersion(model, appid);
                ApplicationCombobox.Text = "";
                VersionTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private void ApplicationCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
