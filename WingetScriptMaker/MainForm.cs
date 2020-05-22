using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WingetScriptMaker
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
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
            try
            {
                if (appList.SelectedItems != null)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            List<string> cmd = Script.Create(appList.SelectedItems.OfType<string>().ToList());
                            IO.WriteFile(saveFileDialog.FileName, cmd);
                            MessageBox.Show($"{saveFileDialog.FileName} successfully created!");
                        }
                        else
                            MessageBox.Show($"You must provide a filename!");
                    }
                }
                 else
                    MessageBox.Show($"Please choose at least one application from the list!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
    }
}
