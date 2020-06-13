using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColoredListBox : ListBox
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredListBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResumeLayout(false);
        }

        public ColoredListBox()
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
