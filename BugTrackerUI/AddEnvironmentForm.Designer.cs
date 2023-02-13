namespace BugTrackerUI
{
    partial class AddEnvironmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEnvironmentForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Label();
            this.EnvironmentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(183, 166);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 56);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NameLabel.Location = new System.Drawing.Point(12, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Name:";
            // 
            // FormHeader
            // 
            this.FormHeader.AutoSize = true;
            this.FormHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormHeader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormHeader.Location = new System.Drawing.Point(45, 9);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(411, 47);
            this.FormHeader.TabIndex = 23;
            this.FormHeader.Text = "Register New Environment";
            this.FormHeader.Click += new System.EventHandler(this.FormHeader_Click);
            // 
            // EnvironmentTextBox
            // 
            this.EnvironmentTextBox.Location = new System.Drawing.Point(82, 100);
            this.EnvironmentTextBox.Name = "EnvironmentTextBox";
            this.EnvironmentTextBox.Size = new System.Drawing.Size(342, 23);
            this.EnvironmentTextBox.TabIndex = 33;
            // 
            // AddEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.EnvironmentTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FormHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEnvironmentForm";
            this.Text = "AddEnvironmentForm";
            this.Load += new System.EventHandler(this.AddEnvironmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SaveButton;
        private Label NameLabel;
        private Label FormHeader;
        private TextBox EnvironmentTextBox;
    }
}