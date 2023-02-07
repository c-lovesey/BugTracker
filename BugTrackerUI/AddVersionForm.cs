﻿using BugTrackerLibrary.Models;
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

namespace BugTrackerUI
{
    public partial class AddVersionForm : Form
    {
        public AddVersionForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                VersionModel model = new VersionModel(VersionTextbox.Text,ApplicationCombobox.Text);
                ApplicationCombobox.Text = "";
                VersionTextbox.Text = "";
                GlobalConfig.Connection.CreateVersion(model);

            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (EnvironmentTextBox.Text.Length == 0)
            {
                //say input version
                output = false;
            }
            return output;

        }
    

    private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
