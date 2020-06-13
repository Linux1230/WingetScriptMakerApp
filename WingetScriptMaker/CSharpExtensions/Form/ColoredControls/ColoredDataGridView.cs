using System;
using System.Windows.Forms;

namespace CSharpExtensions.Form.ColoredControls
{
    public class ColoredDataGridView : DataGridView
    {
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ColoredDataGridView
            // 
            this.DataSourceChanged += new System.EventHandler(this.ColoredDataGridView_DataSourceChanged);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        public ColoredDataGridView()
        {
            InitializeComponent();
            ColorChanger.ColorChanged += UpdateColor;
            UpdateColor();
        }

        public void UpdateColor()
        {
            BackgroundColor = ColorChanger.ColorPrimary;
            GridColor = ColorChanger.ColorText;
            RowsDefaultCellStyle = new DataGridViewCellStyle
            {
                ForeColor = ColorChanger.ColorPrimary
            };
        }

        private void ColoredDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
