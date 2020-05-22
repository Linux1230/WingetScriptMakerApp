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
using System.Globalization;

using CSharp.Extension;

namespace WingetScriptMaker
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<string> CurrantAppNames;

        private void LoadAppNames()
        {
            CurrantAppNames = CMD.WingetSearch();
        }

        private void FillAppList(List<string> apps)
        {
            appList.Items.Clear();
            foreach (var item in apps)
            {
                appList.Items.Add(item);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadAppNames();
            FillAppList(CurrantAppNames);
        }

        private void ButtonRefreshList_Click(object sender, EventArgs e)
        {
            LoadAppNames();
        }

        private void ButtonUnselectAll_Click(object sender, EventArgs e)
        {
            appList.SelectedItems.Clear();
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
                            Script.Create(appList.SelectedItems.OfType<string>().ToList(), saveFileDialog.FileName);
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

        private void ButtonRunScript_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Experimental feature, script file will be not validated!");
            if (dialogResult == DialogResult.OK)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            //CMD.WingetRunScript(Script.Load(openFileDialog.FileName));
                            CMD.WingetRunScript(openFileDialog.FileName);
                            MessageBox.Show($"{openFileDialog.FileName} successfully opened!");
                        }
                        else
                            MessageBox.Show($"You must provide a file!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }
            }
        }

        private void ButtonInstallApps_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Selected Apps will be installed to your computer.");
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    if (appList.SelectedItems != null)
                    {
                        foreach (var item in appList.SelectedItems.OfType<string>().ToList())
                        {
                            CMD.WingetInstall(item);
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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<String> result = CurrantAppNames.Where(x => x.ContainsCaseInsensitive(textBoxSearch.Text)).ToList();
            FillAppList(result);
        }
    }
}
