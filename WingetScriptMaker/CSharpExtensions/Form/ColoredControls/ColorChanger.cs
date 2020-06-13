using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CSharpExtensions.Form.ColoredControls
{
    public static class ColorChanger
    {
        public static List<ColorPalette> colorPreset = new List<ColorPalette>()
        {
            new ColorPalette(Color.FromArgb(38, 50, 56), Color.FromArgb(69, 90, 100), Color.FromArgb(221, 44, 0), Color.FromArgb(255, 255, 255)),
            new ColorPalette(Color.FromArgb(33, 33, 33), Color.FromArgb(66, 66, 66), Color.FromArgb(100, 221, 23), Color.FromArgb(255, 255, 255)),
            new ColorPalette(Color.FromArgb(0, 0, 0), Color.FromArgb(33, 33, 33), Color.FromArgb(159, 39, 161), Color.FromArgb(255, 255, 255)),
            new ColorPalette(Color.FromArgb(10, 1, 39), Color.FromArgb(42, 2, 168), Color.FromArgb(180, 162, 0), Color.FromArgb(251, 249, 255))
        };

        public static ColorPalette CustomColorPalette { get; private set; }
        public static bool UseCustomColorPalette { get; set; } = false;

        public static int SelectedColorPalette { get; private set; } = 1;
        public static Color ColorBackground { get; private set; } = colorPreset[SelectedColorPalette].ColorBackground;
        public static Color ColorPrimary { get; private set; } = colorPreset[SelectedColorPalette].ColorPrimary;
        public static Color ColorAccent { get; private set; } = colorPreset[SelectedColorPalette].ColorAccent;
        public static Color ColorText { get; private set; } = colorPreset[SelectedColorPalette].ColorText;

        public static event Action ColorChanged;

        public static void SetSelectedColorPalette(int index) { SelectedColorPalette = index; ColorChanged(); }
        public static void SetCustomColorPalette(ColorPalette colorPalette) { CustomColorPalette = new ColorPalette(colorPalette.ColorBackground, colorPalette.ColorPrimary, colorPalette.ColorAccent, colorPalette.ColorText); }

        public static void ForceUpdate()
        {
            SetColorPalette();
            ColorChanged();
        }

        public static void SetColorPalette()
        {
            if (!UseCustomColorPalette)
            {
                ColorBackground = colorPreset[SelectedColorPalette].ColorBackground;
                ColorPrimary = colorPreset[SelectedColorPalette].ColorPrimary;
                ColorAccent = colorPreset[SelectedColorPalette].ColorAccent;
                ColorText = colorPreset[SelectedColorPalette].ColorText;
            }
            else
            {
                ColorBackground = CustomColorPalette.ColorBackground;
                ColorPrimary = CustomColorPalette.ColorPrimary;
                ColorAccent = CustomColorPalette.ColorAccent;
                ColorText = CustomColorPalette.ColorText;
            }
        }
    }
}
