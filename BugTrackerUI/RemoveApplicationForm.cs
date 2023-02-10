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
    public partial class RemoveApplicationForm : Form
    {
        private List<ApplicationModel> availableApplications = GlobalConfig.Connection.GetApplication_All();
        public RemoveApplicationForm()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            ApplicationDataGridView.DataSource = null;
            ApplicationDataGridView.DataSource = availableApplications;
        }
        private void ApplicationDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ApplicationDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ApplicationDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["id"].Value;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ApplicationDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ApplicationDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["id"].Value;
                GlobalConfig.Connection.Delete_Application(id);
                
                ApplicationDataGridView.DataSource = GlobalConfig.Connection.GetApplication_All();
                ApplicationDataGridView.Refresh();
            }
        }

        private void RemoveApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
