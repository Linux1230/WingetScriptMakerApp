using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpExtensions.Form.ColoredControls;
using CSharpExtensions.IO;
using CSharpExtensions.Form.CustomMessageBox;
using CSharpExtensions.RunProcess;

namespace WingetScriptMaker.OtherCMD
{
    public partial class OtherCMD : UserControl
    {
        public OtherCMD()
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

        private void OtherCMD_Load(object sender, EventArgs e)
        {
                try
                {
                    List<string> files = DesignMode ? new List<string>() : IO.GetFileNamesFromFolder($@"Batch");
                    foreach (var item in files)
                    {
                        ColoredButton cb = new ColoredButton
                        {
                            Width = 150,
                            Height = 50,
                            Name = item,
                            Text = item
                        };
                        cb.Click += new EventHandler(RunSelectedScript);
                        flowLayoutPanel1.Controls.Add(cb);
                    }
                }
                catch (Exception ex)
                {
                    Messages.ShowError($"Error: {ex}");
                }
        }

        private void RunSelectedScript(object sender, EventArgs e)
        {
            try
            {
                RunProcess.BatchScript($@"{IO.GetExePath()}/Batch/{(sender as ColoredButton).Name}");
            }
            catch (Exception ex)
            {
                Messages.ShowError($"Error: {ex}");
            }
        }
    }
}
