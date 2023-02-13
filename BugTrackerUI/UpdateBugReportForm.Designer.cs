namespace BugTrackerUI
{
    partial class UpdateBugReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBugReportForm));
            this.FormHeader = new System.Windows.Forms.Label();
            this.AffectedLabel = new System.Windows.Forms.Label();
            this.AffectedCheckedListbox = new System.Windows.Forms.CheckedListBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.ResolutionCombobox = new System.Windows.Forms.ComboBox();
            this.FixedCombobox = new System.Windows.Forms.ComboBox();
            this.FixedLabel = new System.Windows.Forms.Label();
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ConfirmCombobox = new System.Windows.Forms.ComboBox();
            this.ConfirmationStatusLabel = new System.Windows.Forms.Label();
            this.LabelsCombobox = new System.Windows.Forms.ComboBox();
            this.LabelsLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriorityCombobox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplicationCombobox = new System.Windows.Forms.ComboBox();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.EnvironmentCombobox = new System.Windows.Forms.ComboBox();
            this.EnvironmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.AutoSize = true;
            this.FormHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormHeader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormHeader.Location = new System.Drawing.Point(12, 9);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(307, 47);
            this.FormHeader.TabIndex = 43;
            this.FormHeader.Text = "Update Bug Report";
            this.FormHeader.Click += new System.EventHandler(this.FormHeader_Click);
            // 
            // AffectedLabel
            // 
            this.AffectedLabel.AutoSize = true;
            this.AffectedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AffectedLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AffectedLabel.Location = new System.Drawing.Point(29, 197);
            this.AffectedLabel.Name = "AffectedLabel";
            this.AffectedLabel.Size = new System.Drawing.Size(169, 25);
            this.AffectedLabel.TabIndex = 46;
            this.AffectedLabel.Text = "Affected Version/s:";
            this.AffectedLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AffectedCheckedListbox
            // 
            this.AffectedCheckedListbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AffectedCheckedListbox.FormattingEnabled = true;
            this.AffectedCheckedListbox.Location = new System.Drawing.Point(227, 197);
            this.AffectedCheckedListbox.Name = "AffectedCheckedListbox";
            this.AffectedCheckedListbox.Size = new System.Drawing.Size(202, 124);
            this.AffectedCheckedListbox.TabIndex = 48;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StatusLabel.Location = new System.Drawing.Point(978, 132);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 25);
            this.StatusLabel.TabIndex = 49;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Location = new System.Drawing.Point(1068, 125);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(233, 38);
            this.StatusCombobox.TabIndex = 50;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ResolutionLabel.Location = new System.Drawing.Point(940, 176);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(104, 25);
            this.ResolutionLabel.TabIndex = 51;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // ResolutionCombobox
            // 
            this.ResolutionCombobox.FormattingEnabled = true;
            this.ResolutionCombobox.Location = new System.Drawing.Point(1068, 169);
            this.ResolutionCombobox.Name = "ResolutionCombobox";
            this.ResolutionCombobox.Size = new System.Drawing.Size(233, 38);
            this.ResolutionCombobox.TabIndex = 52;
            // 
            // FixedCombobox
            // 
            this.FixedCombobox.FormattingEnabled = true;
            this.FixedCombobox.Location = new System.Drawing.Point(1068, 213);
            this.FixedCombobox.Name = "FixedCombobox";
            this.FixedCombobox.Size = new System.Drawing.Size(233, 38);
            this.FixedCombobox.TabIndex = 56;
            // 
            // FixedLabel
            // 
            this.FixedLabel.AutoSize = true;
            this.FixedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FixedLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FixedLabel.Location = new System.Drawing.Point(916, 220);
            this.FixedLabel.Name = "FixedLabel";
            this.FixedLabel.Size = new System.Drawing.Size(128, 25);
            this.FixedLabel.TabIndex = 55;
            this.FixedLabel.Text = "Fixed Version:";
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(646, 220);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(233, 38);
            this.CategoryCombobox.TabIndex = 63;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CategoryLabel.Location = new System.Drawing.Point(548, 226);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(92, 25);
            this.CategoryLabel.TabIndex = 62;
            this.CategoryLabel.Text = "Category:";
            // 
            // ConfirmCombobox
            // 
            this.ConfirmCombobox.FormattingEnabled = true;
            this.ConfirmCombobox.Location = new System.Drawing.Point(646, 176);
            this.ConfirmCombobox.Name = "ConfirmCombobox";
            this.ConfirmCombobox.Size = new System.Drawing.Size(233, 38);
            this.ConfirmCombobox.TabIndex = 61;
            // 
            // ConfirmationStatusLabel
            // 
            this.ConfirmationStatusLabel.AutoSize = true;
            this.ConfirmationStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationStatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConfirmationStatusLabel.Location = new System.Drawing.Point(458, 183);
            this.ConfirmationStatusLabel.Name = "ConfirmationStatusLabel";
            this.ConfirmationStatusLabel.Size = new System.Drawing.Size(182, 25);
            this.ConfirmationStatusLabel.TabIndex = 60;
            this.ConfirmationStatusLabel.Text = "Confirmation Status:";
            // 
            // LabelsCombobox
            // 
            this.LabelsCombobox.FormattingEnabled = true;
            this.LabelsCombobox.Location = new System.Drawing.Point(646, 132);
            this.LabelsCombobox.Name = "LabelsCombobox";
            this.LabelsCombobox.Size = new System.Drawing.Size(233, 38);
            this.LabelsCombobox.TabIndex = 59;
            // 
            // LabelsLabel
            // 
            this.LabelsLabel.AutoSize = true;
            this.LabelsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelsLabel.Location = new System.Drawing.Point(571, 132);
            this.LabelsLabel.Name = "LabelsLabel";
            this.LabelsLabel.Size = new System.Drawing.Size(69, 25);
            this.LabelsLabel.TabIndex = 58;
            this.LabelsLabel.Text = "Labels:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 331);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(127, 30);
            this.DescriptionLabel.TabIndex = 64;
            this.DescriptionLabel.Text = "Description:";
            // 
            // PriorityCombobox
            // 
            this.PriorityCombobox.FormattingEnabled = true;
            this.PriorityCombobox.Location = new System.Drawing.Point(1068, 257);
            this.PriorityCombobox.Name = "PriorityCombobox";
            this.PriorityCombobox.Size = new System.Drawing.Size(233, 38);
            this.PriorityCombobox.TabIndex = 71;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(1157, 879);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 38);
            this.SaveButton.TabIndex = 70;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PriorityLabel.Location = new System.Drawing.Point(961, 257);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(83, 30);
            this.PriorityLabel.TabIndex = 68;
            this.PriorityLabel.Text = "Priority:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(227, 86);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(202, 34);
            this.TitleTextBox.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(141, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "Title:";
            // 
            // ApplicationCombobox
            // 
            this.ApplicationCombobox.FormattingEnabled = true;
            this.ApplicationCombobox.Location = new System.Drawing.Point(227, 142);
            this.ApplicationCombobox.Name = "ApplicationCombobox";
            this.ApplicationCombobox.Size = new System.Drawing.Size(202, 38);
            this.ApplicationCombobox.TabIndex = 82;
            this.ApplicationCombobox.SelectedIndexChanged += new System.EventHandler(this.ApplicationCombobox_SelectedIndexChanged_1);
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ApplicationLabel.Location = new System.Drawing.Point(75, 140);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(123, 30);
            this.ApplicationLabel.TabIndex = 81;
            this.ApplicationLabel.Text = "Application:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(20, 364);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(1267, 442);
            this.DescriptionTextbox.TabIndex = 65;
            // 
            // EnvironmentCombobox
            // 
            this.EnvironmentCombobox.FormattingEnabled = true;
            this.EnvironmentCombobox.Location = new System.Drawing.Point(646, 272);
            this.EnvironmentCombobox.Name = "EnvironmentCombobox";
            this.EnvironmentCombobox.Size = new System.Drawing.Size(233, 38);
            this.EnvironmentCombobox.TabIndex = 86;
            // 
            // EnvironmentLabel
            // 
            this.EnvironmentLabel.AutoSize = true;
            this.EnvironmentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EnvironmentLabel.Location = new System.Drawing.Point(505, 272);
            this.EnvironmentLabel.Name = "EnvironmentLabel";
            this.EnvironmentLabel.Size = new System.Drawing.Size(135, 30);
            this.EnvironmentLabel.TabIndex = 85;
            this.EnvironmentLabel.Text = "Environment:";
            // 
            // UpdateBugReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 940);
            this.Controls.Add(this.EnvironmentCombobox);
            this.Controls.Add(this.EnvironmentLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplicationCombobox);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.PriorityCombobox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CategoryCombobox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ConfirmCombobox);
            this.Controls.Add(this.ConfirmationStatusLabel);
            this.Controls.Add(this.LabelsCombobox);
            this.Controls.Add(this.LabelsLabel);
            this.Controls.Add(this.FixedCombobox);
            this.Controls.Add(this.FixedLabel);
            this.Controls.Add(this.ResolutionCombobox);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.AffectedCheckedListbox);
            this.Controls.Add(this.AffectedLabel);
            this.Controls.Add(this.FormHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UpdateBugReportForm";
            this.Text = "Update Bug Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label FormHeader;
        private Label AffectedLabel;
        private CheckedListBox AffectedCheckedListbox;
        private Label StatusLabel;
        private ComboBox StatusCombobox;
        private Label ResolutionLabel;
        private ComboBox ResolutionCombobox;
        private ComboBox FixedCombobox;
        private Label FixedLabel;
        private ComboBox CategoryCombobox;
        private Label CategoryLabel;
        private ComboBox ConfirmCombobox;
        private Label ConfirmationStatusLabel;
        private ComboBox LabelsCombobox;
        private Label LabelsLabel;
        private Label DescriptionLabel;
        private ComboBox PriorityCombobox;
        private Button SaveButton;
        private Label PriorityLabel;
        private TextBox TitleTextBox;
        private Label label1;
        private ComboBox ApplicationCombobox;
        private Label ApplicationLabel;
        private TextBox DescriptionTextbox;
        private ComboBox EnvironmentCombobox;
        private Label EnvironmentLabel;
    }
}