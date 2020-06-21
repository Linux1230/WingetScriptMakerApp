using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpExtensions.Form.CustomMessageBox;
using CSharpExtensions.Form.ColoredControls;
using CSharpExtensions.String;

namespace WingetScriptMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateColorAction();
        }

        #region UI
        private void UpdateColorAction()
        {
            ColorChanger.ColorChanged += UpdateColor;
            ColorChanger.ForceUpdate();
        }

        private void UpdateColor()
        {
            this.BackColor = ColorChanger.ColorBackground;
            this.ForeColor = ColorChanger.ColorText;
        }
        #endregion
    }
}
