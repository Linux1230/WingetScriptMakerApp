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
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.appsLabel = new System.Windows.Forms.Label();
            this.appList = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.buttonUnselectAll = new System.Windows.Forms.Button();
            this.ButtonRunScript = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonInstallApps = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCreateFile.Location = new System.Drawing.Point(516, 453);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(120, 40);
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
            this.appList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appList.FormattingEnabled = true;
            this.appList.ItemHeight = 20;
            this.appList.Location = new System.Drawing.Point(12, 63);
            this.appList.Name = "appList";
            this.appList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.appList.Size = new System.Drawing.Size(624, 384);
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
            this.buttonRefreshList.Location = new System.Drawing.Point(12, 453);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(120, 40);
            this.buttonRefreshList.TabIndex = 3;
            this.buttonRefreshList.Text = "Refresh List";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.ButtonRefreshList_Click);
            // 
            // buttonUnselectAll
            // 
            this.buttonUnselectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUnselectAll.Location = new System.Drawing.Point(138, 453);
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.Size = new System.Drawing.Size(120, 40);
            this.buttonUnselectAll.TabIndex = 4;
            this.buttonUnselectAll.Text = "Unselect All";
            this.buttonUnselectAll.UseVisualStyleBackColor = true;
            this.buttonUnselectAll.Click += new System.EventHandler(this.ButtonUnselectAll_Click);
            // 
            // ButtonRunScript
            // 
            this.ButtonRunScript.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonRunScript.Location = new System.Drawing.Point(390, 453);
            this.ButtonRunScript.Name = "ButtonRunScript";
            this.ButtonRunScript.Size = new System.Drawing.Size(120, 40);
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
            this.buttonInstallApps.Location = new System.Drawing.Point(264, 453);
            this.buttonInstallApps.Name = "buttonInstallApps";
            this.buttonInstallApps.Size = new System.Drawing.Size(120, 40);
            this.buttonInstallApps.TabIndex = 6;
            this.buttonInstallApps.Text = "Install Selected Apps";
            this.buttonInstallApps.UseVisualStyleBackColor = true;
            this.buttonInstallApps.Click += new System.EventHandler(this.ButtonInstallApps_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(82, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(240, 20);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 20);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "Search:";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterLabel.Location = new System.Drawing.Point(342, 9);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(48, 20);
            this.filterLabel.TabIndex = 9;
            this.filterLabel.Text = "Filter:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Application Name",
            "Application Id"});
            this.filterComboBox.Location = new System.Drawing.Point(396, 8);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(240, 21);
            this.filterComboBox.TabIndex = 10;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 501);
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
            this.MinimumSize = new System.Drawing.Size(664, 540);
            this.Name = "MainForm";
            this.Text = "Winget Script Maker";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Label appsLabel;
        private System.Windows.Forms.ListBox appList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button buttonUnselectAll;
        private System.Windows.Forms.Button ButtonRunScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonInstallApps;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}

