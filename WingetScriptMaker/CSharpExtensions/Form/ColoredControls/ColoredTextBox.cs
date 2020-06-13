using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColoredTextBox : TextBox
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResumeLayout(false);
        }
        public ColoredTextBox()
        {
            InitializeComponent();
            BackColor = ColorChanger.ColorPrimary;
            ForeColor = ColorChanger.ColorText;
            ColorChanger.ColorChanged += UpdateColor;
            UpdateColor();
        }

        public void UpdateColor()
        {
            BackColor = ColorChanger.ColorPrimary;
            ForeColor = ColorChanger.ColorText;
        }
    }
}

