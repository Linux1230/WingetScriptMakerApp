namespace WingetScriptMaker
{
    partial class Form
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
            this.SuspendLayout();
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(12, 415);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(104, 23);
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
            this.appList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appList.FormattingEnabled = true;
            this.appList.ItemHeight = 20;
            this.appList.Location = new System.Drawing.Point(15, 48);
            this.appList.Name = "appList";
            this.appList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.appList.Size = new System.Drawing.Size(613, 344);
            this.appList.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.appsLabel);
            this.Controls.Add(this.buttonCreateFile);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Label appsLabel;
        private System.Windows.Forms.ListBox appList;
    }
}

