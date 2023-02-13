using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackerUI
{
    public partial class AttachmentForm : Form
    {
        private int _id;

        private void AttachmentForm_Load(object sender, EventArgs e)
        {
            if (_id == -1)
            {
                MessageBox.Show("Error: Id has not been set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public AttachmentForm()
        {
            string destinationDirectory = @"C:\Users\clove\source\repos\BugTracker\BugTrackerUI\Attatchments\";
            string[] attachments = Directory.GetFiles(destinationDirectory, $"{_id}-*");
            if (attachments.Length == 0)
            {
                MessageBox.Show("No attachments found for the selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            listViewAttatchments.Clear();
            listViewAttatchments.View = View.Details;
            listViewAttatchments.Columns.Add("File Name", 150);
            listViewAttatchments.Columns.Add("Full Path", 250);
            foreach (string attachment in attachments)
            {
                string fileName = Path.GetFileName(attachment);
                ListViewItem item = new ListViewItem(new[] { fileName, attachment });
                listViewAttatchments.Items.Add(item);
            }
        }

        private void listViewAttatchments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
