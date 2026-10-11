using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PurchaseOrderTracker.BLL;
using PurchaseOrderTracker.Models;
using Telerik.WinControls.UI;

namespace Purchase_Order_Trackerr
{
    public partial class Form1 : Form
    {
        private readonly PurchaseOrderBLL _bll = new PurchaseOrderBLL();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.btnModify.Click += btnModify_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClose.Click += btnClose_Click;
            this.btnView.Click += btnView_Click;
            this.btnFilterClear.Click += btnFilterClear_Click;
            this.radGridPurchaseOrders.CommandCellClick += radGridPurchaseOrders_CommandCellClick;
            this.radGridPurchaseOrders.CellDoubleClick += radGridPurchaseOrders_CellDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BindFilterDropdowns();
                ConfigureGridColumns();
                ResetFilters();
                LoadPurchaseOrders();
                LoadKPICounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Initialization Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindFilterDropdowns()
        {
            // Supplier Filter
            List<SupplierBO> suppliers = _bll.GetSuppliers();
            List<SupplierBO> supplierFilterList = new List<SupplierBO>
            {
                new SupplierBO { SupplierID = 0, SupplierName = "-- All Suppliers --" }
            };
            if (suppliers != null)
            {
                supplierFilterList.AddRange(suppliers);
            }

            ddlFilterSupplier.DisplayMember = "SupplierName";
            ddlFilterSupplier.ValueMember = "SupplierID";
            ddlFilterSupplier.DataSource = supplierFilterList;
            ddlFilterSupplier.SelectedIndex = 0;

            // Status Filter
            List<PurchaseOrderStatusBO> statuses = _bll.GetStatuses();
            List<PurchaseOrderStatusBO> statusFilterList = new List<PurchaseOrderStatusBO>
            {
                new PurchaseOrderStatusBO { StatusID = 0, StatusName = "-- All Statuses --" }
            };
            if (statuses != null)
            {
                statusFilterList.AddRange(statuses);
            }

            ddlFilterStatus.DisplayMember = "StatusName";
            ddlFilterStatus.ValueMember = "StatusID";
            ddlFilterStatus.DataSource = statusFilterList;
            ddlFilterStatus.SelectedIndex = 0;
        }

        private void ConfigureGridColumns()
        {
            if (radGridPurchaseOrders.Columns["colPODate"] != null)
            {
                radGridPurchaseOrders.Columns["colPODate"].FormatString = "{0:dd/MM/yyyy}";
            }

            if (radGridPurchaseOrders.Columns["colAmount"] != null)
            {
                radGridPurchaseOrders.Columns["colAmount"].FormatString = "{0:N2}";
            }
        }

        private void ResetFilters()
        {
            dtpFromDate.SetToNullValue();
            dtpToDate.SetToNullValue();

            if (ddlFilterSupplier.Items.Count > 0)
            {
                ddlFilterSupplier.SelectedIndex = 0;
            }

            if (ddlFilterStatus.Items.Count > 0)
            {
                ddlFilterStatus.SelectedIndex = 0;
            }
        }

        private void LoadPurchaseOrders()
        {
            try
            {
                DateTime? fromDate = dtpFromDate.NullableValue;
                DateTime? toDate = dtpToDate.NullableValue;

                int supplierID = 0;
                if (ddlFilterSupplier.SelectedValue != null)
                {
                    int.TryParse(ddlFilterSupplier.SelectedValue.ToString(), out supplierID);
                }

                int statusID = 0;
                if (ddlFilterStatus.SelectedValue != null)
                {
                    int.TryParse(ddlFilterStatus.SelectedValue.ToString(), out statusID);
                }

                List<PurchaseOrderBO> list = _bll.GetPurchaseOrders(
                    fromDate,
                    toDate,
                    supplierID,
                    statusID);

                radGridPurchaseOrders.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error Loading Purchase Orders",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadKPICounts()
        {
            try
            {
                PurchaseOrderKPIBO kpi = _bll.GetKPICounts();
                if (kpi != null)
                {
                    lblTotalCount.Text = kpi.TotalPO.ToString();
                    lblPendingCount.Text = kpi.PendingCount.ToString();
                    lblApprovedCount.Text = kpi.ApprovedCount.ToString();
                    lblCancelledCount.Text = kpi.CancelledCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error Loading KPI Counts",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (frmPurchaseOrderEntry entryForm = new frmPurchaseOrderEntry())
            {
                entryForm.StartPosition = FormStartPosition.CenterParent;
                if (entryForm.ShowDialog(this) == DialogResult.OK || entryForm.IsSaved)
                {
                    LoadPurchaseOrders();
                    LoadKPICounts();
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            PurchaseOrderBO selectedPO = GetSelectedPurchaseOrder();
            if (selectedPO != null)
            {
                OpenModifyForm(selectedPO);
            }
            else
            {
                MessageBox.Show(
                    "Please select a Purchase Order to modify.",
                    "Modify",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PurchaseOrderBO selectedPO = GetSelectedPurchaseOrder();
            if (selectedPO == null)
            {
                MessageBox.Show(
                    "Please select a Purchase Order to delete.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                string.Format("Are you sure you want to delete Purchase Order '{0}'?", selectedPO.PONumber),
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _bll.DeletePurchaseOrder(selectedPO.PurchaseOrderID);
                    MessageBox.Show(
                        "Purchase Order deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadPurchaseOrders();
                    LoadKPICounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadPurchaseOrders();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            ResetFilters();
            LoadPurchaseOrders();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radGridPurchaseOrders_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column != null && e.Column.Name == "colView" && e.Row != null)
            {
                PurchaseOrderBO po = e.Row.DataBoundItem as PurchaseOrderBO;
                if (po != null)
                {
                    OpenModifyForm(po);
                }
            }
        }

        private void radGridPurchaseOrders_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Row != null && !(e.Row is GridViewTableHeaderRowInfo))
            {
                PurchaseOrderBO po = e.Row.DataBoundItem as PurchaseOrderBO;
                if (po != null)
                {
                    OpenModifyForm(po);
                }
            }
        }

        private PurchaseOrderBO GetSelectedPurchaseOrder()
        {
            if (radGridPurchaseOrders.CurrentRow != null &&
                !(radGridPurchaseOrders.CurrentRow is GridViewTableHeaderRowInfo))
            {
                return radGridPurchaseOrders.CurrentRow.DataBoundItem as PurchaseOrderBO;
            }
            return null;
        }

        private void OpenModifyForm(PurchaseOrderBO po)
        {
            if (po == null) return;

            using (frmPurchaseOrderEntry entryForm = new frmPurchaseOrderEntry())
            {
                entryForm.StartPosition = FormStartPosition.CenterParent;
                entryForm.SetPurchaseOrder(po);
                if (entryForm.ShowDialog(this) == DialogResult.OK || entryForm.IsSaved)
                {
                    LoadPurchaseOrders();
                    LoadKPICounts();
                }
            }
        }
    }
}

