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
    public partial class RemoveBugReportForm : Form
    {
        private List<BugModel> availableBugReports = GlobalConfig.Connection.GetBugReport_All();
        public RemoveBugReportForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            BugReportDataGridView.DataSource = null;
            BugReportDataGridView.DataSource = availableBugReports;
        }
        private void ApplicationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (BugReportDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BugReportDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["id"].Value;
                GlobalConfig.Connection.Delete_BugReport(id);

                BugReportDataGridView.DataSource = GlobalConfig.Connection.GetBugReport_All();
                BugReportDataGridView.Refresh();
            }
        }
        private void BugReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BugReportDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BugReportDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["ID"].Value;
            }
        }
    }
}
