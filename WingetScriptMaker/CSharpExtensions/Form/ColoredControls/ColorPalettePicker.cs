using System;
using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public partial class ColorPalettePicker : UserControl
    {
        public ColorPalettePicker()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                AllowFullOpen = false,
                ShowHelp = true,
                Color = (sender as PictureBox).BackColor
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (sender as PictureBox).BackColor = colorDialog.Color;
                (sender as PictureBox).Tag = true;
            }
        }

        public bool GetPaletteIsValid()
        {
            bool isValid = true;
            foreach (var item in Controls)
            {
                if (item.GetType() == pictureBox1.GetType() && isValid)
                {
                    if ((item as PictureBox).Tag == null || !(bool)(item as PictureBox).Tag)
                    {
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        public ColorPalette GetColorPalette()
        {
            return new ColorPalette(pictureBox1.BackColor, pictureBox2.BackColor, pictureBox3.BackColor, pictureBox4.BackColor);
        }

        public void SetColorPalette(ColorPalette colorPalette)
        {
            if (colorPalette != null)
            {
                pictureBox1.BackColor = colorPalette.ColorBackground;
                pictureBox1.Tag = true;
                pictureBox2.BackColor = colorPalette.ColorPrimary;
                pictureBox2.Tag = true;
                pictureBox3.BackColor = colorPalette.ColorAccent;
                pictureBox3.Tag = true;
                pictureBox4.BackColor = colorPalette.ColorText;
                pictureBox4.Tag = true;
            }
        }

        private void ColorPalettePicker_Load(object sender, EventArgs e)
        {
            if (ColorChanger.CustomColorPalette != null)
                SetColorPalette(ColorChanger.CustomColorPalette);
        }
    }
}
