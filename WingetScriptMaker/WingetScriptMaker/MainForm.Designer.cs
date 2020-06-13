namespace WingetScriptMaker
{
    partial class MainForm
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
            this.buttonCreateFile = new CSharpExtensions.Form.ColoredControls.ColoredButton();
            this.appsLabel = new System.Windows.Forms.Label();
            this.appList = new CSharpExtensions.Form.ColoredControls.ColoredListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRefreshList = new CSharpExtensions.Form.ColoredControls.ColoredButton();
            this.buttonUnselectAll = new CSharpExtensions.Form.ColoredControls.ColoredButton();
            this.ButtonRunScript = new CSharpExtensions.Form.ColoredControls.ColoredButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonInstallApps = new CSharpExtensions.Form.ColoredControls.ColoredButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new CSharpExtensions.Form.ColoredControls.ColoredComboBox();
            this.SuspendLayout();
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCreateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.buttonCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCreateFile.Location = new System.Drawing.Point(676, 537);
            this.buttonCreateFile.Margin = new System.Windows.Forms.Padding(8);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Raised = true;
            this.buttonCreateFile.Size = new System.Drawing.Size(150, 50);
            this.buttonCreateFile.TabIndex = 0;
            this.buttonCreateFile.Text = "Create Script File";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.ButtonCreateFile_Click);
            // 
            // appsLabel
            // 
            this.appsLabel.AutoSize = true;
            this.appsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appsLabel.Location = new System.Drawing.Point(12, 40);
            this.appsLabel.Name = "appsLabel";
            this.appsLabel.Size = new System.Drawing.Size(50, 20);
            this.appsLabel.TabIndex = 1;
            this.appsLabel.Text = "Apps:";
            // 
            // appList
            // 
            this.appList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.appList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.appList.FormattingEnabled = true;
            this.appList.ItemHeight = 20;
            this.appList.Location = new System.Drawing.Point(12, 63);
            this.appList.Name = "appList";
            this.appList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.appList.Size = new System.Drawing.Size(814, 464);
            this.appList.TabIndex = 2;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bat";
            this.saveFileDialog.FileName = "script";
            this.saveFileDialog.Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save Generated Script File";
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRefreshList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRefreshList.Location = new System.Drawing.Point(12, 537);
            this.buttonRefreshList.Margin = new System.Windows.Forms.Padding(8);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Raised = true;
            this.buttonRefreshList.Size = new System.Drawing.Size(150, 50);
            this.buttonRefreshList.TabIndex = 3;
            this.buttonRefreshList.Text = "Refresh List";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.ButtonRefreshList_Click);
            // 
            // buttonUnselectAll
            // 
            this.buttonUnselectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUnselectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.buttonUnselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnselectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUnselectAll.Location = new System.Drawing.Point(178, 537);
            this.buttonUnselectAll.Margin = new System.Windows.Forms.Padding(8);
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.Raised = true;
            this.buttonUnselectAll.Size = new System.Drawing.Size(150, 50);
            this.buttonUnselectAll.TabIndex = 4;
            this.buttonUnselectAll.Text = "Unselect All";
            this.buttonUnselectAll.UseVisualStyleBackColor = true;
            this.buttonUnselectAll.Click += new System.EventHandler(this.ButtonUnselectAll_Click);
            // 
            // ButtonRunScript
            // 
            this.ButtonRunScript.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonRunScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.ButtonRunScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRunScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRunScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonRunScript.Location = new System.Drawing.Point(510, 537);
            this.ButtonRunScript.Margin = new System.Windows.Forms.Padding(8);
            this.ButtonRunScript.Name = "ButtonRunScript";
            this.ButtonRunScript.Raised = true;
            this.ButtonRunScript.Size = new System.Drawing.Size(150, 50);
            this.ButtonRunScript.TabIndex = 5;
            this.ButtonRunScript.Text = "Run Existing Script";
            this.ButtonRunScript.UseVisualStyleBackColor = true;
            this.ButtonRunScript.Click += new System.EventHandler(this.ButtonRunScript_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*";
            // 
            // buttonInstallApps
            // 
            this.buttonInstallApps.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonInstallApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(221)))), ((int)(((byte)(23)))));
            this.buttonInstallApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstallApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInstallApps.Location = new System.Drawing.Point(344, 537);
            this.buttonInstallApps.Margin = new System.Windows.Forms.Padding(8);
            this.buttonInstallApps.Name = "buttonInstallApps";
            this.buttonInstallApps.Raised = true;
            this.buttonInstallApps.Size = new System.Drawing.Size(150, 50);
            this.buttonInstallApps.TabIndex = 6;
            this.buttonInstallApps.Text = "Install Selected Apps";
            this.buttonInstallApps.UseVisualStyleBackColor = true;
            this.buttonInstallApps.Click += new System.EventHandler(this.ButtonInstallApps_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearch.Location = new System.Drawing.Point(82, 10);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(513, 26);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchLabel.Location = new System.Drawing.Point(12, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 20);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "Search:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterLabel.Location = new System.Drawing.Point(601, 14);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(48, 20);
            this.filterLabel.TabIndex = 9;
            this.filterLabel.Text = "Filter:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Application Name",
            "Application Id"});
            this.filterComboBox.Location = new System.Drawing.Point(655, 11);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(171, 28);
            this.filterComboBox.TabIndex = 10;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 601);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonInstallApps);
            this.Controls.Add(this.ButtonRunScript);
            this.Controls.Add(this.buttonUnselectAll);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.appsLabel);
            this.Controls.Add(this.buttonCreateFile);
            this.Name = "MainForm";
            this.Text = "Winget Script Maker";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharpExtensions.Form.ColoredControls.ColoredButton buttonCreateFile;
        private System.Windows.Forms.Label appsLabel;
        private CSharpExtensions.Form.ColoredControls.ColoredListBox appList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private CSharpExtensions.Form.ColoredControls.ColoredButton buttonRefreshList;
        private CSharpExtensions.Form.ColoredControls.ColoredButton buttonUnselectAll;
        private CSharpExtensions.Form.ColoredControls.ColoredButton ButtonRunScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CSharpExtensions.Form.ColoredControls.ColoredButton buttonInstallApps;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label filterLabel;
        private CSharpExtensions.Form.ColoredControls.ColoredComboBox filterComboBox;
    }
}

