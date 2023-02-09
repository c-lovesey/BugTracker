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
using System.IO;

namespace BugTrackerUI
{
    public partial class BugViewerForm : Form
    {
        private List<ApplicationModel> availableApplications = GlobalConfig.Connection.GetApplication_All();
        private List<BugModel> availableBugReports = GlobalConfig.Connection.GetBugReport_All();
        private List<string> resolutionOptions = new List<string>() {"" ,"Unresolved", "Resolved" };
        //private List<string> priorityOptions = new List<string>() { "Low", "Medium", "High" };
        private List<string> categoryOptions = new List<string>() { "", "Functional", "Syntax", "Logic", "Calculation", "Integration", "Undefined" };
        private string bugTitle;
        private List<string> statusOptions = new List<string>() { "", "Open", "Closed" };
        private List<BugModel> bugs = new List<BugModel>();
        public BugViewerForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            ApplicationCombobox.DataSource = null;
            ApplicationCombobox.DataSource = availableApplications;
            ApplicationCombobox.DisplayMember = "ApplicationName";
            CategoryCombobox.DataSource = null;
            CategoryCombobox.DataSource = categoryOptions;
            CategoryCombobox.DisplayMember = "Category";
            StatusCombobox.DataSource = null;
            StatusCombobox.DataSource = statusOptions;
            StatusCombobox.DisplayMember = "Status";
            ResolutionCombobox.DataSource = null;
            ResolutionCombobox.DataSource = resolutionOptions;
            ResolutionCombobox.DisplayMember = "Resolution";
            SearchTextbox.Text = "";
            BugListbox.DataSource = null;
            BugListbox.DataSource = availableBugReports;
            BugListbox.DisplayMember = "BugTitle";
        }
        private void LoadPicture(int applicationId)
        {
            string imageFolder = @"C:\Users\clove\source\repos\BugTracker\BugTrackerUI\Images\";
            string imagePath = imageFolder + applicationId + ".png";
            if (File.Exists(imagePath))
            {
                ApplicationLogoPicturebox.Image = Image.FromFile(imagePath);
            }
            else
            {
                ApplicationLogoPicturebox.Image = Image.FromFile(imageFolder + "default.png");
            }
            ApplicationLogoPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            ApplicationLogoPicturebox.Refresh();
            //ApplicationLogoPicturebox;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchButtom_Click(object sender, EventArgs e)
        {
            if (ValidateSearchForm())
            {
                int? applicationId = 0;
                ApplicationModel app = (ApplicationModel)ApplicationCombobox.SelectedItem;
                if (app == null) 
                {
                    applicationId = null;
                    
                }
                else {
                    applicationId = app.id;
                }
                string category = CategoryCombobox.Text;
                string status = StatusCombobox.Text;
                string resolution = ResolutionCombobox.Text;
                string title = SearchTextbox.Text;
                if (category == "")
                {
                    category = null;
                }
                if (status == "")
                {
                    status = null;
                }
                if (resolution == "")
                {
                    resolution = null;
                }
                if (title == "")
                {
                    title = null;
                }
                bugs = GlobalConfig.Connection.SearchBugReport(applicationId, category, status, resolution, title);
                //TODO Check why i get bug id as 0
                BugListbox.DataSource = null;
                BugListbox.DataSource = bugs;
                BugListbox.DisplayMember = "BugTitle";
                BugListbox.Refresh();
            }
        }
        private bool ValidateSearchForm()
        {
            bool output = true;
            //if (ApplicationCombobox.Text.Length == 0)
            //{
            //    output = false;
            //}
            //if (CategoryCombobox.Text.Length == 0)
            //{
            //    output = false;
            //}
            //if (StatusCombobox.Text.Length == 0)
            //{
            //    output = false;
            //}
            //if (ResolutionCombobox.Text.Length == 0)
            //{
            //    output = false;
            //}
            //if (output == false)
            //{
            //    MessageBox.Show("Please fill in at least one field");
            //}
            return output;
        }

        private void BugListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BugModel selectedBug = (BugModel)BugListbox.SelectedItem;
            
            if (selectedBug != null)
            {
                ApplicationModel selectedApplication = availableApplications.Where(x => x.id == selectedBug.ApplicationID).First();
                ApplicationVersionLabel.Text = selectedBug.BugAffectedVersions;
                string bugid = selectedApplication.ApplicationLetterID +"-"+ selectedBug.id.ToString();
                BugIDLabel.Text = bugid;
                BugTitleLabel.Text = selectedBug.BugTitle;
                BugDetailsLabel.Text = selectedBug.BugDescription;
                LoadPicture(selectedBug.ApplicationID);
            }
            


        }

        private void NavigationNewReportLabel_Click(object sender, EventArgs e)
        {
            Form form = new BugReportForm();
            form.Show();
        }

        private void NavigationUpdateReportLabel_Click(object sender, EventArgs e)
        {
            Form form = new UpdateBugReportForm();
            form.Show();
        }

        private void NavigationRemoveReportLabel_Click(object sender, EventArgs e)
        {
            Form form = new RemoveBugReportForm();
            form.Show();
        }

        private void NavigationNewVersionLabel_Click(object sender, EventArgs e)
        {
            Form form = new AddVersionForm();
            form.Show();
        }

        private void NavigationRemoveVersionLabel_Click(object sender, EventArgs e)
        {
            //Form form = new RemoveVersionForm();
           // form.Show();
        }

        private void NavigationRemoveApplicatonLabel_Click(object sender, EventArgs e)
        {
            Form form = new RemoveApplicationForm();
            form.Show();
        }

        private void NavigationNewApplicationLabel_Click(object sender, EventArgs e)
        {
            Form form = new AddApplicationForm();
            form.Show();
        }
    }
}
