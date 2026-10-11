using System;
using System.Windows.Forms;
using PurchaseOrderTracker.BLL;
using PurchaseOrderTracker.Models;

namespace Purchase_Order_Trackerr
{
    public partial class frmPurchaseOrderEntry : Form
    {
        private readonly PurchaseOrderBLL _bll = new PurchaseOrderBLL();
        private int _purchaseOrderID = 0;
        private bool _isDropdownsLoaded = false;

        public bool IsSaved { get; private set; } = false;

        public frmPurchaseOrderEntry()
        {
            InitializeComponent();

            this.Load += frmPurchaseOrderEntry_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnClose.Click += btnClose_Click;
        }

        private void frmPurchaseOrderEntry_Load(object sender, EventArgs e)
        {
            try
            {
                BindDropdowns();

                if (_purchaseOrderID == 0)
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindDropdowns()
        {
            if (_isDropdownsLoaded) return;

            ddlSupplier.DisplayMember = "SupplierName";
            ddlSupplier.ValueMember = "SupplierID";
            ddlSupplier.DataSource = _bll.GetSuppliers();

            ddlStatus.DisplayMember = "StatusName";
            ddlStatus.ValueMember = "StatusID";
            ddlStatus.DataSource = _bll.GetStatuses();

            _isDropdownsLoaded = true;
        }

        public void SetPurchaseOrder(PurchaseOrderBO po)
        {
            if (po == null) return;

            BindDropdowns();

            _purchaseOrderID = po.PurchaseOrderID;
            lblHeaderTitle.Text = "MODIFY PURCHASE ORDER";
            this.Text = "MODIFY PURCHASE ORDER";
            btnSave.Text = "UPDATE";

            txtPONumber.Text = po.PONumber;
            dtpPODate.Value = po.PODate;
            ddlSupplier.SelectedValue = po.SupplierID;
            txtAmount.Text = po.Amount.ToString("0.00");
            ddlStatus.SelectedValue = po.StatusID;
            txtRemarks.Text = po.Remarks ?? string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string poNumber = txtPONumber.Text.Trim();
                if (string.IsNullOrWhiteSpace(poNumber))
                {
                    MessageBox.Show(
                        "PO Number is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPONumber.Focus();
                    return;
                }

                int supplierID = 0;
                if (ddlSupplier.SelectedValue == null ||
                    !int.TryParse(ddlSupplier.SelectedValue.ToString(), out supplierID) ||
                    supplierID <= 0)
                {
                    MessageBox.Show(
                        "Please select a Supplier.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    ddlSupplier.Focus();
                    return;
                }

                decimal amount = 0;
                if (string.IsNullOrWhiteSpace(txtAmount.Text) ||
                    !decimal.TryParse(txtAmount.Text.Trim(), out amount) ||
                    amount <= 0)
                {
                    MessageBox.Show(
                        "Amount must be a numeric value greater than 0.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                int statusID = 0;
                if (ddlStatus.SelectedValue == null ||
                    !int.TryParse(ddlStatus.SelectedValue.ToString(), out statusID) ||
                    statusID <= 0)
                {
                    MessageBox.Show(
                        "Please select a Status.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    ddlStatus.Focus();
                    return;
                }

                PurchaseOrderBO po = new PurchaseOrderBO
                {
                    PurchaseOrderID = _purchaseOrderID,
                    PONumber = poNumber,
                    PODate = dtpPODate.Value.Date,
                    SupplierID = supplierID,
                    Amount = amount,
                    StatusID = statusID,
                    Remarks = txtRemarks.Text.Trim()
                };

                if (_purchaseOrderID == 0)
                {
                    _bll.SavePurchaseOrder(po);
                    MessageBox.Show(
                        "Purchase Order saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    _bll.UpdatePurchaseOrder(po);
                    MessageBox.Show(
                        "Purchase Order updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                IsSaved = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _purchaseOrderID = 0;
            lblHeaderTitle.Text = "PURCHASE ORDER ENTRY";
            this.Text = "PURCHASE ORDER ENTRY";
            btnSave.Text = "SAVE";

            txtPONumber.Clear();
            dtpPODate.Value = DateTime.Today;
            ddlSupplier.SelectedIndex = -1;
            txtAmount.Clear();
            ddlStatus.SelectedIndex = -1;
            txtRemarks.Clear();
            txtPONumber.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}