using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LogsMonitor.Forms
{
    public partial class LogsOverview : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public LogsOverview()
        {
            InitializeComponent();
        }

        public LogsOverview(bool test)
        {
            InitializeComponent();

            if (test)
            {
                this.logsDb.ConnectionName = "localhost_applicationlogs_TestConnection";
                this.Text                  = "Logs Overview (Test)";

                logsDb.FillAsync();
            }
            else
            {
                this.Text = "Logs Overview (Production)";

                logsDb.FillAsync();
            }
        }

        private void exportToXlsxButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var dateNow = DateTime.Now.ToString("dd/MM/yyyy HH mm ss");

                var saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter   = ".xlsx Files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = $"Logs Report - {dateNow}.xlsx";
                saveFileDialog.Title    = "Save an Excel File";

                var dialogResult = saveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    logsGridView.ExportToXlsx(saveFileDialog.FileName);

                    XtraMessageBox.Show($"Successfully generated logs report to xslx file. Path: {saveFileDialog.FileName}", "Logs Overview - Save to Xlsx file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error: {ex}", "Logs Overview - Save to Xlsx file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToCsvButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        private void findButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logsView.ShowFindPanel();
        }

        private void clearSortingButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logsView.ClearSorting();
        }

        private void refreshButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logsDb.FillAsync();
            logsView.RefreshData();
        }

        private void renameTabButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changeTabNameResult = XtraInputBox.Show("Enter new tab name", "Change tab name", "Logs Overview");

            if (!string.IsNullOrEmpty(changeTabNameResult))
            {
                this.Text = changeTabNameResult;
            }
        }
    }
}