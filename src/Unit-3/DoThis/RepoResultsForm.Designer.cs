namespace GithubActors
{
    partial class RepoResultsForm
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
            dgUsers = new System.Windows.Forms.DataGridView();
            Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RepoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            URL = new System.Windows.Forms.DataGridViewLinkColumn();
            Shared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Issues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Forks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgUsers
            // 
            dgUsers.AllowUserToOrderColumns = true;
            dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Owner, RepoName, URL, Shared, Issues, Stars, Forks });
            dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgUsers.Location = new System.Drawing.Point(0, 0);
            dgUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgUsers.Name = "dgUsers";
            dgUsers.Size = new System.Drawing.Size(862, 372);
            dgUsers.TabIndex = 0;
            // 
            // Owner
            // 
            Owner.HeaderText = "Owner";
            Owner.Name = "Owner";
            // 
            // RepoName
            // 
            RepoName.HeaderText = "Name";
            RepoName.Name = "RepoName";
            // 
            // URL
            // 
            URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            URL.HeaderText = "URL";
            URL.Name = "URL";
            // 
            // Shared
            // 
            Shared.HeaderText = "SharedStars";
            Shared.Name = "Shared";
            // 
            // Issues
            // 
            Issues.HeaderText = "Open Issues";
            Issues.Name = "Issues";
            // 
            // Stars
            // 
            Stars.HeaderText = "Stars";
            Stars.Name = "Stars";
            // 
            // Forks
            // 
            Forks.HeaderText = "Forks";
            Forks.Name = "Forks";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsProgress, tsStatus });
            statusStrip1.Location = new System.Drawing.Point(0, 348);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(862, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            tsProgress.Name = "tsProgress";
            tsProgress.Size = new System.Drawing.Size(117, 18);
            tsProgress.Visible = false;
            // 
            // tsStatus
            // 
            tsStatus.Name = "tsStatus";
            tsStatus.Size = new System.Drawing.Size(73, 19);
            tsStatus.Text = "Processing...";
            tsStatus.Visible = false;
            // 
            // RepoResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(862, 372);
            Controls.Add(statusStrip1);
            Controls.Add(dgUsers);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RepoResultsForm";
            Text = "Repos Similar to {RepoName}";
            FormClosing += RepoResultsForm_FormClosing;
            Load += RepoResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepoName;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shared;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forks;
    }
}