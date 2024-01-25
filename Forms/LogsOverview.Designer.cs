namespace LogsMonitor.Forms
{
    partial class LogsOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsOverview));
            this.logsDb = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.logsGridView = new DevExpress.XtraGrid.GridControl();
            this.logsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellerLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperationType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessageType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoggedUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Toolbar = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.logsToolbar = new DevExpress.XtraBars.Bar();
            this.exportToXlsxButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.exportToCsvButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.findButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.clearSortingButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.refreshButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.renameTabButton = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // logsDb
            // 
            this.logsDb.ConnectionName = "localhost_Logs_Production_Connection";
            this.logsDb.Name = "logsDb";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.logsDb.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.logsDb.ResultSchemaSerializable = resources.GetString("logsDb.ResultSchemaSerializable");
            // 
            // logsGridView
            // 
            this.logsGridView.DataMember = "Query";
            this.logsGridView.DataSource = this.logsDb;
            this.logsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsGridView.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.logsGridView.Location = new System.Drawing.Point(0, 152);
            this.logsGridView.MainView = this.logsView;
            this.logsGridView.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.logsGridView.Name = "logsGridView";
            this.logsGridView.Size = new System.Drawing.Size(1428, 616);
            this.logsGridView.TabIndex = 0;
            this.logsGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.logsView});
            this.logsGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.logsGridView_KeyDown);
            // 
            // logsView
            // 
            this.logsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colEventDate,
            this.colApplicationName,
            this.colServiceName,
            this.colSellerLogin,
            this.colOperationType,
            this.colMessageType,
            this.colMessage,
            this.colDetails,
            this.colAppVersion,
            this.colLoggedUser});
            this.logsView.DetailHeight = 1180;
            this.logsView.GridControl = this.logsGridView;
            this.logsView.Name = "logsView";
            this.logsView.OptionsEditForm.PopupEditFormWidth = 2700;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 100;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 378;
            // 
            // colEventDate
            // 
            this.colEventDate.FieldName = "EventDate";
            this.colEventDate.MinWidth = 100;
            this.colEventDate.Name = "colEventDate";
            this.colEventDate.Visible = true;
            this.colEventDate.VisibleIndex = 1;
            this.colEventDate.Width = 378;
            // 
            // colApplicationName
            // 
            this.colApplicationName.FieldName = "ApplicationName";
            this.colApplicationName.MinWidth = 100;
            this.colApplicationName.Name = "colApplicationName";
            this.colApplicationName.Visible = true;
            this.colApplicationName.VisibleIndex = 2;
            this.colApplicationName.Width = 378;
            // 
            // colServiceName
            // 
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.MinWidth = 100;
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 3;
            this.colServiceName.Width = 378;
            // 
            // colSellerLogin
            // 
            this.colSellerLogin.FieldName = "SellerLogin";
            this.colSellerLogin.MinWidth = 100;
            this.colSellerLogin.Name = "colSellerLogin";
            this.colSellerLogin.Visible = true;
            this.colSellerLogin.VisibleIndex = 4;
            this.colSellerLogin.Width = 378;
            // 
            // colOperationType
            // 
            this.colOperationType.FieldName = "OperationType";
            this.colOperationType.MinWidth = 100;
            this.colOperationType.Name = "colOperationType";
            this.colOperationType.Visible = true;
            this.colOperationType.VisibleIndex = 5;
            this.colOperationType.Width = 378;
            // 
            // colMessageType
            // 
            this.colMessageType.FieldName = "MessageType";
            this.colMessageType.MinWidth = 100;
            this.colMessageType.Name = "colMessageType";
            this.colMessageType.Visible = true;
            this.colMessageType.VisibleIndex = 6;
            this.colMessageType.Width = 378;
            // 
            // colMessage
            // 
            this.colMessage.FieldName = "Message";
            this.colMessage.MinWidth = 100;
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 7;
            this.colMessage.Width = 378;
            // 
            // colDetails
            // 
            this.colDetails.FieldName = "Details";
            this.colDetails.MinWidth = 100;
            this.colDetails.Name = "colDetails";
            this.colDetails.Visible = true;
            this.colDetails.VisibleIndex = 8;
            this.colDetails.Width = 378;
            // 
            // colAppVersion
            // 
            this.colAppVersion.FieldName = "AppVersion";
            this.colAppVersion.MinWidth = 100;
            this.colAppVersion.Name = "colAppVersion";
            this.colAppVersion.Visible = true;
            this.colAppVersion.VisibleIndex = 9;
            this.colAppVersion.Width = 378;
            // 
            // colLoggedUser
            // 
            this.colLoggedUser.FieldName = "LoggedUser";
            this.colLoggedUser.MinWidth = 100;
            this.colLoggedUser.Name = "colLoggedUser";
            this.colLoggedUser.Visible = true;
            this.colLoggedUser.VisibleIndex = 10;
            this.colLoggedUser.Width = 378;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1428, 49);
            this.toolbarFormControl1.TabIndex = 1;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager
            // 
            this.toolbarFormManager.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 152);
            this.barDockControlTop.Manager = this.toolbarFormManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1428, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 768);
            this.barDockControlBottom.Manager = this.toolbarFormManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1428, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 152);
            this.barDockControlLeft.Manager = this.toolbarFormManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 616);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1428, 152);
            this.barDockControlRight.Manager = this.toolbarFormManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 616);
            // 
            // Toolbar
            // 
            this.Toolbar.BarName = "Main menu";
            this.Toolbar.DockCol = 0;
            this.Toolbar.DockRow = 0;
            this.Toolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Toolbar.OptionsBar.DrawBorder = false;
            this.Toolbar.OptionsBar.MultiLine = true;
            this.Toolbar.OptionsBar.UseWholeRow = true;
            this.Toolbar.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.logsToolbar});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.exportToXlsxButton,
            this.exportToCsvButton,
            this.findButton,
            this.clearSortingButton,
            this.refreshButton,
            this.renameTabButton});
            this.barManager1.MainMenu = this.logsToolbar;
            this.barManager1.MaxItemId = 7;
            // 
            // logsToolbar
            // 
            this.logsToolbar.BarName = "Main menu";
            this.logsToolbar.DockCol = 0;
            this.logsToolbar.DockRow = 0;
            this.logsToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.logsToolbar.FloatLocation = new System.Drawing.Point(161, 195);
            this.logsToolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToXlsxButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToCsvButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.findButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.clearSortingButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.renameTabButton)});
            this.logsToolbar.OptionsBar.AllowQuickCustomization = false;
            this.logsToolbar.OptionsBar.DrawBorder = false;
            this.logsToolbar.OptionsBar.DrawDragBorder = false;
            this.logsToolbar.OptionsBar.MultiLine = true;
            this.logsToolbar.OptionsBar.UseWholeRow = true;
            this.logsToolbar.Text = "Main menu";
            // 
            // exportToXlsxButton
            // 
            this.exportToXlsxButton.Caption = "Export to XLSX";
            this.exportToXlsxButton.Id = 1;
            this.exportToXlsxButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exportToXlsxButton.ImageOptions.SvgImage")));
            this.exportToXlsxButton.Name = "exportToXlsxButton";
            this.exportToXlsxButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToXlsxButton_ItemClick);
            // 
            // exportToCsvButton
            // 
            this.exportToCsvButton.Caption = "Export to CSV";
            this.exportToCsvButton.Id = 2;
            this.exportToCsvButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exportToCsvButton.ImageOptions.SvgImage")));
            this.exportToCsvButton.Name = "exportToCsvButton";
            this.exportToCsvButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToCsvButton_ItemClick);
            // 
            // findButton
            // 
            this.findButton.Caption = "Find";
            this.findButton.Id = 3;
            this.findButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("findButton.ImageOptions.SvgImage")));
            this.findButton.Name = "findButton";
            this.findButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.findButton_ItemClick);
            // 
            // clearSortingButton
            // 
            this.clearSortingButton.Caption = "Clear Sorting";
            this.clearSortingButton.Id = 4;
            this.clearSortingButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearSortingButton.ImageOptions.SvgImage")));
            this.clearSortingButton.Name = "clearSortingButton";
            this.clearSortingButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearSortingButton_ItemClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Caption = "Refresh";
            this.refreshButton.Id = 5;
            this.refreshButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("refreshButton.ImageOptions.SvgImage")));
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshButton_ItemClick);
            // 
            // renameTabButton
            // 
            this.renameTabButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.renameTabButton.Caption = "Rename tab";
            this.renameTabButton.Id = 6;
            this.renameTabButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("renameTabButton.ImageOptions.SvgImage")));
            this.renameTabButton.Name = "renameTabButton";
            this.renameTabButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.renameTabButton_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 49);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1428, 103);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 768);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1428, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 152);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 616);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1428, 152);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 616);
            // 
            // LogsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 768);
            this.Controls.Add(this.logsGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LogsOverview.IconOptions.SvgImage")));
            this.Name = "LogsOverview";
            this.Text = "Logs Overview";
            this.ToolbarFormControl = this.toolbarFormControl1;
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource logsDb;
        private DevExpress.XtraGrid.GridControl logsGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView logsView;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEventDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationName;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn colSellerLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationType;
        private DevExpress.XtraGrid.Columns.GridColumn colMessageType;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colAppVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colLoggedUser;
        private DevExpress.XtraBars.Bar Toolbar;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar logsToolbar;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarLargeButtonItem exportToXlsxButton;
        private DevExpress.XtraBars.BarLargeButtonItem exportToCsvButton;
        private DevExpress.XtraBars.BarLargeButtonItem findButton;
        private DevExpress.XtraBars.BarLargeButtonItem clearSortingButton;
        private DevExpress.XtraBars.BarLargeButtonItem refreshButton;
        private DevExpress.XtraBars.BarLargeButtonItem renameTabButton;
    }
}