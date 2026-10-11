namespace Purchase_Order_Trackerr
{
    partial class frmPurchaseOrderEntry
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.lblPONumber = new System.Windows.Forms.Label();
            this.txtPONumber = new Telerik.WinControls.UI.RadTextBox();

            this.lblPODate = new System.Windows.Forms.Label();
            this.dtpPODate = new Telerik.WinControls.UI.RadDateTimePicker();

            this.lblSupplier = new System.Windows.Forms.Label();
            this.ddlSupplier = new Telerik.WinControls.UI.RadDropDownList();

            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Telerik.WinControls.UI.RadTextBox();

            this.lblStatus = new System.Windows.Forms.Label();
            this.ddlStatus = new Telerik.WinControls.UI.RadDropDownList();

            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPODate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(760, 50);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.AutoSize = true;
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIcon.Location = new System.Drawing.Point(20, 11);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(32, 25);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "📋";

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(55, 9);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(260, 28);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "PURCHASE ORDER ENTRY";

            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblPONumber.Location = new System.Drawing.Point(30, 70);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(76, 15);
            this.lblPONumber.TabIndex = 1;
            this.lblPONumber.Text = "PO NUMBER";

            // 
            // txtPONumber
            // 
            this.txtPONumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPONumber.Location = new System.Drawing.Point(30, 90);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(335, 30);
            this.txtPONumber.TabIndex = 2;

            // 
            // lblPODate
            // 
            this.lblPODate.AutoSize = true;
            this.lblPODate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPODate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblPODate.Location = new System.Drawing.Point(395, 70);
            this.lblPODate.Name = "lblPODate";
            this.lblPODate.Size = new System.Drawing.Size(53, 15);
            this.lblPODate.TabIndex = 3;
            this.lblPODate.Text = "PO DATE";

            // 
            // dtpPODate
            // 
            this.dtpPODate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.dtpPODate.CustomFormat = "dd/MM/yyyy";
            this.dtpPODate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPODate.Location = new System.Drawing.Point(395, 90);
            this.dtpPODate.Name = "dtpPODate";
            this.dtpPODate.ShowUpDown = false;
            this.dtpPODate.Size = new System.Drawing.Size(335, 30);
            this.dtpPODate.TabIndex = 4;

            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblSupplier.Location = new System.Drawing.Point(30, 140);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(95, 15);
            this.lblSupplier.TabIndex = 5;
            this.lblSupplier.Text = "SUPPLIER NAME";

            // 
            // ddlSupplier
            // 
            this.ddlSupplier.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSupplier.Location = new System.Drawing.Point(30, 160);
            this.ddlSupplier.Name = "ddlSupplier";
            this.ddlSupplier.Size = new System.Drawing.Size(335, 30);
            this.ddlSupplier.TabIndex = 6;

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblAmount.Location = new System.Drawing.Point(395, 140);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 15);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "AMOUNT";

            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(395, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(335, 30);
            this.txtAmount.TabIndex = 8;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblStatus.Location = new System.Drawing.Point(30, 210);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "STATUS";

            // 
            // ddlStatus
            // 
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.Location = new System.Drawing.Point(30, 230);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(335, 30);
            this.ddlStatus.TabIndex = 10;

            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.lblRemarks.Location = new System.Drawing.Point(395, 210);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(62, 15);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "REMARKS";

            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(395, 230);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(335, 140);
            this.txtRemarks.TabIndex = 12;

            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClear);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(760, 60);
            this.pnlBottom.TabIndex = 13;

            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(415, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";

            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.btnClear.Location = new System.Drawing.Point(525, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(32)))), ((int)(((byte)(67)))));
            this.btnClose.Location = new System.Drawing.Point(635, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";

            // 
            // frmPurchaseOrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.ddlSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.dtpPODate);
            this.Controls.Add(this.lblPODate);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.lblPONumber);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchaseOrderEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PURCHASE ORDER ENTRY";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPODate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.Label lblPONumber;
        private Telerik.WinControls.UI.RadTextBox txtPONumber;

        private System.Windows.Forms.Label lblPODate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpPODate;

        private System.Windows.Forms.Label lblSupplier;
        private Telerik.WinControls.UI.RadDropDownList ddlSupplier;

        private System.Windows.Forms.Label lblAmount;
        private Telerik.WinControls.UI.RadTextBox txtAmount;

        private System.Windows.Forms.Label lblStatus;
        private Telerik.WinControls.UI.RadDropDownList ddlStatus;

        private System.Windows.Forms.Label lblRemarks;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;

        private System.Windows.Forms.Panel pnlBottom;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}
