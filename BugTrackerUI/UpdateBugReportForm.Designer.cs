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
            this.DetailsLabel = new System.Windows.Forms.Label();
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
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.PriorityCombobox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AttatchmentRichTextbox = new System.Windows.Forms.RichTextBox();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.AttatchmentLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveSelectedCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DetailsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DetailsLabel.Location = new System.Drawing.Point(20, 79);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(82, 30);
            this.DetailsLabel.TabIndex = 44;
            this.DetailsLabel.Text = "Details:";
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
            this.AffectedLabel.Location = new System.Drawing.Point(66, 129);
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
            this.AffectedCheckedListbox.Location = new System.Drawing.Point(264, 129);
            this.AffectedCheckedListbox.Name = "AffectedCheckedListbox";
            this.AffectedCheckedListbox.Size = new System.Drawing.Size(162, 124);
            this.AffectedCheckedListbox.TabIndex = 48;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StatusLabel.Location = new System.Drawing.Point(591, 136);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 25);
            this.StatusLabel.TabIndex = 49;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Location = new System.Drawing.Point(743, 129);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(233, 38);
            this.StatusCombobox.TabIndex = 50;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ResolutionLabel.Location = new System.Drawing.Point(591, 180);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(104, 25);
            this.ResolutionLabel.TabIndex = 51;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // ResolutionCombobox
            // 
            this.ResolutionCombobox.FormattingEnabled = true;
            this.ResolutionCombobox.Location = new System.Drawing.Point(743, 173);
            this.ResolutionCombobox.Name = "ResolutionCombobox";
            this.ResolutionCombobox.Size = new System.Drawing.Size(233, 38);
            this.ResolutionCombobox.TabIndex = 52;
            // 
            // FixedCombobox
            // 
            this.FixedCombobox.FormattingEnabled = true;
            this.FixedCombobox.Location = new System.Drawing.Point(743, 217);
            this.FixedCombobox.Name = "FixedCombobox";
            this.FixedCombobox.Size = new System.Drawing.Size(233, 38);
            this.FixedCombobox.TabIndex = 56;
            // 
            // FixedLabel
            // 
            this.FixedLabel.AutoSize = true;
            this.FixedLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FixedLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FixedLabel.Location = new System.Drawing.Point(591, 224);
            this.FixedLabel.Name = "FixedLabel";
            this.FixedLabel.Size = new System.Drawing.Size(128, 25);
            this.FixedLabel.TabIndex = 55;
            this.FixedLabel.Text = "Fixed Version:";
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(254, 396);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(233, 38);
            this.CategoryCombobox.TabIndex = 63;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CategoryLabel.Location = new System.Drawing.Point(66, 403);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(92, 25);
            this.CategoryLabel.TabIndex = 62;
            this.CategoryLabel.Text = "Category:";
            // 
            // ConfirmCombobox
            // 
            this.ConfirmCombobox.FormattingEnabled = true;
            this.ConfirmCombobox.Location = new System.Drawing.Point(254, 352);
            this.ConfirmCombobox.Name = "ConfirmCombobox";
            this.ConfirmCombobox.Size = new System.Drawing.Size(233, 38);
            this.ConfirmCombobox.TabIndex = 61;
            // 
            // ConfirmationStatusLabel
            // 
            this.ConfirmationStatusLabel.AutoSize = true;
            this.ConfirmationStatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationStatusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConfirmationStatusLabel.Location = new System.Drawing.Point(66, 359);
            this.ConfirmationStatusLabel.Name = "ConfirmationStatusLabel";
            this.ConfirmationStatusLabel.Size = new System.Drawing.Size(182, 25);
            this.ConfirmationStatusLabel.TabIndex = 60;
            this.ConfirmationStatusLabel.Text = "Confirmation Status:";
            // 
            // LabelsCombobox
            // 
            this.LabelsCombobox.FormattingEnabled = true;
            this.LabelsCombobox.Location = new System.Drawing.Point(254, 308);
            this.LabelsCombobox.Name = "LabelsCombobox";
            this.LabelsCombobox.Size = new System.Drawing.Size(233, 38);
            this.LabelsCombobox.TabIndex = 59;
            // 
            // LabelsLabel
            // 
            this.LabelsLabel.AutoSize = true;
            this.LabelsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LabelsLabel.Location = new System.Drawing.Point(66, 315);
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
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 455);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(127, 30);
            this.DescriptionLabel.TabIndex = 64;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(20, 488);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(888, 146);
            this.DescriptionTextbox.TabIndex = 65;
            // 
            // PriorityCombobox
            // 
            this.PriorityCombobox.FormattingEnabled = true;
            this.PriorityCombobox.Location = new System.Drawing.Point(20, 872);
            this.PriorityCombobox.Name = "PriorityCombobox";
            this.PriorityCombobox.Size = new System.Drawing.Size(214, 38);
            this.PriorityCombobox.TabIndex = 71;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(914, 872);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 38);
            this.SaveButton.TabIndex = 70;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // AttatchmentRichTextbox
            // 
            this.AttatchmentRichTextbox.Location = new System.Drawing.Point(20, 677);
            this.AttatchmentRichTextbox.Name = "AttatchmentRichTextbox";
            this.AttatchmentRichTextbox.Size = new System.Drawing.Size(888, 141);
            this.AttatchmentRichTextbox.TabIndex = 69;
            this.AttatchmentRichTextbox.Text = "";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PriorityLabel.Location = new System.Drawing.Point(19, 824);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(83, 30);
            this.PriorityLabel.TabIndex = 68;
            this.PriorityLabel.Text = "Priority:";
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UploadButton.Location = new System.Drawing.Point(914, 692);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(130, 38);
            this.UploadButton.TabIndex = 67;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            // 
            // AttatchmentLabel
            // 
            this.AttatchmentLabel.AutoSize = true;
            this.AttatchmentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AttatchmentLabel.Location = new System.Drawing.Point(18, 644);
            this.AttatchmentLabel.Name = "AttatchmentLabel";
            this.AttatchmentLabel.Size = new System.Drawing.Size(134, 30);
            this.AttatchmentLabel.TabIndex = 66;
            this.AttatchmentLabel.Text = "Attatchment:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Crimson;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(914, 736);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 38);
            this.RemoveButton.TabIndex = 72;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            // 
            // RemoveSelectedCombobox
            // 
            this.RemoveSelectedCombobox.FormattingEnabled = true;
            this.RemoveSelectedCombobox.Location = new System.Drawing.Point(914, 780);
            this.RemoveSelectedCombobox.Name = "RemoveSelectedCombobox";
            this.RemoveSelectedCombobox.Size = new System.Drawing.Size(130, 38);
            this.RemoveSelectedCombobox.TabIndex = 73;
            // 
            // UpdateBugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 940);
            this.Controls.Add(this.RemoveSelectedCombobox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.PriorityCombobox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AttatchmentRichTextbox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.AttatchmentLabel);
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
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.FormHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UpdateBugReport";
            this.Text = "Update Bug Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label DetailsLabel;
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
        private TextBox DescriptionTextbox;
        private ComboBox PriorityCombobox;
        private Button SaveButton;
        private RichTextBox AttatchmentRichTextbox;
        private Label PriorityLabel;
        private Button UploadButton;
        private Label AttatchmentLabel;
        private Button RemoveButton;
        private ComboBox RemoveSelectedCombobox;
    }
}