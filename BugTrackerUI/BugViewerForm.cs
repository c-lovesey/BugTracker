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
        private List<string> resolutionOptions = new List<string>() { "Unresolved", "Resolved" };
        //private List<string> priorityOptions = new List<string>() { "Low", "Medium", "High" };
        private List<string> categoryOptions = new List<string>() { "Functional", "Syntax", "Logic", "Calculation", "Integration", "Undefined" };
        private string bugTitle;
        private List<string> statusOptions = new List<string>() { "Open", "Closed" };
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

            }
        }
        private bool ValidateSearchForm()
        {
            bool output = true;
            if (ApplicationCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (CategoryCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (StatusCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (ResolutionCombobox.Text.Length == 0)
            {
                output = false;
            }
            if (output == false)
            {
                MessageBox.Show("Please fill in at least one field");
            }
            return output;
        }
            
            
        
    }
}
