using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public partial class ColoredButton : Button
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredButton
            // 
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(100, 30);
            this.ResumeLayout(false);
        }
        public ColoredButton()
        {
            InitializeComponent();
            ColorChanger.ColorChanged += UpdateColor;
            UpdateColor();
        }

        public bool Raised { get => raised; set { raised = value; UpdateColor(); } }

        bool raised = true;

        public void UpdateColor()
        {
            if (raised)
            {
                BackColor = ColorChanger.ColorAccent;
                ForeColor = ColorChanger.ColorText;
            }
            else
            {
                if (Parent != null) BackColor = Parent.BackColor;
                ForeColor = ColorChanger.ColorAccent;
            }
        }
    }
}
