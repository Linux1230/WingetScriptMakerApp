namespace CSharpExtensions.Form.ColoredControls
{
    partial class ColorPaletteDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.color1 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            this.SuspendLayout();
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(2, 2);
            this.color1.Margin = new System.Windows.Forms.Padding(0);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(32, 32);
            this.color1.TabIndex = 0;
            this.color1.TabStop = false;
            this.color1.Click += new System.EventHandler(this.Color_Click);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(34, 2);
            this.color2.Margin = new System.Windows.Forms.Padding(0);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(32, 32);
            this.color2.TabIndex = 1;
            this.color2.TabStop = false;
            this.color2.Click += new System.EventHandler(this.Color_Click);
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(2, 34);
            this.color3.Margin = new System.Windows.Forms.Padding(0);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(32, 32);
            this.color3.TabIndex = 2;
            this.color3.TabStop = false;
            this.color3.Click += new System.EventHandler(this.Color_Click);
            // 
            // color4
            // 
            this.color4.Location = new System.Drawing.Point(34, 34);
            this.color4.Margin = new System.Windows.Forms.Padding(0);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(32, 32);
            this.color4.TabIndex = 3;
            this.color4.TabStop = false;
            this.color4.Click += new System.EventHandler(this.Color_Click);
            // 
            // ColorPaletteDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Name = "ColorPaletteDisplay";
            this.Size = new System.Drawing.Size(68, 68);
            this.Load += new System.EventHandler(this.ColorPaletteDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.PictureBox color4;
    }
}
