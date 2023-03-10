namespace BugTrackerUI
{
    partial class AddVersionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVersionForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Label();
            this.ApplicationCombobox = new System.Windows.Forms.ComboBox();
            this.VersionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(255, 244);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 56);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.VersionLabel.Location = new System.Drawing.Point(12, 171);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(86, 30);
            this.VersionLabel.TabIndex = 12;
            this.VersionLabel.Text = "Version:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NameLabel.Location = new System.Drawing.Point(12, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 30);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Application:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // FormHeader
            // 
            this.FormHeader.AutoSize = true;
            this.FormHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormHeader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormHeader.Location = new System.Drawing.Point(41, 9);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(311, 47);
            this.FormHeader.TabIndex = 10;
            this.FormHeader.Text = "Create New Version";
            // 
            // ApplicationCombobox
            // 
            this.ApplicationCombobox.FormattingEnabled = true;
            this.ApplicationCombobox.Location = new System.Drawing.Point(148, 100);
            this.ApplicationCombobox.Name = "ApplicationCombobox";
            this.ApplicationCombobox.Size = new System.Drawing.Size(214, 38);
            this.ApplicationCombobox.TabIndex = 19;
            this.ApplicationCombobox.SelectedIndexChanged += new System.EventHandler(this.ApplicationCombobox_SelectedIndexChanged);
            // 
            // VersionTextbox
            // 
            this.VersionTextbox.Location = new System.Drawing.Point(148, 171);
            this.VersionTextbox.Name = "VersionTextbox";
            this.VersionTextbox.Size = new System.Drawing.Size(214, 35);
            this.VersionTextbox.TabIndex = 22;
            // 
            // AddVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 329);
            this.Controls.Add(this.VersionTextbox);
            this.Controls.Add(this.ApplicationCombobox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FormHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddVersionForm";
            this.Text = "Create New Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SaveButton;
        private Label VersionLabel;
        private Label NameLabel;
        private Label FormHeader;
        private ComboBox ApplicationCombobox;
        private TextBox VersionTextbox;
    }
}