using BugTrackerLibrary;
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
    public partial class UpdateBugReportForm : Form
    {
        private List<ApplicationModel> availableApplications = GlobalConfig.Connection.GetApplication_All();
        private List<VersionModel> availableVersions = new List<VersionModel>();
        private List<EnvironmentModel> availableEnviroments = GlobalConfig.Connection.GetEnvironment_All();
        List<string> confirmationOptions = new List<string>() { "Confirmed", "Unconfirmed" };
        List<string> resolutionOptions = new List<string>() { "Unresolved", "Resolved" };
        List<string> priorityOptions = new List<string>() { "Low", "Medium", "High" };
        List<string> labelsOptions = new List<string>() { "Undefined" };
        List<string> categoryOptions = new List<string>() { "Functional", "Syntax", "Logic", "Calculation", "Integration", "Undefined" };
        List<string> fixedOptions = new List<string>() { "Unresolved" };
        List<string> statusOptions = new List<string>() { "Open", "Closed" };

        private BugModel _selectedBug;
        
        public UpdateBugReportForm(BugModel selectedBug)
        {
            InitializeComponent();
            _selectedBug = selectedBug;
            List<VersionModel> availableVersions = GlobalConfig.Connection.GetVersion_Application(_selectedBug.ApplicationID);
            WireUpLists();
        }
        private void WireUpLists()
        {

            ApplicationCombobox.DataSource = null;
            ApplicationCombobox.DataSource = availableApplications;
            ApplicationCombobox.DisplayMember = "ApplicationName";
            AffectedCheckedListbox.DataSource = null;
            ApplicationModel selectedApp = (ApplicationModel)ApplicationCombobox.SelectedItem;
            int selectedAppId = selectedApp.id;
            List<VersionModel> versionsForSelectedApp = GlobalConfig.Connection.GetVersion_Application(selectedAppId);
            AffectedCheckedListbox.DataSource = versionsForSelectedApp;
            AffectedCheckedListbox.DisplayMember = "VersionName";
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
        private void FormHeader_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ApplicationCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AffectedCheckedListbox.DataSource = null;
            ApplicationModel selectedApp = (ApplicationModel)ApplicationCombobox.SelectedItem;
            int selectedAppId = selectedApp.id;
            List<VersionModel> versionsForSelectedApp = GlobalConfig.Connection.GetVersion_Application(selectedAppId);
            AffectedCheckedListbox.DataSource = versionsForSelectedApp;
            AffectedCheckedListbox.DisplayMember = "VersionName";
            AffectedCheckedListbox.Refresh();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            {
                if (ValidateForm())
                {
                    List<VersionModel> selectedVersions = AffectedCheckedListbox.CheckedItems.Cast<VersionModel>().ToList();
                    string commaSeparatedVersions = string.Join(",", selectedVersions.Select(x => x.VersionName));

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



                    GlobalConfig.Connection.Update_BugReport(_selectedBug.id,applicationId,
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
                        bugConfirmation,
                        commaSeparatedVersions);
                    ApplicationCombobox.Text = "";
                    AffectedCheckedListbox.Text = "";
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
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (AffectedCheckedListbox.Text.Length == 0)
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

        private void ApplicationCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AffectedCheckedListbox.DataSource = null;
            ApplicationModel selectedApp = (ApplicationModel)ApplicationCombobox.SelectedItem;
            int selectedAppId = selectedApp.id;
            List<VersionModel> versionsForSelectedApp = GlobalConfig.Connection.GetVersion_Application(selectedAppId);
            AffectedCheckedListbox.DataSource = versionsForSelectedApp;
            AffectedCheckedListbox.DisplayMember = "VersionName";
            AffectedCheckedListbox.Refresh();
        }
    }
}
