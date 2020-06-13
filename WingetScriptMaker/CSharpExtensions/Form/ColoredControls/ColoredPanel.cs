using System.Drawing;
using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColoredPanel : Panel
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColoredPanel
            // 
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ResumeLayout(false);
        }

        public ColoredPanel()
        {
            InitializeComponent();
            ColorChanger.ColorChanged += UpdateColor;
            UpdateColor();
        }

        public bool Primary { get => primary; set { primary = value; UpdateColor(); } }
        bool primary;

        public bool ColoredBorder { get => coloredBordert; set { coloredBordert = value; UpdateColor(); } }
        bool coloredBordert;

        public void UpdateColor()
        {
            if (primary)
            {
                BackColor = ColorChanger.ColorPrimary;
                ForeColor = ColorChanger.ColorText;
            }
            else
            {
                BackColor = ColorChanger.ColorBackground;
                ForeColor = ColorChanger.ColorText;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ColoredBorder)
            {
                ControlPaint.DrawBorder(e.Graphics, new Rectangle(0, 0, Width, Height), ColorChanger.ColorAccent, ButtonBorderStyle.Solid);
            }
        }
    }
}
