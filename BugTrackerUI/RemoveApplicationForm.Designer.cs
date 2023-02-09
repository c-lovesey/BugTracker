namespace BugTrackerUI
{
    partial class RemoveApplicationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveApplicationForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ApplicationDataGridView = new System.Windows.Forms.DataGridView();
            this.ApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(315, 47);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Remove Application";
            // 
            // ApplicationDataGridView
            // 
            this.ApplicationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ApplicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationName,
            this.ApplicationVersion,
            this.ApplicationID});
            this.ApplicationDataGridView.Location = new System.Drawing.Point(26, 103);
            this.ApplicationDataGridView.Name = "ApplicationDataGridView";
            this.ApplicationDataGridView.RowTemplate.Height = 25;
            this.ApplicationDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ApplicationDataGridView.Size = new System.Drawing.Size(1057, 666);
            this.ApplicationDataGridView.TabIndex = 1;
            this.ApplicationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationDataGridView_CellContentClick);
            // 
            // ApplicationName
            // 
            this.ApplicationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplicationName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ApplicationName.FillWeight = 200F;
            this.ApplicationName.HeaderText = "Name";
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Width = 94;
            // 
            // ApplicationVersion
            // 
            this.ApplicationVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ApplicationVersion.FillWeight = 200F;
            this.ApplicationVersion.HeaderText = "Version";
            this.ApplicationVersion.Name = "ApplicationVersion";
            this.ApplicationVersion.Width = 106;
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ApplicationID.FillWeight = 200F;
            this.ApplicationID.HeaderText = "ID";
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Width = 59;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Crimson;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Location = new System.Drawing.Point(501, 811);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 38);
            this.RemoveButton.TabIndex = 73;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 900);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ApplicationDataGridView);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RemoveApplicationForm";
            this.Text = "Remove Application";
            this.Load += new System.EventHandler(this.RemoveApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private DataGridView ApplicationDataGridView;
        private DataGridViewTextBoxColumn ApplicationName;
        private DataGridViewTextBoxColumn ApplicationVersion;
        private DataGridViewTextBoxColumn ApplicationID;
        private Button RemoveButton;
    }
}