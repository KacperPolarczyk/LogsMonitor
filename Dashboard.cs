using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogsMonitor.Forms;

namespace LogsMonitor
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logsOverviewButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            var logsOverviewForm = new LogsOverview(false);

            logsOverviewForm.MdiParent = this;
            logsOverviewForm.Show();

            splashScreenManager.CloseWaitForm();
        }
    }
}
