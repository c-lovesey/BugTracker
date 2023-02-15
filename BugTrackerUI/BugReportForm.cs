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
        //Creates a list for each Dropdown menu and gets relevant data from the database
        private List<ApplicationModel> availableApplications = GlobalConfig.Connection.GetApplication_All();
        private List<VersionModel> availableVersions = new List<VersionModel>();
        private List<EnvironmentModel> availableEnviroments = GlobalConfig.Connection.GetEnvironment_All();
        private List<string> confirmationOptions = new List<string>() { "Confirmed", "Unconfirmed" };
        private List<string> resolutionOptions = new List<string>() {"Unresolved","Resolved" };
        private List<string> priorityOptions = new List<string>() {"Low","Medium","High" };
        private List<string> labelsOptions = new List<string>() {"Undefined" };
        private List<string> categoryOptions = new List<string>() {"Functional","Syntax","Logic","Calculation","Integration","Undefined" };
        private List<string> fixedOptions = new List<string>() {"Unresolved" };
        private List<string> statusOptions = new List<string>() { "Open", "Closed" };



        public BugReportForm()
        {
            //initializes form components
            InitializeComponent();
            //calls the WireUpLists method which fills the dropdown menus with the lists created above
            WireUpLists();
        }
        private void WireUpLists()
        {
            //sets the datasource of each dropdown menu to the list created above
            ApplicationCombobox.DataSource = null;
            ApplicationCombobox.DataSource = availableApplications;
            ApplicationCombobox.DisplayMember = "ApplicationName";
            VersionCheckedListbox.DataSource = null;
            VersionCheckedListbox.DataSource = availableVersions;
            VersionCheckedListbox.DisplayMember = "ApplicationVersion";
            EnvironmentCombobox.DataSource = null;
            EnvironmentCombobox.DataSource = availableEnviroments;
            EnvironmentCombobox.DisplayMember = "EnvironmentName";
            StatusCombobox.DataSource = null;
            StatusCombobox.DataSource = statusOptions;
            StatusCombobox.DisplayMember = "Status";
            ConfirmCombobox.DataSource = null;
            ConfirmCombobox.DataSource = confirmationOptions;
            ConfirmCombobox.DisplayMember = "Confirmation";
            ResolutionCombobox.DataSource = null;
            ResolutionCombobox.DataSource = resolutionOptions;
            ResolutionCombobox.DisplayMember = "Resolution";
            PriorityCombobox.DataSource = null;
            PriorityCombobox.DataSource = priorityOptions;
            PriorityCombobox.DisplayMember = "Priority";
            LabelsCombobox.DataSource = null;
            LabelsCombobox.DataSource = labelsOptions;
            LabelsCombobox.DisplayMember = "Labels";
            CategoryCombobox.DataSource = null;
            CategoryCombobox.DataSource = categoryOptions;
            CategoryCombobox.DisplayMember = "Category";
            FixedCombobox.DataSource = null;
            FixedCombobox.DataSource = fixedOptions;
            FixedCombobox.DisplayMember = "Fixed";
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Checks if the form is valid before saving
            if (ValidateForm())
            {
                //Converts the selected items in the checked list box to a string of comma seperated values
                List<VersionModel> selectedVersions = VersionCheckedListbox.CheckedItems.Cast<VersionModel>().ToList();
                string commaSeparatedVersions = string.Join(",", selectedVersions.Select(x => x.VersionName));
                //Gets all the relevant information from the form for creating a bug report
                ApplicationModel app = (ApplicationModel)ApplicationCombobox.SelectedItem;
                int applicationId = app.id;
                EnvironmentModel env = (EnvironmentModel)EnvironmentCombobox.SelectedItem;
                int environmentId = env.id;
                string bugStatus = StatusCombobox.Text;
                string bugResolution = ResolutionCombobox.Text;
                string bugPriority = PriorityCombobox.Text;
                string bugDescription = DescriptionTextbox.Text;
                string bugTitle = TitleTextBox.Text;
                string bugLabel = LabelsCombobox.Text;
                string bugCategory = CategoryCombobox.Text;
                string bugFixedVersion = FixedCombobox.Text;
                string bugConfirmation = ConfirmCombobox.Text;
                //calls the BugModel constructor to create a new bug report
                BugModel model = new BugModel(
                    applicationId,
                    commaSeparatedVersions,
                    environmentId,
                    bugStatus,
                    bugResolution,
                    bugPriority,
                    bugDescription,
                    bugTitle,
                    bugLabel,
                    bugCategory,
                    bugFixedVersion,
                    bugConfirmation);

                //Calls the SQL stored procedure to create a new bug report
                GlobalConfig.Connection.CreateBugReport(model);
                //AddFile(model.id);
                //Resets the information in the form
                ApplicationCombobox.Text = "";
                VersionCheckedListbox.Text = "";
                EnvironmentCombobox.Text = "";
                PriorityCombobox.Text = "";
                DescriptionTextbox.Text = "";
                TitleTextBox.Text = "";
                LabelsCombobox.Text = "";
                CategoryCombobox.Text = "";
                FixedCombobox.Text = "";
                
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private bool ValidateForm()
        {
            //Checks if each value inputted into the form is valid
            bool output = true;

            if (VersionCheckedListbox.Text.Length == 0)
            {
                output = false;
            }
            if (DescriptionTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (EnvironmentCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (PriorityCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (TitleTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (LabelsCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (CategoryCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (FixedCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (ConfirmCombobox.Text.Length == 0)
            {
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
            //Gets the selected application from the combobox and displays the versions for that application in the checked list box
            VersionCheckedListbox.DataSource = null;
            ApplicationModel selectedApp = (ApplicationModel)ApplicationCombobox.SelectedItem;
            int selectedAppId = selectedApp.id;
            List<VersionModel> versionsForSelectedApp = GlobalConfig.Connection.GetVersion_Application(selectedAppId);
            
            VersionCheckedListbox.DataSource = versionsForSelectedApp;
            VersionCheckedListbox.DisplayMember = "VersionName";
            VersionCheckedListbox.Refresh();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            
        }
        private void AddFile(int id)
        {
            //Allows the user to add files as Attatchments to the BugReport
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string extension = Path.GetExtension(path);
                string destinationDirectory = @"C:\Users\clove\source\repos\BugTracker\BugTrackerUI\Attatchments\";
                int uniqueID = Directory.GetFiles(destinationDirectory, $"{id}-*{extension}").Length + 1;
                string destinationPath = Path.Combine(destinationDirectory, $"{id}-{uniqueID}{extension}");
                File.Copy(path, destinationPath, true);
            }
        }
    }
}
