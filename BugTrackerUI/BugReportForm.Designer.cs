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
            this.VersionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ApplicationCombobox
            // 
            this.ApplicationCombobox.FormattingEnabled = true;
            this.ApplicationCombobox.Location = new System.Drawing.Point(200, 95);
            this.ApplicationCombobox.Name = "ApplicationCombobox";
            this.ApplicationCombobox.Size = new System.Drawing.Size(214, 38);
            this.ApplicationCombobox.TabIndex = 29;
            this.ApplicationCombobox.SelectedIndexChanged += new System.EventHandler(this.ApplicationCombobox_SelectedIndexChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IDLabel.Location = new System.Drawing.Point(12, 228);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(190, 30);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "Description of Bug:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.VersionLabel.Location = new System.Drawing.Point(12, 171);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(157, 30);
            this.VersionLabel.TabIndex = 25;
            this.VersionLabel.Text = "Affects Version:";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ApplicationLabel.Location = new System.Drawing.Point(12, 103);
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
            this.DescriptionTextbox.Location = new System.Drawing.Point(12, 271);
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
            this.EnvironmentLabel.Location = new System.Drawing.Point(12, 430);
            this.EnvironmentLabel.Name = "EnvironmentLabel";
            this.EnvironmentLabel.Size = new System.Drawing.Size(135, 30);
            this.EnvironmentLabel.TabIndex = 34;
            this.EnvironmentLabel.Text = "Environment:";
            this.EnvironmentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnvironmentCombobox
            // 
            this.EnvironmentCombobox.FormattingEnabled = true;
            this.EnvironmentCombobox.Location = new System.Drawing.Point(14, 472);
            this.EnvironmentCombobox.Name = "EnvironmentCombobox";
            this.EnvironmentCombobox.Size = new System.Drawing.Size(267, 38);
            this.EnvironmentCombobox.TabIndex = 35;
            // 
            // AttatchmentLabel
            // 
            this.AttatchmentLabel.AutoSize = true;
            this.AttatchmentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AttatchmentLabel.Location = new System.Drawing.Point(12, 530);
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
            this.PriorityLable.Location = new System.Drawing.Point(13, 778);
            this.PriorityLable.Name = "PriorityLable";
            this.PriorityLable.Size = new System.Drawing.Size(83, 30);
            this.PriorityLable.TabIndex = 38;
            this.PriorityLable.Text = "Priority:";
            this.PriorityLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // AttatchmentRichTextbox
            // 
            this.AttatchmentRichTextbox.Location = new System.Drawing.Point(14, 563);
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
            this.SaveButton.Location = new System.Drawing.Point(772, 826);
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
            this.PriorityCombobox.Location = new System.Drawing.Point(14, 826);
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
            this.BackButton.Location = new System.Drawing.Point(551, 826);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(130, 38);
            this.BackButton.TabIndex = 43;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // VersionComboBox
            // 
            this.VersionComboBox.FormattingEnabled = true;
            this.VersionComboBox.Location = new System.Drawing.Point(200, 168);
            this.VersionComboBox.Name = "VersionComboBox";
            this.VersionComboBox.Size = new System.Drawing.Size(214, 38);
            this.VersionComboBox.TabIndex = 44;
            // 
            // BugReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.VersionComboBox);
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
        private ComboBox VersionComboBox;
    }
}