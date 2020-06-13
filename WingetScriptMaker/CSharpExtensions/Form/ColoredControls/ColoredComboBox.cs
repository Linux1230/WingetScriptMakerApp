using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColoredComboBox : ComboBox
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredComboBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResumeLayout(false);
        }

        public ColoredComboBox()
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
