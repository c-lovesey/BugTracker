namespace BugTrackerUI
{
    partial class CreateApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateApplicationForm));
            this.FormHeader = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ConfirmCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.AutoSize = true;
            this.FormHeader.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormHeader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormHeader.Location = new System.Drawing.Point(12, 9);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(368, 47);
            this.FormHeader.TabIndex = 0;
            this.FormHeader.Text = "Create New Application";
            this.FormHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NameLabel.Location = new System.Drawing.Point(12, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IDLabel.Location = new System.Drawing.Point(12, 166);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(98, 30);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "Letter ID:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(109, 100);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(271, 35);
            this.NameTextbox.TabIndex = 5;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(109, 163);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(271, 35);
            this.IDTextbox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(273, 244);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 56);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfirmCheckbox
            // 
            this.ConfirmCheckbox.AutoSize = true;
            this.ConfirmCheckbox.BackColor = System.Drawing.Color.White;
            this.ConfirmCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmCheckbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConfirmCheckbox.Location = new System.Drawing.Point(46, 256);
            this.ConfirmCheckbox.Name = "ConfirmCheckbox";
            this.ConfirmCheckbox.Size = new System.Drawing.Size(193, 34);
            this.ConfirmCheckbox.TabIndex = 9;
            this.ConfirmCheckbox.Text = "Confirm changes";
            this.ConfirmCheckbox.UseVisualStyleBackColor = false;
            // 
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 404);
            this.Controls.Add(this.ConfirmCheckbox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FormHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateApplicationForm";
            this.Text = "Create New Application";
            this.Load += new System.EventHandler(this.CreateApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FormHeader;
        private Label NameLabel;
        private Label IDLabel;
        private TextBox NameTextbox;
        private TextBox IDTextbox;
        private Button SaveButton;
        private CheckBox ConfirmCheckbox;
    }
}