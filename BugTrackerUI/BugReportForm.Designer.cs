namespace BugTrackerUI
{
    partial class BugReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugReportForm));
            this.ApplicationCombobox = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.EnvironmentLabel = new System.Windows.Forms.Label();
            this.EnvironmentCombobox = new System.Windows.Forms.ComboBox();
            this.AttatchmentLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.PriorityLable = new System.Windows.Forms.Label();
            this.AttatchmentRichTextbox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PriorityCombobox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ConfirmCombobox = new System.Windows.Forms.ComboBox();
            this.ConfirmationStatusLabel = new System.Windows.Forms.Label();
            this.LabelsCombobox = new System.Windows.Forms.ComboBox();
            this.LabelsLabel = new System.Windows.Forms.Label();
            this.FixedCombobox = new System.Windows.Forms.ComboBox();
            this.FixedLabel = new System.Windows.Forms.Label();
            this.ResolutionCombobox = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.VersionCheckedListbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ApplicationCombobox
            // 
            this.ApplicationCombobox.FormattingEnabled = true;
            this.ApplicationCombobox.Location = new System.Drawing.Point(195, 119);
            this.ApplicationCombobox.Name = "ApplicationCombobox";
            this.ApplicationCombobox.Size = new System.Drawing.Size(214, 38);
            this.ApplicationCombobox.TabIndex = 29;
            this.ApplicationCombobox.SelectedIndexChanged += new System.EventHandler(this.ApplicationCombobox_SelectedIndexChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IDLabel.Location = new System.Drawing.Point(12, 310);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(190, 30);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "Description of Bug:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.VersionLabel.Location = new System.Drawing.Point(12, 169);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(157, 30);
            this.VersionLabel.TabIndex = 25;
            this.VersionLabel.Text = "Affects Version:";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ApplicationLabel.Location = new System.Drawing.Point(47, 119);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(123, 30);
            this.ApplicationLabel.TabIndex = 24;
            this.ApplicationLabel.Text = "Application:";
            // 
            // FormHeader
            // 
            this.FormHeader.AutoSize = true;
            this.FormHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormHeader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormHeader.Location = new System.Drawing.Point(12, 9);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(287, 47);
            this.FormHeader.TabIndex = 23;
            this.FormHeader.Text = "Report a new Bug";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(12, 353);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(1039, 146);
            this.DescriptionTextbox.TabIndex = 32;
            this.DescriptionTextbox.TextChanged += new System.EventHandler(this.DescriptionTextbox_TextChanged);
            // 
            // EnvironmentLabel
            // 
            this.EnvironmentLabel.AutoSize = true;
            this.EnvironmentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EnvironmentLabel.Location = new System.Drawing.Point(12, 512);
            this.EnvironmentLabel.Name = "EnvironmentLabel";
            this.EnvironmentLabel.Size = new System.Drawing.Size(135, 30);
            this.EnvironmentLabel.TabIndex = 34;
            this.EnvironmentLabel.Text = "Environment:";
            this.EnvironmentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnvironmentCombobox
            // 
            this.EnvironmentCombobox.FormattingEnabled = true;
            this.EnvironmentCombobox.Location = new System.Drawing.Point(14, 554);
            this.EnvironmentCombobox.Name = "EnvironmentCombobox";
            this.EnvironmentCombobox.Size = new System.Drawing.Size(267, 38);
            this.EnvironmentCombobox.TabIndex = 35;
            // 
            // AttatchmentLabel
            // 
            this.AttatchmentLabel.AutoSize = true;
            this.AttatchmentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AttatchmentLabel.Location = new System.Drawing.Point(12, 612);
            this.AttatchmentLabel.Name = "AttatchmentLabel";
            this.AttatchmentLabel.Size = new System.Drawing.Size(134, 30);
            this.AttatchmentLabel.TabIndex = 36;
            this.AttatchmentLabel.Text = "Attatchment:";
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadButton.Location = new System.Drawing.Point(908, 644);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(130, 38);
            this.UploadButton.TabIndex = 37;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            // 
            // PriorityLable
            // 
            this.PriorityLable.AutoSize = true;
            this.PriorityLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PriorityLable.Location = new System.Drawing.Point(13, 860);
            this.PriorityLable.Name = "PriorityLable";
            this.PriorityLable.Size = new System.Drawing.Size(83, 30);
            this.PriorityLable.TabIndex = 38;
            this.PriorityLable.Text = "Priority:";
            this.PriorityLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // AttatchmentRichTextbox
            // 
            this.AttatchmentRichTextbox.Location = new System.Drawing.Point(14, 645);
            this.AttatchmentRichTextbox.Name = "AttatchmentRichTextbox";
            this.AttatchmentRichTextbox.Size = new System.Drawing.Size(888, 212);
            this.AttatchmentRichTextbox.TabIndex = 40;
            this.AttatchmentRichTextbox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(1111, 898);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 38);
            this.SaveButton.TabIndex = 41;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PriorityCombobox
            // 
            this.PriorityCombobox.FormattingEnabled = true;
            this.PriorityCombobox.Location = new System.Drawing.Point(14, 908);
            this.PriorityCombobox.Name = "PriorityCombobox";
            this.PriorityCombobox.Size = new System.Drawing.Size(214, 38);
            this.PriorityCombobox.TabIndex = 42;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Crimson;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(960, 898);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 38);
            this.BackButton.TabIndex = 43;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(616, 218);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(233, 38);
            this.CategoryCombobox.TabIndex = 78;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CategoryLabel.Location = new System.Drawing.Point(507, 231);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(92, 25);
            this.CategoryLabel.TabIndex = 77;
            this.CategoryLabel.Text = "Category:";
            // 
            // ConfirmCombobox
            // 
            this.ConfirmCombobox.FormattingEnabled = true;
            this.ConfirmCombobox.Location = new System.Drawing.Point(616, 166);
            this.ConfirmCombobox.Name = "ConfirmCombobox";
            this.ConfirmCombobox.Size = new System.Drawing.Size(233, 38);
            this.ConfirmCombobox.TabIndex = 76;
            // 
            // ConfirmationStatusLabel
            // 
            this.ConfirmationStatusLabel.AutoSize = true;
            this.ConfirmationStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationStatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConfirmationStatusLabel.Location = new System.Drawing.Point(417, 179);
            this.ConfirmationStatusLabel.Name = "ConfirmationStatusLabel";
            this.ConfirmationStatusLabel.Size = new System.Drawing.Size(182, 25);
            this.ConfirmationStatusLabel.TabIndex = 75;
            this.ConfirmationStatusLabel.Text = "Confirmation Status:";
            // 
            // LabelsCombobox
            // 
            this.LabelsCombobox.FormattingEnabled = true;
            this.LabelsCombobox.Location = new System.Drawing.Point(616, 116);
            this.LabelsCombobox.Name = "LabelsCombobox";
            this.LabelsCombobox.Size = new System.Drawing.Size(233, 38);
            this.LabelsCombobox.TabIndex = 74;
            // 
            // LabelsLabel
            // 
            this.LabelsLabel.AutoSize = true;
            this.LabelsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelsLabel.Location = new System.Drawing.Point(530, 126);
            this.LabelsLabel.Name = "LabelsLabel";
            this.LabelsLabel.Size = new System.Drawing.Size(69, 25);
            this.LabelsLabel.TabIndex = 73;
            this.LabelsLabel.Text = "Labels:";
            // 
            // FixedCombobox
            // 
            this.FixedCombobox.FormattingEnabled = true;
            this.FixedCombobox.Location = new System.Drawing.Point(1041, 218);
            this.FixedCombobox.Name = "FixedCombobox";
            this.FixedCombobox.Size = new System.Drawing.Size(233, 38);
            this.FixedCombobox.TabIndex = 72;
            // 
            // FixedLabel
            // 
            this.FixedLabel.AutoSize = true;
            this.FixedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FixedLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FixedLabel.Location = new System.Drawing.Point(898, 231);
            this.FixedLabel.Name = "FixedLabel";
            this.FixedLabel.Size = new System.Drawing.Size(128, 25);
            this.FixedLabel.TabIndex = 71;
            this.FixedLabel.Text = "Fixed Version:";
            // 
            // ResolutionCombobox
            // 
            this.ResolutionCombobox.FormattingEnabled = true;
            this.ResolutionCombobox.Location = new System.Drawing.Point(1041, 169);
            this.ResolutionCombobox.Name = "ResolutionCombobox";
            this.ResolutionCombobox.Size = new System.Drawing.Size(233, 38);
            this.ResolutionCombobox.TabIndex = 70;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ResolutionLabel.Location = new System.Drawing.Point(922, 176);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(104, 25);
            this.ResolutionLabel.TabIndex = 69;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Location = new System.Drawing.Point(1041, 122);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(233, 38);
            this.StatusCombobox.TabIndex = 68;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StatusLabel.Location = new System.Drawing.Point(960, 127);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 25);
            this.StatusLabel.TabIndex = 67;
            this.StatusLabel.Text = "Status:";
            // 
            // VersionCheckedListbox
            // 
            this.VersionCheckedListbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.VersionCheckedListbox.FormattingEnabled = true;
            this.VersionCheckedListbox.Location = new System.Drawing.Point(195, 164);
            this.VersionCheckedListbox.Name = "VersionCheckedListbox";
            this.VersionCheckedListbox.Size = new System.Drawing.Size(214, 124);
            this.VersionCheckedListbox.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(113, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 79;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(195, 68);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(214, 34);
            this.TitleTextBox.TabIndex = 80;
            // 
            // BugReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 972);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.VersionCheckedListbox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriorityCombobox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AttatchmentRichTextbox);
            this.Controls.Add(this.PriorityLable);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.AttatchmentLabel);
            this.Controls.Add(this.EnvironmentCombobox);
            this.Controls.Add(this.EnvironmentLabel);
            this.Controls.Add(this.DescriptionTextbox);
            this.Controls.Add(this.ApplicationCombobox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.FormHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BugReportForm";
            this.Text = "Create a Bug report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox ApplicationCombobox;
        private Label IDLabel;
        private Label VersionLabel;
        private Label ApplicationLabel;
        private Label FormHeader;
        private TextBox DescriptionTextbox;
        private Label EnvironmentLabel;
        private ComboBox EnvironmentCombobox;
        private Label AttatchmentLabel;
        private Button UploadButton;
        private Label PriorityLable;
        private RichTextBox AttatchmentRichTextbox;
        private Button SaveButton;
        private ComboBox PriorityCombobox;
        private Button BackButton;
        private ComboBox CategoryCombobox;
        private Label CategoryLabel;
        private ComboBox ConfirmCombobox;
        private Label ConfirmationStatusLabel;
        private ComboBox LabelsCombobox;
        private Label LabelsLabel;
        private ComboBox FixedCombobox;
        private Label FixedLabel;
        private ComboBox ResolutionCombobox;
        private Label ResolutionLabel;
        private ComboBox StatusCombobox;
        private Label StatusLabel;
        private CheckedListBox VersionCheckedListbox;
        private Label label1;
        private TextBox TitleTextBox;
    }
}