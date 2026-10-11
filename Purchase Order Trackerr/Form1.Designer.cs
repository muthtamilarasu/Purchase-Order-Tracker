namespace Purchase_Order_Trackerr
{
    partial class Form1
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
            Telerik.WinControls.UI.GridViewTextBoxColumn colSNo = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn colPONumber = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn colPODate = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn colSupplierName = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn colAmount = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn colStatus = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn colView = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.pnlKpiContainer = new System.Windows.Forms.Panel();
            this.tblKpiLayout = new System.Windows.Forms.TableLayoutPanel();

            this.pnlKpiTotal = new System.Windows.Forms.Panel();
            this.pnlIconTotal = new System.Windows.Forms.PictureBox();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();

            this.pnlKpiPending = new System.Windows.Forms.Panel();
            this.pnlIconPending = new System.Windows.Forms.PictureBox();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();

            this.pnlKpiApproved = new System.Windows.Forms.Panel();
            this.pnlIconApproved = new System.Windows.Forms.PictureBox();
            this.lblApprovedTitle = new System.Windows.Forms.Label();
            this.lblApprovedCount = new System.Windows.Forms.Label();

            this.pnlKpiCancelled = new System.Windows.Forms.Panel();
            this.pnlIconCancelled = new System.Windows.Forms.PictureBox();
            this.lblCancelledTitle = new System.Windows.Forms.Label();
            this.lblCancelledCount = new System.Windows.Forms.Label();

            this.pnlFilterSection = new System.Windows.Forms.Panel();
            this.pnlFilterInner = new System.Windows.Forms.Panel();
            this.tblFilterLayout = new System.Windows.Forms.TableLayoutPanel();

            this.pnlFilterFromDateGroup = new System.Windows.Forms.Panel();
            this.lblFilterFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new Telerik.WinControls.UI.RadDateTimePicker();

            this.pnlFilterToDateGroup = new System.Windows.Forms.Panel();
            this.lblFilterToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new Telerik.WinControls.UI.RadDateTimePicker();

            this.pnlFilterSupplierGroup = new System.Windows.Forms.Panel();
            this.lblFilterSupplier = new System.Windows.Forms.Label();
            this.ddlFilterSupplier = new Telerik.WinControls.UI.RadDropDownList();

            this.pnlFilterStatusGroup = new System.Windows.Forms.Panel();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.ddlFilterStatus = new Telerik.WinControls.UI.RadDropDownList();

            this.pnlFilterViewGroup = new System.Windows.Forms.Panel();
            this.lblSpacerView = new System.Windows.Forms.Label();
            this.btnView = new Telerik.WinControls.UI.RadButton();

            this.pnlFilterClearGroup = new System.Windows.Forms.Panel();
            this.lblSpacerClear = new System.Windows.Forms.Label();
            this.btnFilterClear = new Telerik.WinControls.UI.RadButton();

            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.lblGridHeaderTitle = new System.Windows.Forms.Label();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.btnModify = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();

            this.pnlGridSection = new System.Windows.Forms.Panel();
            this.radGridPurchaseOrders = new Telerik.WinControls.UI.RadGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlKpiContainer.SuspendLayout();
            this.tblKpiLayout.SuspendLayout();
            this.pnlKpiTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconTotal)).BeginInit();
            this.pnlKpiPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconPending)).BeginInit();
            this.pnlKpiApproved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconApproved)).BeginInit();
            this.pnlKpiCancelled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconCancelled)).BeginInit();
            this.pnlFilterSection.SuspendLayout();
            this.pnlFilterInner.SuspendLayout();
            this.tblFilterLayout.SuspendLayout();
            this.pnlFilterFromDateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).BeginInit();
            this.pnlFilterToDateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).BeginInit();
            this.pnlFilterSupplierGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFilterSupplier)).BeginInit();
            this.pnlFilterStatusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFilterStatus)).BeginInit();
            this.pnlFilterViewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.pnlFilterClearGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterClear)).BeginInit();
            this.pnlGridHeader.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlGridSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPurchaseOrders.MasterTemplate)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.pnlHeader.Controls.Add(this.lblHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1366, 50);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.AutoSize = true;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIcon.Location = new System.Drawing.Point(15, 11);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(32, 25);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "📋";

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(52, 9);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(275, 28);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "PURCHASE ORDER TRACKER";

            // 
            // pnlKpiContainer
            // 
            this.pnlKpiContainer.BackColor = System.Drawing.Color.White;
            this.pnlKpiContainer.Controls.Add(this.tblKpiLayout);
            this.pnlKpiContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiContainer.Location = new System.Drawing.Point(0, 50);
            this.pnlKpiContainer.Name = "pnlKpiContainer";
            this.pnlKpiContainer.Padding = new System.Windows.Forms.Padding(11, 16, 11, 16);
            this.pnlKpiContainer.Size = new System.Drawing.Size(1366, 124);
            this.pnlKpiContainer.TabIndex = 1;

            // 
            // tblKpiLayout
            // 
            this.tblKpiLayout.ColumnCount = 4;
            this.tblKpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblKpiLayout.Controls.Add(this.pnlKpiTotal, 0, 0);
            this.tblKpiLayout.Controls.Add(this.pnlKpiPending, 1, 0);
            this.tblKpiLayout.Controls.Add(this.pnlKpiApproved, 2, 0);
            this.tblKpiLayout.Controls.Add(this.pnlKpiCancelled, 3, 0);
            this.tblKpiLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKpiLayout.Location = new System.Drawing.Point(11, 16);
            this.tblKpiLayout.Name = "tblKpiLayout";
            this.tblKpiLayout.RowCount = 1;
            this.tblKpiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKpiLayout.Size = new System.Drawing.Size(1344, 92);
            this.tblKpiLayout.TabIndex = 0;

            // 
            // pnlKpiTotal
            // 
            this.pnlKpiTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlKpiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiTotal.Controls.Add(this.pnlIconTotal);
            this.pnlKpiTotal.Controls.Add(this.lblTotalTitle);
            this.pnlKpiTotal.Controls.Add(this.lblTotalCount);
            this.pnlKpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiTotal.Location = new System.Drawing.Point(5, 0);
            this.pnlKpiTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlKpiTotal.Name = "pnlKpiTotal";
            this.pnlKpiTotal.Size = new System.Drawing.Size(326, 92);
            this.pnlKpiTotal.TabIndex = 0;

            // 
            // pnlIconTotal
            // 
            this.pnlIconTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlIconTotal.Image = global::Purchase_Order_Trackerr.Properties.Resources.kpi_total;
            this.pnlIconTotal.Location = new System.Drawing.Point(20, 17);
            this.pnlIconTotal.Name = "pnlIconTotal";
            this.pnlIconTotal.Size = new System.Drawing.Size(58, 58);
            this.pnlIconTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlIconTotal.TabIndex = 0;
            this.pnlIconTotal.TabStop = false;

            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(96, 16);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(180, 21);
            this.lblTotalTitle.TabIndex = 1;
            this.lblTotalTitle.Text = "TOTAL PO";
            this.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.lblTotalCount.Location = new System.Drawing.Point(96, 39);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(120, 38);
            this.lblTotalCount.TabIndex = 2;
            this.lblTotalCount.Text = "0";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlKpiPending
            // 
            this.pnlKpiPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(245)))));
            this.pnlKpiPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiPending.Controls.Add(this.pnlIconPending);
            this.pnlKpiPending.Controls.Add(this.lblPendingTitle);
            this.pnlKpiPending.Controls.Add(this.lblPendingCount);
            this.pnlKpiPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiPending.Location = new System.Drawing.Point(341, 0);
            this.pnlKpiPending.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlKpiPending.Name = "pnlKpiPending";
            this.pnlKpiPending.Size = new System.Drawing.Size(326, 92);
            this.pnlKpiPending.TabIndex = 1;

            // 
            // pnlIconPending
            // 
            this.pnlIconPending.BackColor = System.Drawing.Color.Transparent;
            this.pnlIconPending.Image = global::Purchase_Order_Trackerr.Properties.Resources.kpi_pending;
            this.pnlIconPending.Location = new System.Drawing.Point(20, 17);
            this.pnlIconPending.Name = "pnlIconPending";
            this.pnlIconPending.Size = new System.Drawing.Size(58, 58);
            this.pnlIconPending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlIconPending.TabIndex = 0;
            this.pnlIconPending.TabStop = false;

            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblPendingTitle.Location = new System.Drawing.Point(96, 16);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(180, 21);
            this.lblPendingTitle.TabIndex = 1;
            this.lblPendingTitle.Text = "PENDING";
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblPendingCount
            // 
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lblPendingCount.Location = new System.Drawing.Point(96, 39);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(120, 38);
            this.lblPendingCount.TabIndex = 2;
            this.lblPendingCount.Text = "0";
            this.lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlKpiApproved
            // 
            this.pnlKpiApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlKpiApproved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiApproved.Controls.Add(this.pnlIconApproved);
            this.pnlKpiApproved.Controls.Add(this.lblApprovedTitle);
            this.pnlKpiApproved.Controls.Add(this.lblApprovedCount);
            this.pnlKpiApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiApproved.Location = new System.Drawing.Point(677, 0);
            this.pnlKpiApproved.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlKpiApproved.Name = "pnlKpiApproved";
            this.pnlKpiApproved.Size = new System.Drawing.Size(326, 92);
            this.pnlKpiApproved.TabIndex = 2;

            // 
            // pnlIconApproved
            // 
            this.pnlIconApproved.BackColor = System.Drawing.Color.Transparent;
            this.pnlIconApproved.Image = global::Purchase_Order_Trackerr.Properties.Resources.kpi_approved;
            this.pnlIconApproved.Location = new System.Drawing.Point(20, 17);
            this.pnlIconApproved.Name = "pnlIconApproved";
            this.pnlIconApproved.Size = new System.Drawing.Size(58, 58);
            this.pnlIconApproved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlIconApproved.TabIndex = 0;
            this.pnlIconApproved.TabStop = false;

            // 
            // lblApprovedTitle
            // 
            this.lblApprovedTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblApprovedTitle.Location = new System.Drawing.Point(96, 16);
            this.lblApprovedTitle.Name = "lblApprovedTitle";
            this.lblApprovedTitle.Size = new System.Drawing.Size(180, 21);
            this.lblApprovedTitle.TabIndex = 1;
            this.lblApprovedTitle.Text = "APPROVED";
            this.lblApprovedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblApprovedCount
            // 
            this.lblApprovedCount.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblApprovedCount.Location = new System.Drawing.Point(96, 39);
            this.lblApprovedCount.Name = "lblApprovedCount";
            this.lblApprovedCount.Size = new System.Drawing.Size(120, 38);
            this.lblApprovedCount.TabIndex = 2;
            this.lblApprovedCount.Text = "0";
            this.lblApprovedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlKpiCancelled
            // 
            this.pnlKpiCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlKpiCancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiCancelled.Controls.Add(this.pnlIconCancelled);
            this.pnlKpiCancelled.Controls.Add(this.lblCancelledTitle);
            this.pnlKpiCancelled.Controls.Add(this.lblCancelledCount);
            this.pnlKpiCancelled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKpiCancelled.Location = new System.Drawing.Point(1013, 0);
            this.pnlKpiCancelled.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlKpiCancelled.Name = "pnlKpiCancelled";
            this.pnlKpiCancelled.Size = new System.Drawing.Size(326, 92);
            this.pnlKpiCancelled.TabIndex = 3;

            // 
            // pnlIconCancelled
            // 
            this.pnlIconCancelled.BackColor = System.Drawing.Color.Transparent;
            this.pnlIconCancelled.Image = global::Purchase_Order_Trackerr.Properties.Resources.kpi_cancelled;
            this.pnlIconCancelled.Location = new System.Drawing.Point(20, 17);
            this.pnlIconCancelled.Name = "pnlIconCancelled";
            this.pnlIconCancelled.Size = new System.Drawing.Size(58, 58);
            this.pnlIconCancelled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlIconCancelled.TabIndex = 0;
            this.pnlIconCancelled.TabStop = false;

            // 
            // lblCancelledTitle
            // 
            this.lblCancelledTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCancelledTitle.Location = new System.Drawing.Point(96, 16);
            this.lblCancelledTitle.Name = "lblCancelledTitle";
            this.lblCancelledTitle.Size = new System.Drawing.Size(180, 21);
            this.lblCancelledTitle.TabIndex = 1;
            this.lblCancelledTitle.Text = "CANCELLED";
            this.lblCancelledTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblCancelledCount
            // 
            this.lblCancelledCount.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCancelledCount.Location = new System.Drawing.Point(96, 39);
            this.lblCancelledCount.Name = "lblCancelledCount";
            this.lblCancelledCount.Size = new System.Drawing.Size(120, 38);
            this.lblCancelledCount.TabIndex = 2;
            this.lblCancelledCount.Text = "0";
            this.lblCancelledCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlFilterSection
            // 
            this.pnlFilterSection.BackColor = System.Drawing.Color.White;
            this.pnlFilterSection.Controls.Add(this.pnlFilterInner);
            this.pnlFilterSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterSection.Location = new System.Drawing.Point(0, 174);
            this.pnlFilterSection.Name = "pnlFilterSection";
            this.pnlFilterSection.Padding = new System.Windows.Forms.Padding(15, 4, 15, 6);
            this.pnlFilterSection.Size = new System.Drawing.Size(1366, 78);
            this.pnlFilterSection.TabIndex = 2;

            // 
            // pnlFilterInner
            // 
            this.pnlFilterInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlFilterInner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterInner.Controls.Add(this.tblFilterLayout);
            this.pnlFilterInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterInner.Location = new System.Drawing.Point(15, 4);
            this.pnlFilterInner.Name = "pnlFilterInner";
            this.pnlFilterInner.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlFilterInner.Size = new System.Drawing.Size(1336, 68);
            this.pnlFilterInner.TabIndex = 0;

            // 
            // tblFilterLayout
            // 
            this.tblFilterLayout.ColumnCount = 6;
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tblFilterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tblFilterLayout.Controls.Add(this.pnlFilterFromDateGroup, 0, 0);
            this.tblFilterLayout.Controls.Add(this.pnlFilterToDateGroup, 1, 0);
            this.tblFilterLayout.Controls.Add(this.pnlFilterSupplierGroup, 2, 0);
            this.tblFilterLayout.Controls.Add(this.pnlFilterStatusGroup, 3, 0);
            this.tblFilterLayout.Controls.Add(this.pnlFilterViewGroup, 4, 0);
            this.tblFilterLayout.Controls.Add(this.pnlFilterClearGroup, 5, 0);
            this.tblFilterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilterLayout.Location = new System.Drawing.Point(12, 6);
            this.tblFilterLayout.Name = "tblFilterLayout";
            this.tblFilterLayout.RowCount = 1;
            this.tblFilterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFilterLayout.Size = new System.Drawing.Size(1310, 54);
            this.tblFilterLayout.TabIndex = 0;

            // 
            // pnlFilterFromDateGroup
            // 
            this.pnlFilterFromDateGroup.Controls.Add(this.dtpFromDate);
            this.pnlFilterFromDateGroup.Controls.Add(this.lblFilterFromDate);
            this.pnlFilterFromDateGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterFromDateGroup.Location = new System.Drawing.Point(3, 2);
            this.pnlFilterFromDateGroup.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.pnlFilterFromDateGroup.Name = "pnlFilterFromDateGroup";
            this.pnlFilterFromDateGroup.Size = new System.Drawing.Size(226, 50);
            this.pnlFilterFromDateGroup.TabIndex = 0;

            // 
            // lblFilterFromDate
            // 
            this.lblFilterFromDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterFromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblFilterFromDate.Location = new System.Drawing.Point(0, 0);
            this.lblFilterFromDate.Name = "lblFilterFromDate";
            this.lblFilterFromDate.Size = new System.Drawing.Size(226, 18);
            this.lblFilterFromDate.TabIndex = 0;
            this.lblFilterFromDate.Text = "FROM DATE";

            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(0, 18);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShowUpDown = false;
            this.dtpFromDate.Size = new System.Drawing.Size(226, 30);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.Value = new System.DateTime(2026, 9, 8, 0, 0, 0, 0);

            // 
            // pnlFilterToDateGroup
            // 
            this.pnlFilterToDateGroup.Controls.Add(this.dtpToDate);
            this.pnlFilterToDateGroup.Controls.Add(this.lblFilterToDate);
            this.pnlFilterToDateGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterToDateGroup.Location = new System.Drawing.Point(238, 2);
            this.pnlFilterToDateGroup.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.pnlFilterToDateGroup.Name = "pnlFilterToDateGroup";
            this.pnlFilterToDateGroup.Size = new System.Drawing.Size(226, 50);
            this.pnlFilterToDateGroup.TabIndex = 1;

            // 
            // lblFilterToDate
            // 
            this.lblFilterToDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterToDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblFilterToDate.Location = new System.Drawing.Point(0, 0);
            this.lblFilterToDate.Name = "lblFilterToDate";
            this.lblFilterToDate.Size = new System.Drawing.Size(226, 18);
            this.lblFilterToDate.TabIndex = 0;
            this.lblFilterToDate.Text = "TO DATE";

            // 
            // dtpToDate
            // 
            this.dtpToDate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(0, 18);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShowUpDown = false;
            this.dtpToDate.Size = new System.Drawing.Size(226, 30);
            this.dtpToDate.TabIndex = 1;
            this.dtpToDate.Value = new System.DateTime(2026, 9, 8, 0, 0, 0, 0);

            // 
            // pnlFilterSupplierGroup
            // 
            this.pnlFilterSupplierGroup.Controls.Add(this.ddlFilterSupplier);
            this.pnlFilterSupplierGroup.Controls.Add(this.lblFilterSupplier);
            this.pnlFilterSupplierGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterSupplierGroup.Location = new System.Drawing.Point(473, 2);
            this.pnlFilterSupplierGroup.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.pnlFilterSupplierGroup.Name = "pnlFilterSupplierGroup";
            this.pnlFilterSupplierGroup.Size = new System.Drawing.Size(279, 50);
            this.pnlFilterSupplierGroup.TabIndex = 2;

            // 
            // lblFilterSupplier
            // 
            this.lblFilterSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblFilterSupplier.Location = new System.Drawing.Point(0, 0);
            this.lblFilterSupplier.Name = "lblFilterSupplier";
            this.lblFilterSupplier.Size = new System.Drawing.Size(279, 18);
            this.lblFilterSupplier.TabIndex = 0;
            this.lblFilterSupplier.Text = "SUPPLIER";

            // 
            // ddlFilterSupplier
            // 
            this.ddlFilterSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlFilterSupplier.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFilterSupplier.Location = new System.Drawing.Point(0, 18);
            this.ddlFilterSupplier.Name = "ddlFilterSupplier";
            this.ddlFilterSupplier.NullText = "-- All --";
            this.ddlFilterSupplier.Size = new System.Drawing.Size(279, 30);
            this.ddlFilterSupplier.TabIndex = 1;

            // 
            // pnlFilterStatusGroup
            // 
            this.pnlFilterStatusGroup.Controls.Add(this.ddlFilterStatus);
            this.pnlFilterStatusGroup.Controls.Add(this.lblFilterStatus);
            this.pnlFilterStatusGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterStatusGroup.Location = new System.Drawing.Point(761, 2);
            this.pnlFilterStatusGroup.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.pnlFilterStatusGroup.Name = "pnlFilterStatusGroup";
            this.pnlFilterStatusGroup.Size = new System.Drawing.Size(253, 50);
            this.pnlFilterStatusGroup.TabIndex = 3;

            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(0, 0);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(253, 18);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "STATUS";

            // 
            // ddlFilterStatus
            // 
            this.ddlFilterStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFilterStatus.Location = new System.Drawing.Point(0, 18);
            this.ddlFilterStatus.Name = "ddlFilterStatus";
            this.ddlFilterStatus.NullText = "-- All --";
            this.ddlFilterStatus.Size = new System.Drawing.Size(253, 30);
            this.ddlFilterStatus.TabIndex = 1;

            // 
            // pnlFilterViewGroup
            // 
            this.pnlFilterViewGroup.Controls.Add(this.btnView);
            this.pnlFilterViewGroup.Controls.Add(this.lblSpacerView);
            this.pnlFilterViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterViewGroup.Location = new System.Drawing.Point(1023, 2);
            this.pnlFilterViewGroup.Margin = new System.Windows.Forms.Padding(3, 2, 4, 2);
            this.pnlFilterViewGroup.Name = "pnlFilterViewGroup";
            this.pnlFilterViewGroup.Size = new System.Drawing.Size(137, 50);
            this.pnlFilterViewGroup.TabIndex = 4;

            // 
            // lblSpacerView
            // 
            this.lblSpacerView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpacerView.Location = new System.Drawing.Point(0, 0);
            this.lblSpacerView.Name = "lblSpacerView";
            this.lblSpacerView.Size = new System.Drawing.Size(137, 18);
            this.lblSpacerView.TabIndex = 0;

            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(0, 18);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 30);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "VIEW";

            // 
            // pnlFilterClearGroup
            // 
            this.pnlFilterClearGroup.Controls.Add(this.btnFilterClear);
            this.pnlFilterClearGroup.Controls.Add(this.lblSpacerClear);
            this.pnlFilterClearGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterClearGroup.Location = new System.Drawing.Point(1167, 2);
            this.pnlFilterClearGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilterClearGroup.Name = "pnlFilterClearGroup";
            this.pnlFilterClearGroup.Size = new System.Drawing.Size(140, 50);
            this.pnlFilterClearGroup.TabIndex = 5;

            // 
            // lblSpacerClear
            // 
            this.lblSpacerClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpacerClear.Location = new System.Drawing.Point(0, 0);
            this.lblSpacerClear.Name = "lblSpacerClear";
            this.lblSpacerClear.Size = new System.Drawing.Size(140, 18);
            this.lblSpacerClear.TabIndex = 0;

            // 
            // btnFilterClear
            // 
            this.btnFilterClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnFilterClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.btnFilterClear.Location = new System.Drawing.Point(0, 18);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(140, 30);
            this.btnFilterClear.TabIndex = 1;
            this.btnFilterClear.Text = "CLEAR";

            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.pnlGridHeader.Controls.Add(this.lblGridHeaderTitle);
            this.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridHeader.Location = new System.Drawing.Point(0, 252);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(1366, 36);
            this.pnlGridHeader.TabIndex = 3;

            // 
            // lblGridHeaderTitle
            // 
            this.lblGridHeaderTitle.AutoSize = true;
            this.lblGridHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblGridHeaderTitle.Location = new System.Drawing.Point(15, 7);
            this.lblGridHeaderTitle.Name = "lblGridHeaderTitle";
            this.lblGridHeaderTitle.Size = new System.Drawing.Size(155, 20);
            this.lblGridHeaderTitle.TabIndex = 0;
            this.lblGridHeaderTitle.Text = "PURCHASE ORDERS";

            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlBottom.Controls.Add(this.btnNew);
            this.pnlBottom.Controls.Add(this.btnModify);
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 718);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1366, 50);
            this.pnlBottom.TabIndex = 5;

            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(910, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);

            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.btnModify.Location = new System.Drawing.Point(1020, 10);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 32);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "MODIFY";

            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1130, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.btnClose.Location = new System.Drawing.Point(1240, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";

            // 
            // pnlGridSection
            // 
            this.pnlGridSection.BackColor = System.Drawing.Color.White;
            this.pnlGridSection.Controls.Add(this.radGridPurchaseOrders);
            this.pnlGridSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridSection.Location = new System.Drawing.Point(0, 288);
            this.pnlGridSection.Name = "pnlGridSection";
            this.pnlGridSection.Padding = new System.Windows.Forms.Padding(0);
            this.pnlGridSection.Size = new System.Drawing.Size(1366, 430);
            this.pnlGridSection.TabIndex = 4;

            // 
            // radGridPurchaseOrders
            // 
            this.radGridPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGridPurchaseOrders.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            colSNo.FieldName = "SNo";
            colSNo.HeaderText = "S.NO";
            colSNo.Name = "colSNo";
            colSNo.Width = 60;

            colPONumber.FieldName = "PONumber";
            colPONumber.HeaderText = "PO NO";
            colPONumber.Name = "colPONumber";
            colPONumber.Width = 130;

            colPODate.FieldName = "PODate";
            colPODate.HeaderText = "PO DATE";
            colPODate.Name = "colPODate";
            colPODate.Width = 130;

            colSupplierName.FieldName = "SupplierName";
            colSupplierName.HeaderText = "SUPPLIER NAME";
            colSupplierName.Name = "colSupplierName";
            colSupplierName.Width = 300;

            colAmount.FieldName = "Amount";
            colAmount.HeaderText = "AMOUNT";
            colAmount.Name = "colAmount";
            colAmount.Width = 140;

            colStatus.FieldName = "Status";
            colStatus.HeaderText = "STATUS";
            colStatus.Name = "colStatus";
            colStatus.Width = 120;

            colView.DefaultText = "👁";
            colView.UseDefaultText = true;
            colView.FieldName = "View";
            colView.HeaderText = "VIEW";
            colView.Name = "colView";
            colView.Width = 90;

            this.radGridPurchaseOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            colSNo,
            colPONumber,
            colPODate,
            colSupplierName,
            colAmount,
            colStatus,
            colView});

            this.radGridPurchaseOrders.MasterTemplate.AllowAddNewRow = false;
            this.radGridPurchaseOrders.MasterTemplate.AllowColumnReorder = false;
            this.radGridPurchaseOrders.MasterTemplate.AllowDeleteRow = false;
            this.radGridPurchaseOrders.MasterTemplate.AllowEditRow = false;
            this.radGridPurchaseOrders.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridPurchaseOrders.MasterTemplate.EnableFiltering = false;
            this.radGridPurchaseOrders.MasterTemplate.EnableGrouping = false;
            this.radGridPurchaseOrders.ShowGroupPanel = false;
            this.radGridPurchaseOrders.MasterTemplate.ReadOnly = true;
            this.radGridPurchaseOrders.TableElement.RowHeight = 34;
            this.radGridPurchaseOrders.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect;
            this.radGridPurchaseOrders.TableElement.TableHeaderHeight = 40;
            this.radGridPurchaseOrders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridPurchaseOrders.Name = "radGridPurchaseOrders";
            this.radGridPurchaseOrders.ReadOnly = true;
            this.radGridPurchaseOrders.Size = new System.Drawing.Size(1366, 418);
            this.radGridPurchaseOrders.TabIndex = 0;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlGridSection);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlGridHeader);
            this.Controls.Add(this.pnlFilterSection);
            this.Controls.Add(this.pnlKpiContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PURCHASE ORDER TRACKER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKpiContainer.ResumeLayout(false);
            this.tblKpiLayout.ResumeLayout(false);
            this.pnlKpiTotal.ResumeLayout(false);
            this.pnlKpiTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconTotal)).EndInit();
            this.pnlKpiPending.ResumeLayout(false);
            this.pnlKpiPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconPending)).EndInit();
            this.pnlKpiApproved.ResumeLayout(false);
            this.pnlKpiApproved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconApproved)).EndInit();
            this.pnlKpiCancelled.ResumeLayout(false);
            this.pnlKpiCancelled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIconCancelled)).EndInit();
            this.pnlFilterSection.ResumeLayout(false);
            this.pnlFilterInner.ResumeLayout(false);
            this.tblFilterLayout.ResumeLayout(false);
            this.pnlFilterFromDateGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate)).EndInit();
            this.pnlFilterToDateGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate)).EndInit();
            this.pnlFilterSupplierGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlFilterSupplier)).EndInit();
            this.pnlFilterStatusGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlFilterStatus)).EndInit();
            this.pnlFilterViewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.pnlFilterClearGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterClear)).EndInit();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlGridSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridPurchaseOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridPurchaseOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.Panel pnlKpiContainer;
        private System.Windows.Forms.TableLayoutPanel tblKpiLayout;
        private System.Windows.Forms.Panel pnlKpiTotal;
        private System.Windows.Forms.PictureBox pnlIconTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalCount;

        private System.Windows.Forms.Panel pnlKpiPending;
        private System.Windows.Forms.PictureBox pnlIconPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingCount;

        private System.Windows.Forms.Panel pnlKpiApproved;
        private System.Windows.Forms.PictureBox pnlIconApproved;
        private System.Windows.Forms.Label lblApprovedTitle;
        private System.Windows.Forms.Label lblApprovedCount;

        private System.Windows.Forms.Panel pnlKpiCancelled;
        private System.Windows.Forms.PictureBox pnlIconCancelled;
        private System.Windows.Forms.Label lblCancelledTitle;
        private System.Windows.Forms.Label lblCancelledCount;

        private System.Windows.Forms.Panel pnlFilterSection;
        private System.Windows.Forms.Panel pnlFilterInner;
        private System.Windows.Forms.TableLayoutPanel tblFilterLayout;
        private System.Windows.Forms.Panel pnlFilterFromDateGroup;
        private System.Windows.Forms.Label lblFilterFromDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel pnlFilterToDateGroup;
        private System.Windows.Forms.Label lblFilterToDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpToDate;
        private System.Windows.Forms.Panel pnlFilterSupplierGroup;
        private System.Windows.Forms.Label lblFilterSupplier;
        private Telerik.WinControls.UI.RadDropDownList ddlFilterSupplier;
        private System.Windows.Forms.Panel pnlFilterStatusGroup;
        private System.Windows.Forms.Label lblFilterStatus;
        private Telerik.WinControls.UI.RadDropDownList ddlFilterStatus;
        private System.Windows.Forms.Panel pnlFilterViewGroup;
        private System.Windows.Forms.Label lblSpacerView;
        private Telerik.WinControls.UI.RadButton btnView;
        private System.Windows.Forms.Panel pnlFilterClearGroup;
        private System.Windows.Forms.Label lblSpacerClear;
        private Telerik.WinControls.UI.RadButton btnFilterClear;

        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblGridHeaderTitle;

        private System.Windows.Forms.Panel pnlBottom;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadButton btnModify;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnClose;

        private System.Windows.Forms.Panel pnlGridSection;
        private Telerik.WinControls.UI.RadGridView radGridPurchaseOrders;
    }
}
