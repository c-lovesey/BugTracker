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
        public RemoveApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ApplicationDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ApplicationDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["ID"].Value;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ApplicationDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ApplicationDataGridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["ID"].Value;
                //otherstuff
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
