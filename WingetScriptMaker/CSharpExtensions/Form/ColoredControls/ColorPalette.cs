using System.Drawing;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColorPalette
    {
        public Color ColorBackground { get; set; }

        public Color ColorPrimary { get; set; }

        public Color ColorAccent { get; set; }

        public Color ColorText { get; set; }

        public ColorPalette() { }

        public ColorPalette(Color colorBackground, Color colorPrimary, Color colorAccent, Color colorText)
        {
            ColorBackground = colorBackground;
            ColorPrimary = colorPrimary;
            ColorAccent = colorAccent;
            ColorText = colorText;
        }
    }
}
