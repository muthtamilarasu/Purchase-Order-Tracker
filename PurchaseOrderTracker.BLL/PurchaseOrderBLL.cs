using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseOrderTracker.DAL;
using PurchaseOrderTracker.Models;

namespace PurchaseOrderTracker.BLL
{
    public class PurchaseOrderBLL
    {
        private readonly PurchaseOrderDAL _dal =
            new PurchaseOrderDAL();

        public List<SupplierBO> GetSuppliers()
        {
            return _dal.GetSuppliers();
        }
                      
        public List<PurchaseOrderStatusBO> GetStatuses()
        {
            return _dal.GetStatuses();
        }

        public List<PurchaseOrderBO> GetPurchaseOrders(
            DateTime? fromDate,
            DateTime? toDate,
            int supplierID,
            int statusID)
        {
            if (fromDate.HasValue &&
                toDate.HasValue &&
                fromDate.Value.Date > toDate.Value.Date)
            {
                throw new Exception(
                    "From Date cannot be greater than To Date.");
            }

            List<PurchaseOrderBO> list = _dal.GetPurchaseOrders(
                fromDate,
                toDate,
                supplierID,
                statusID);

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].SNo = i + 1;
                }
            }

            return list;
        }

        public void SavePurchaseOrder(
            PurchaseOrderBO purchaseOrder)
        {
            ValidatePurchaseOrder(purchaseOrder);
            _dal.SavePurchaseOrder(purchaseOrder);
        }

        public void UpdatePurchaseOrder(
            PurchaseOrderBO purchaseOrder)
        {
            if (purchaseOrder.PurchaseOrderID <= 0)
            {
                throw new Exception(
                    "Select a Purchase Order to modify.");
            }

            ValidatePurchaseOrder(purchaseOrder);
            _dal.UpdatePurchaseOrder(purchaseOrder);
        }

        public void DeletePurchaseOrder(int purchaseOrderID)
        {
            if (purchaseOrderID <= 0)
            {
                throw new Exception(
                    "Select a Purchase Order to delete.");
            }

            _dal.DeletePurchaseOrder(purchaseOrderID);
        }

        public PurchaseOrderKPIBO GetKPICounts()
        {
            return _dal.GetKPICounts();
        }

        private void ValidatePurchaseOrder(
            PurchaseOrderBO purchaseOrder)
        {
            if (purchaseOrder == null)
            {
                throw new Exception(
                    "Purchase Order details are required.");
            }

            if (string.IsNullOrWhiteSpace(
                purchaseOrder.PONumber))
            {
                throw new Exception(
                    "PO Number is required.");
            }

            if (purchaseOrder.SupplierID <= 0)
            {
                throw new Exception(
                    "Supplier is required.");
            }

            if (purchaseOrder.Amount <= 0)
            {
                throw new Exception(
                    "Amount must be greater than zero.");
            }

            if (purchaseOrder.StatusID <= 0)
            {
                throw new Exception(
                    "Status is required.");
            }
        }
    }
}
