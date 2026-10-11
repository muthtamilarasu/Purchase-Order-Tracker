using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderTracker.Models
{
    public class PurchaseOrderBO
    {
        public int SNo { get; set; }

        public int PurchaseOrderID { get; set; }

        public string PONumber { get; set; }

        public DateTime PODate { get; set; }

        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public decimal Amount { get; set; }

        public int StatusID { get; set; }

        public string StatusName { get; set; }

        public string Status => StatusName;

        public string Remarks { get; set; }
    }

    public class SupplierBO
    {
        public int SupplierID { get; set; }

        public string SupplierName { get; set; }
    }

    public class PurchaseOrderStatusBO
    {
        public int StatusID { get; set; }

        public string StatusName { get; set; }
    }

    public class PurchaseOrderKPIBO
    {
        public int TotalPO { get; set; }

        public int PendingCount { get; set; }

        public int ApprovedCount { get; set; }

        public int CancelledCount { get; set; }
    }
}
