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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Winget = new System.Windows.Forms.TabPage();
            this.wingetCMD = new WingetScriptMaker.WingetCMD();
            this.Other = new System.Windows.Forms.TabPage();
            this.otherCMD = new WingetScriptMaker.OtherCMD.OtherCMD();
            this.tabControl.SuspendLayout();
            this.Winget.SuspendLayout();
            this.Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Winget);
            this.tabControl.Controls.Add(this.Other);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(852, 633);
            this.tabControl.TabIndex = 0;
            // 
            // Winget
            // 
            this.Winget.Controls.Add(this.wingetCMD);
            this.Winget.Location = new System.Drawing.Point(4, 22);
            this.Winget.Name = "Winget";
            this.Winget.Padding = new System.Windows.Forms.Padding(3);
            this.Winget.Size = new System.Drawing.Size(844, 607);
            this.Winget.TabIndex = 0;
            this.Winget.Text = "Winget";
            this.Winget.UseVisualStyleBackColor = true;
            // 
            // wingetCMD
            // 
            this.wingetCMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wingetCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wingetCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wingetCMD.Location = new System.Drawing.Point(3, 3);
            this.wingetCMD.MinimumSize = new System.Drawing.Size(838, 601);
            this.wingetCMD.Name = "wingetCMD";
            this.wingetCMD.Size = new System.Drawing.Size(838, 601);
            this.wingetCMD.TabIndex = 0;
            // 
            // Other
            // 
            this.Other.Controls.Add(this.otherCMD);
            this.Other.Location = new System.Drawing.Point(4, 22);
            this.Other.Name = "Other";
            this.Other.Padding = new System.Windows.Forms.Padding(3);
            this.Other.Size = new System.Drawing.Size(844, 607);
            this.Other.TabIndex = 1;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // otherCMD
            // 
            this.otherCMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.otherCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otherCMD.Location = new System.Drawing.Point(3, 3);
            this.otherCMD.MinimumSize = new System.Drawing.Size(838, 601);
            this.otherCMD.Name = "otherCMD";
            this.otherCMD.Size = new System.Drawing.Size(838, 601);
            this.otherCMD.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 633);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(868, 672);
            this.Name = "MainForm";
            this.Text = "Winget Script Maker";
            this.tabControl.ResumeLayout(false);
            this.Winget.ResumeLayout(false);
            this.Other.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Winget;
        private System.Windows.Forms.TabPage Other;
        private WingetCMD wingetCMD;
        private OtherCMD.OtherCMD otherCMD;
    }
}

