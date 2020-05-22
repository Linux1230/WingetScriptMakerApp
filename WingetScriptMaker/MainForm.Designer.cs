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
            this.SuspendLayout();
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateFile.Location = new System.Drawing.Point(500, 393);
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
            this.appsLabel.Location = new System.Drawing.Point(12, 9);
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
            this.appList.Location = new System.Drawing.Point(12, 32);
            this.appList.Name = "appList";
            this.appList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.appList.Size = new System.Drawing.Size(608, 344);
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
            this.buttonRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefreshList.Location = new System.Drawing.Point(12, 393);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(120, 40);
            this.buttonRefreshList.TabIndex = 3;
            this.buttonRefreshList.Text = "Refresh List";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.ButtonRefreshList_Click);
            // 
            // buttonUnselectAll
            // 
            this.buttonUnselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUnselectAll.Location = new System.Drawing.Point(138, 393);
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.Size = new System.Drawing.Size(120, 40);
            this.buttonUnselectAll.TabIndex = 4;
            this.buttonUnselectAll.Text = "Unselect All";
            this.buttonUnselectAll.UseVisualStyleBackColor = true;
            this.buttonUnselectAll.Click += new System.EventHandler(this.ButtonUnselectAll_Click);
            // 
            // ButtonRunScript
            // 
            this.ButtonRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRunScript.Location = new System.Drawing.Point(374, 393);
            this.ButtonRunScript.Name = "ButtonRunScript";
            this.ButtonRunScript.Size = new System.Drawing.Size(120, 40);
            this.ButtonRunScript.TabIndex = 5;
            this.ButtonRunScript.Text = "Run existing script";
            this.ButtonRunScript.UseVisualStyleBackColor = true;
            this.ButtonRunScript.Click += new System.EventHandler(this.ButtonRunScript_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Batch files (*.bat)|*.bat|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 441);
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

        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Label appsLabel;
        private System.Windows.Forms.ListBox appList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button buttonUnselectAll;
        private System.Windows.Forms.Button ButtonRunScript;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

