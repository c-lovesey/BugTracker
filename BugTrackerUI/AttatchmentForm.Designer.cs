namespace BugTrackerUI
{
    partial class AttachmentForm
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
            this.listViewAttatchments = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewAttatchments
            // 
            this.listViewAttatchments.Location = new System.Drawing.Point(12, 12);
            this.listViewAttatchments.Name = "listViewAttatchments";
            this.listViewAttatchments.Size = new System.Drawing.Size(1117, 711);
            this.listViewAttatchments.TabIndex = 0;
            this.listViewAttatchments.UseCompatibleStateImageBehavior = false;
            this.listViewAttatchments.SelectedIndexChanged += new System.EventHandler(this.listViewAttatchments_SelectedIndexChanged);
            // 
            // AttatchmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 735);
            this.Controls.Add(this.listViewAttatchments);
            this.Name = "AttatchmentForm";
            this.Text = "AttatchmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewAttatchments;
    }
}