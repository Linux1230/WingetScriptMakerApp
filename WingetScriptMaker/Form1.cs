using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingetScriptMaker
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            foreach (var item in CMD.WingetSearch())
            {
                appList.Items.Add(item);
            }
        }

        private void ButtonCreateFile_Click(object sender, EventArgs e)
        {
            IO.WriteFile("script.bat", ScriptCreate.CreateScript(appList.SelectedItems.OfType<string>().ToList()));
        }
    }
}
