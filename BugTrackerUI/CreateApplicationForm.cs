using BugTrackerLibrary.Models;
using BugTrackerLibrary;

namespace BugTrackerUI
{
    public partial class CreateApplicationForm : Form
    {
        public CreateApplicationForm()
        {
            InitializeComponent();
        }

        private void CreateApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ApplicationModel model = new ApplicationModel(NameTextbox.Text, IDTextbox.Text);
                GlobalConfig.Connection.CreateApplication(model);
                NameTextbox.Text = "";
                IDTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (NameTextbox.Text.Length == 0)
            {
                //say input version
                output = false;
            }
            if (IDTextbox.Text.Length == 0)
            {
                //say input application
                output = false;
            }
            return output;

        }
    }
}