using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    class ColoredNumericUpDown : NumericUpDown
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredNumericUpDown
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResumeLayout(false);

        }
        public ColoredNumericUpDown()
        {
            InitializeComponent();
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

