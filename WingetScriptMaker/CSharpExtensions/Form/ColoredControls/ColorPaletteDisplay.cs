using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public partial class ColorPaletteDisplay : UserControl
    {
        public ColorPaletteDisplay()
        {
            InitializeComponent();
            BackColor = Color.Black;
        }
        public int ColorPaletteIndex { get => colorPaletteIndex; set { colorPaletteIndex = value; } }
        int colorPaletteIndex = 0;
        public bool Selected { get => selected; set { selected = value; Selecting(); } }
        bool selected = false;

        private void Selecting()
        {
            if (Selected)
                BackColor = ColorChanger.colorPreset[colorPaletteIndex].ColorAccent;
            else
                BackColor = Color.Black;
        }

        private void ColorPaletteDisplay_Load(object sender, EventArgs e)
        {
            color1.BackColor = ColorChanger.colorPreset[colorPaletteIndex].ColorBackground;
            color2.BackColor = ColorChanger.colorPreset[colorPaletteIndex].ColorPrimary;
            color3.BackColor = ColorChanger.colorPreset[colorPaletteIndex].ColorAccent;
            color4.BackColor = ColorChanger.colorPreset[colorPaletteIndex].ColorText;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
