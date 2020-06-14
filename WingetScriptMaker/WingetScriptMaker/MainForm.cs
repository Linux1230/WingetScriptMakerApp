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
using System.Runtime.CompilerServices;
using CSharpExtensions.JSON;

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

        private List<AppEntity> CurrantApps { get; set; }

        private List<AppEntity> LoadAppNames()
        {
            return CMD.WingetSearch();
        }

        private AppEntity FindApp(string app)
        {
            return CurrantApps.Find(x => x.Name == app || x.Id == app);
        }

        private void FillAppList(List<AppEntity> apps, int filter)
        {
            appList.Items.Clear();
            foreach (var item in apps)
            {
                appList.Items.Add(filter == 0 ? item.Name : item.Id);
            }
        }

        private void LoadingError()
        {
            Messages.ShowError("Unexpected error occurred, application restarting!");
            Application.Restart();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CurrantApps = LoadAppNames();
            FillAppList(CurrantApps, 0);
            if (appList.Items == null)
                LoadingError();
            filterComboBox.SelectedIndex = 0;
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
                            Messages.ShowInformation($"{saveFileDialog.FileName} successfully created!");
                        }
                        else
                            Messages.ShowError($"You must provide a filename!");
                    }
                }
                 else
                    Messages.ShowError($"Please choose at least one application from the list!");
            }
            catch (Exception ex)
            {
                Messages.ShowError($"Error: {ex}");
            }
        }

        private void ButtonRunScript_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Messages.ShowDialogOkCancel("Experimental feature, script file will be not validated!");
            if (dialogResult == DialogResult.OK)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            CMD.WingetRunScript(openFileDialog.FileName);
                            Messages.ShowInformation($"{openFileDialog.FileName} successfully opened!");
                        }
                        else
                            Messages.ShowError($"You must provide a file!");
                    }
                    catch (Exception ex)
                    {
                        Messages.ShowError($"Error: {ex}");
                    }
                }
            }
        }

        private void ButtonInstallApps_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Messages.ShowDialogOkCancel("Selected Apps will be installed to your computer.");
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    if (appList.SelectedItems != null)
                    {
                        foreach (var item in appList.SelectedItems.OfType<string>().ToList())
                        {
                            AppEntity app = FindApp(item);
                            dialogResult = Messages.ShowDialogOkCancel($"Name: {app.Name}\nId: {app.Id}\nVersion: {app.Version}\nThis application will be installed to your computer.");
                            if (dialogResult == DialogResult.OK)
                            {
                                CMD.WingetInstall(item);
                            }
                        }
                    }
                    else
                        Messages.ShowError($"Please choose at least one application from the list!");
                }
                catch (Exception ex)
                {
                    Messages.ShowError($"Error: {ex}");
                }
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillAppList(
                filterComboBox.SelectedIndex == 0 ?
                CurrantApps.Where(x => x.Name.ContainsCaseInsensitive(textBoxSearch.Text)).ToList() :
                CurrantApps.Where(x => x.Id.ContainsCaseInsensitive(textBoxSearch.Text)).ToList(),
                filterComboBox.SelectedIndex
                );
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAppList(CurrantApps, (sender as ComboBox).SelectedIndex);
        }
    }
}
