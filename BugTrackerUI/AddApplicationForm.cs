using BugTrackerLibrary.Models;
using BugTrackerLibrary;

namespace BugTrackerUI
{
    public partial class AddApplicationForm : Form
    {
        public AddApplicationForm()
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
                AddImage(model.id);
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
        private void AddImage(int id)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string fileName = Path.GetFileName(path);
                string destinationPath = @"C:\Users\clove\source\repos\BugTracker\BugTrackerUI\Images\" + id + ".png";
                File.Copy(path, destinationPath, true);
            }
        }
    }
}