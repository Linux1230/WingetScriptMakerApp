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
using CSharpExtensions.IO;

namespace WingetScriptMaker
{
    public partial class WingetCMD : UserControl
    {
        public WingetCMD()
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

        #region Variables
        private List<AppEntity> CurrantApps { get; set; }
        private List<AppEntity> SelectedApps { get; set; }
        #endregion

        #region Methods
        private List<AppEntity> LoadAppNames()
        {
            return Winget.Search();
        }

        private AppEntity FindApp(string app)
        {
            return CurrantApps.Find(x => x.Name.Contains(app) || x.Id.Contains(app));
        }

        private void FillAppList(List<AppEntity> apps, int filter)
        {
            appList.Items.Clear();
            foreach (var item in apps)
            {
                appList.Items.Add(filter == 0 ? item.Name : item.Id);
            }
        }

        private List<string> GetSelectedAppsFromList()
        {
            return appList.SelectedItems.OfType<string>().ToList();
        }

        private void LoadingError()
        {
            Messages.ShowError("Unexpected error occurred, application restarting!");
            Application.Restart();
        }

        private void AutoSelectApps(List<AppEntity> apps)
        {
            foreach (var item in apps)
            {
                if (appList.Items.Contains(item.Name))
                {
                    appList.SetSelected(appList.Items.IndexOf(item.Name), true);
                }
                else if (appList.Items.Contains(item.Id))
                {
                    appList.SetSelected(appList.Items.IndexOf(item.Id), true);
                }
            }
        }

        private List<AppEntity> LoadAppsFromFile(List<string> script)
        {
            List<AppEntity> apps = new List<AppEntity>();
            script.RemoveRange(0, 2);
            int i = 0;
            while (script.Count > 0 & script[i] != "")
            {
                apps.Add(FindApp(script[i].Substring(5)));
                i++;
            }
            return apps;
        }
        #endregion

        #region Events
        private void Form_Load(object sender, EventArgs e)
        {
            CurrantApps = LoadAppNames();
            FillAppList(CurrantApps, 0);
            SelectedApps = new List<AppEntity>();
            if (appList.Items.Contains(""))
                LoadingError();
            filterComboBox.SelectedIndex = 0;
        }

        private void ButtonRefreshList_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Messages.ShowQuestionYesNo("Refreshing the list removes all selection! Would you continue?");
            if (dialogResult == DialogResult.Yes)
            {
                appList.Items.Clear();
                appList.Items.Add("List is refreshing...");
                FillAppList(LoadAppNames(), filterComboBox.SelectedIndex);
            }
        }

        private void ButtonUnselectAll_Click(object sender, EventArgs e)
        {
            if (SelectedApps != null)
                SelectedApps.Clear();
            if (appList != null)
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
                            WingetScript.Create(GetSelectedAppsFromList(), saveFileDialog.FileName);
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

        private void ButtonLoadScript_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Messages.ShowDialogOkCancel("Experimental feature, script file will be not validated! This feature works only if the script file was generated by this application!");
            if (dialogResult == DialogResult.OK)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (openFileDialog.FileName != "")
                        {
                            AutoSelectApps(LoadAppsFromFile(IO.ReadFile(openFileDialog.FileName)));
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
                        foreach (var item in GetSelectedAppsFromList())
                        {
                            AppEntity app = FindApp(item);
                            dialogResult = Messages.ShowDialogOkCancel($"Name: {app.Name}\nId: {app.Id}\nVersion: {app.Version}\nThis application will be installed to your computer.");
                            if (dialogResult == DialogResult.OK)
                            {
                                Winget.Install(item);
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
            if (SelectedApps.Count != 0)
            {
                List<AppEntity> temp = new List<AppEntity>();
                temp.AddRange(SelectedApps);
                if (SelectedApps != null)
                    SelectedApps.Clear();
                AutoSelectApps(temp);
            }
        }

        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> apps = GetSelectedAppsFromList();
            if (apps != null)
            {
                //need some optimalization
                SelectedApps.Clear();
                foreach (var item in apps)
                {
                    AppEntity temp = FindApp(item);
                    SelectedApps.Add(temp);
                }
            }
        }
        #endregion
    }
}
