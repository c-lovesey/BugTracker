namespace BugTrackerUI
{
    partial class BugViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugViewerForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.BugListbox = new System.Windows.Forms.ListBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.ApplicationVersionLabel = new System.Windows.Forms.Label();
            this.ApplicationLogoPicturebox = new System.Windows.Forms.PictureBox();
            this.BugIDLabel = new System.Windows.Forms.Label();
            this.BugTitleLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.BugDetailsLabel = new System.Windows.Forms.Label();
            this.BugDescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AttatchmentsLabel = new System.Windows.Forms.Label();
            this.AttatchmentRichtextbox = new System.Windows.Forms.RichTextBox();
            this.BugLinkLabel = new System.Windows.Forms.Label();
            this.RelatedBugsLabel = new System.Windows.Forms.Label();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.ApplicationCombobox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.SearchButtom = new System.Windows.Forms.Button();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.ResolutionCombobox = new System.Windows.Forms.ComboBox();
            this.NavigationGroupbox = new System.Windows.Forms.GroupBox();
            this.NavigationRemoveReportLabel = new System.Windows.Forms.Label();
            this.NavigationRemoveVersionLabel = new System.Windows.Forms.Label();
            this.NavigationRemoveApplicatonLabel = new System.Windows.Forms.Label();
            this.NavigationNewVersionLabel = new System.Windows.Forms.Label();
            this.NavigationNewApplicationLabel = new System.Windows.Forms.Label();
            this.NavigationUpdateReportLabel = new System.Windows.Forms.Label();
            this.NavigationNewReportLabel = new System.Windows.Forms.Label();
            this.NavigationSearchLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationLogoPicturebox)).BeginInit();
            this.NavigationGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(237, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(109, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Search";
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BugListbox
            // 
            this.BugListbox.FormattingEnabled = true;
            this.BugListbox.ItemHeight = 30;
            this.BugListbox.Location = new System.Drawing.Point(237, 228);
            this.BugListbox.Name = "BugListbox";
            this.BugListbox.Size = new System.Drawing.Size(263, 694);
            this.BugListbox.TabIndex = 10;
            this.BugListbox.SelectedIndexChanged += new System.EventHandler(this.BugListbox_SelectedIndexChanged);
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Location = new System.Drawing.Point(237, 186);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(184, 30);
            this.OrderByLabel.TabIndex = 11;
            this.OrderByLabel.Text = "Order By Updated:";
            // 
            // ApplicationVersionLabel
            // 
            this.ApplicationVersionLabel.AutoSize = true;
            this.ApplicationVersionLabel.Location = new System.Drawing.Point(688, 186);
            this.ApplicationVersionLabel.Name = "ApplicationVersionLabel";
            this.ApplicationVersionLabel.Size = new System.Drawing.Size(218, 30);
            this.ApplicationVersionLabel.TabIndex = 14;
            this.ApplicationVersionLabel.Text = "<Application version>";
            // 
            // ApplicationLogoPicturebox
            // 
            this.ApplicationLogoPicturebox.Location = new System.Drawing.Point(537, 186);
            this.ApplicationLogoPicturebox.Name = "ApplicationLogoPicturebox";
            this.ApplicationLogoPicturebox.Size = new System.Drawing.Size(139, 119);
            this.ApplicationLogoPicturebox.TabIndex = 15;
            this.ApplicationLogoPicturebox.TabStop = false;
            // 
            // BugIDLabel
            // 
            this.BugIDLabel.AutoSize = true;
            this.BugIDLabel.Location = new System.Drawing.Point(898, 186);
            this.BugIDLabel.Name = "BugIDLabel";
            this.BugIDLabel.Size = new System.Drawing.Size(98, 30);
            this.BugIDLabel.TabIndex = 16;
            this.BugIDLabel.Text = "<BugID>";
            // 
            // BugTitleLabel
            // 
            this.BugTitleLabel.AutoSize = true;
            this.BugTitleLabel.Location = new System.Drawing.Point(688, 228);
            this.BugTitleLabel.Name = "BugTitleLabel";
            this.BugTitleLabel.Size = new System.Drawing.Size(122, 30);
            this.BugTitleLabel.TabIndex = 17;
            this.BugTitleLabel.Text = "<Bug Title>";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(537, 342);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(81, 30);
            this.DetailsLabel.TabIndex = 18;
            this.DetailsLabel.Text = "Details:";
            // 
            // BugDetailsLabel
            // 
            this.BugDetailsLabel.AutoSize = true;
            this.BugDetailsLabel.Location = new System.Drawing.Point(537, 396);
            this.BugDetailsLabel.Name = "BugDetailsLabel";
            this.BugDetailsLabel.Size = new System.Drawing.Size(140, 30);
            this.BugDetailsLabel.TabIndex = 19;
            this.BugDetailsLabel.Text = "<BugDetails>";
            // 
            // BugDescriptionLabel
            // 
            this.BugDescriptionLabel.AutoSize = true;
            this.BugDescriptionLabel.Location = new System.Drawing.Point(537, 505);
            this.BugDescriptionLabel.Name = "BugDescriptionLabel";
            this.BugDescriptionLabel.Size = new System.Drawing.Size(182, 30);
            this.BugDescriptionLabel.TabIndex = 21;
            this.BugDescriptionLabel.Text = "<BugDescription>";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(537, 451);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(123, 30);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Description:";
            // 
            // AttatchmentsLabel
            // 
            this.AttatchmentsLabel.AutoSize = true;
            this.AttatchmentsLabel.Location = new System.Drawing.Point(537, 568);
            this.AttatchmentsLabel.Name = "AttatchmentsLabel";
            this.AttatchmentsLabel.Size = new System.Drawing.Size(143, 30);
            this.AttatchmentsLabel.TabIndex = 22;
            this.AttatchmentsLabel.Text = "Attatchments:";
            // 
            // AttatchmentRichtextbox
            // 
            this.AttatchmentRichtextbox.Location = new System.Drawing.Point(537, 617);
            this.AttatchmentRichtextbox.Name = "AttatchmentRichtextbox";
            this.AttatchmentRichtextbox.Size = new System.Drawing.Size(961, 158);
            this.AttatchmentRichtextbox.TabIndex = 23;
            this.AttatchmentRichtextbox.Text = "";
            // 
            // BugLinkLabel
            // 
            this.BugLinkLabel.AutoSize = true;
            this.BugLinkLabel.Location = new System.Drawing.Point(537, 860);
            this.BugLinkLabel.Name = "BugLinkLabel";
            this.BugLinkLabel.Size = new System.Drawing.Size(123, 30);
            this.BugLinkLabel.TabIndex = 25;
            this.BugLinkLabel.Text = "<BugLinks>";
            // 
            // RelatedBugsLabel
            // 
            this.RelatedBugsLabel.AutoSize = true;
            this.RelatedBugsLabel.Location = new System.Drawing.Point(537, 806);
            this.RelatedBugsLabel.Name = "RelatedBugsLabel";
            this.RelatedBugsLabel.Size = new System.Drawing.Size(138, 30);
            this.RelatedBugsLabel.TabIndex = 24;
            this.RelatedBugsLabel.Text = "Related Bugs:";
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchTextbox.Location = new System.Drawing.Point(995, 61);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(150, 35);
            this.SearchTextbox.TabIndex = 1;
            this.SearchTextbox.Text = "Contains Text";
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(247, 64);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(123, 30);
            this.ApplicationLabel.TabIndex = 2;
            this.ApplicationLabel.Text = "Application:";
            // 
            // ApplicationCombobox
            // 
            this.ApplicationCombobox.FormattingEnabled = true;
            this.ApplicationCombobox.Location = new System.Drawing.Point(371, 61);
            this.ApplicationCombobox.Name = "ApplicationCombobox";
            this.ApplicationCombobox.Size = new System.Drawing.Size(121, 38);
            this.ApplicationCombobox.TabIndex = 3;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(498, 64);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(61, 30);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type:";
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(565, 61);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(121, 38);
            this.CategoryCombobox.TabIndex = 5;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(692, 64);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(74, 30);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Location = new System.Drawing.Point(772, 61);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(121, 38);
            this.StatusCombobox.TabIndex = 7;
            // 
            // SearchButtom
            // 
            this.SearchButtom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButtom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButtom.Location = new System.Drawing.Point(1179, 60);
            this.SearchButtom.Name = "SearchButtom";
            this.SearchButtom.Size = new System.Drawing.Size(97, 38);
            this.SearchButtom.TabIndex = 9;
            this.SearchButtom.Text = "Search";
            this.SearchButtom.UseVisualStyleBackColor = false;
            this.SearchButtom.Click += new System.EventHandler(this.SearchButtom_Click);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(247, 125);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(115, 30);
            this.ResolutionLabel.TabIndex = 12;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // ResolutionCombobox
            // 
            this.ResolutionCombobox.FormattingEnabled = true;
            this.ResolutionCombobox.Location = new System.Drawing.Point(371, 122);
            this.ResolutionCombobox.Name = "ResolutionCombobox";
            this.ResolutionCombobox.Size = new System.Drawing.Size(121, 38);
            this.ResolutionCombobox.TabIndex = 13;
            // 
            // NavigationGroupbox
            // 
            this.NavigationGroupbox.Controls.Add(this.NavigationRemoveReportLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationRemoveVersionLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationRemoveApplicatonLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationNewVersionLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationNewApplicationLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationUpdateReportLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationNewReportLabel);
            this.NavigationGroupbox.Controls.Add(this.NavigationSearchLabel);
            this.NavigationGroupbox.Location = new System.Drawing.Point(12, 12);
            this.NavigationGroupbox.Name = "NavigationGroupbox";
            this.NavigationGroupbox.Size = new System.Drawing.Size(219, 910);
            this.NavigationGroupbox.TabIndex = 26;
            this.NavigationGroupbox.TabStop = false;
            this.NavigationGroupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NavigationRemoveReportLabel
            // 
            this.NavigationRemoveReportLabel.AutoSize = true;
            this.NavigationRemoveReportLabel.Location = new System.Drawing.Point(6, 158);
            this.NavigationRemoveReportLabel.Name = "NavigationRemoveReportLabel";
            this.NavigationRemoveReportLabel.Size = new System.Drawing.Size(196, 30);
            this.NavigationRemoveReportLabel.TabIndex = 10;
            this.NavigationRemoveReportLabel.Text = "Remove Bug Report";
            // 
            // NavigationRemoveVersionLabel
            // 
            this.NavigationRemoveVersionLabel.AutoSize = true;
            this.NavigationRemoveVersionLabel.Location = new System.Drawing.Point(6, 244);
            this.NavigationRemoveVersionLabel.Name = "NavigationRemoveVersionLabel";
            this.NavigationRemoveVersionLabel.Size = new System.Drawing.Size(161, 30);
            this.NavigationRemoveVersionLabel.TabIndex = 9;
            this.NavigationRemoveVersionLabel.Text = "Remove Version";
            // 
            // NavigationRemoveApplicatonLabel
            // 
            this.NavigationRemoveApplicatonLabel.AutoSize = true;
            this.NavigationRemoveApplicatonLabel.Location = new System.Drawing.Point(6, 288);
            this.NavigationRemoveApplicatonLabel.Name = "NavigationRemoveApplicatonLabel";
            this.NavigationRemoveApplicatonLabel.Size = new System.Drawing.Size(198, 30);
            this.NavigationRemoveApplicatonLabel.TabIndex = 8;
            this.NavigationRemoveApplicatonLabel.Text = "Remove Application";
            // 
            // NavigationNewVersionLabel
            // 
            this.NavigationNewVersionLabel.AutoSize = true;
            this.NavigationNewVersionLabel.Location = new System.Drawing.Point(6, 202);
            this.NavigationNewVersionLabel.Name = "NavigationNewVersionLabel";
            this.NavigationNewVersionLabel.Size = new System.Drawing.Size(169, 30);
            this.NavigationNewVersionLabel.TabIndex = 6;
            this.NavigationNewVersionLabel.Text = "Add new Version";
            // 
            // NavigationNewApplicationLabel
            // 
            this.NavigationNewApplicationLabel.AutoSize = true;
            this.NavigationNewApplicationLabel.Location = new System.Drawing.Point(6, 330);
            this.NavigationNewApplicationLabel.Name = "NavigationNewApplicationLabel";
            this.NavigationNewApplicationLabel.Size = new System.Drawing.Size(210, 30);
            this.NavigationNewApplicationLabel.TabIndex = 5;
            this.NavigationNewApplicationLabel.Text = "Add New Application";
            // 
            // NavigationUpdateReportLabel
            // 
            this.NavigationUpdateReportLabel.AutoSize = true;
            this.NavigationUpdateReportLabel.Location = new System.Drawing.Point(6, 113);
            this.NavigationUpdateReportLabel.Name = "NavigationUpdateReportLabel";
            this.NavigationUpdateReportLabel.Size = new System.Drawing.Size(189, 30);
            this.NavigationUpdateReportLabel.TabIndex = 3;
            this.NavigationUpdateReportLabel.Text = "Update Bug Report";
            // 
            // NavigationNewReportLabel
            // 
            this.NavigationNewReportLabel.AutoSize = true;
            this.NavigationNewReportLabel.Location = new System.Drawing.Point(6, 71);
            this.NavigationNewReportLabel.Name = "NavigationNewReportLabel";
            this.NavigationNewReportLabel.Size = new System.Drawing.Size(188, 30);
            this.NavigationNewReportLabel.TabIndex = 1;
            this.NavigationNewReportLabel.Text = "Create New Report";
            // 
            // NavigationSearchLabel
            // 
            this.NavigationSearchLabel.AutoSize = true;
            this.NavigationSearchLabel.Location = new System.Drawing.Point(6, 31);
            this.NavigationSearchLabel.Name = "NavigationSearchLabel";
            this.NavigationSearchLabel.Size = new System.Drawing.Size(75, 30);
            this.NavigationSearchLabel.TabIndex = 0;
            this.NavigationSearchLabel.Text = "Search";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(919, 66);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(57, 30);
            this.TitleLabel.TabIndex = 27;
            this.TitleLabel.Text = "Title:";
            // 
            // BugViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 938);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NavigationGroupbox);
            this.Controls.Add(this.BugLinkLabel);
            this.Controls.Add(this.RelatedBugsLabel);
            this.Controls.Add(this.AttatchmentRichtextbox);
            this.Controls.Add(this.AttatchmentsLabel);
            this.Controls.Add(this.BugDescriptionLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.BugDetailsLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.BugTitleLabel);
            this.Controls.Add(this.BugIDLabel);
            this.Controls.Add(this.ApplicationLogoPicturebox);
            this.Controls.Add(this.ApplicationVersionLabel);
            this.Controls.Add(this.ResolutionCombobox);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.OrderByLabel);
            this.Controls.Add(this.BugListbox);
            this.Controls.Add(this.SearchButtom);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CategoryCombobox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ApplicationCombobox);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BugViewerForm";
            this.Text = "Bug Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationLogoPicturebox)).EndInit();
            this.NavigationGroupbox.ResumeLayout(false);
            this.NavigationGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private ListBox BugListbox;
        private Label OrderByLabel;
        private Label ApplicationVersionLabel;
        private PictureBox ApplicationLogoPicturebox;
        private Label BugIDLabel;
        private Label BugTitleLabel;
        private Label DetailsLabel;
        private Label BugDetailsLabel;
        private Label BugDescriptionLabel;
        private Label DescriptionLabel;
        private Label AttatchmentsLabel;
        private RichTextBox AttatchmentRichtextbox;
        private Label BugLinkLabel;
        private Label RelatedBugsLabel;
        private TextBox SearchTextbox;
        private Label ApplicationLabel;
        private ComboBox ApplicationCombobox;
        private Label TypeLabel;
        private ComboBox CategoryCombobox;
        private Label StatusLabel;
        private ComboBox StatusCombobox;
        private Button SearchButtom;
        private Label ResolutionLabel;
        private ComboBox ResolutionCombobox;
        private GroupBox NavigationGroupbox;
        private Label NavigationNewReportLabel;
        private Label NavigationSearchLabel;
        private Label NavigationRemoveReportLabel;
        private Label NavigationRemoveVersionLabel;
        private Label NavigationRemoveApplicatonLabel;
        private Label NavigationNewVersionLabel;
        private Label NavigationNewApplicationLabel;
        private Label NavigationUpdateReportLabel;
        private Label TitleLabel;
    }
}