using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PurchaseOrderTracker.Models;

namespace PurchaseOrderTracker.DAL
{
    public class PurchaseOrderDAL
    {
        private readonly string _connectionString;

        public PurchaseOrderDAL()
        {
            var setting = ConfigurationManager.ConnectionStrings["PurchaseOrderConnection"];
            if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
            {
                _connectionString = setting.ConnectionString;
            }
            else
            {
                _connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=PurchaseOrderTrackerDB;Integrated Security=True;TrustServerCertificate=True;";
            }
        }

        public PurchaseOrderDAL(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                _connectionString = connectionString;
            }
            else
            {
                var setting = ConfigurationManager.ConnectionStrings["PurchaseOrderConnection"];
                _connectionString = setting != null ? setting.ConnectionString : "Server=(LocalDB)\\MSSQLLocalDB;Database=PurchaseOrderTrackerDB;Integrated Security=True;TrustServerCertificate=True;";
            }
        }

        public List<SupplierBO> GetSuppliers()
        {
            List<SupplierBO> suppliers = new List<SupplierBO>();

            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand("sp_GetSuppliers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new SupplierBO
                        {
                            SupplierID =
                                Convert.ToInt32(reader["SupplierID"]),

                            SupplierName =
                                Convert.ToString(reader["SupplierName"])
                        });
                    }
                }
            }

            return suppliers;
        }

        public List<PurchaseOrderStatusBO> GetStatuses()
        {
            List<PurchaseOrderStatusBO> statuses =
                new List<PurchaseOrderStatusBO>();

            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand(
                    "sp_GetPurchaseOrderStatus", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(new PurchaseOrderStatusBO
                        {
                            StatusID =
                                Convert.ToInt32(reader["StatusID"]),

                            StatusName =
                                Convert.ToString(reader["StatusName"])
                        });
                    }
                }
            }

            return statuses;
        }

        public void SavePurchaseOrder(PurchaseOrderBO purchaseOrder)
        {
            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand("sp_SavePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@PONumber", purchaseOrder.PONumber);

                command.Parameters.AddWithValue(
                    "@PODate", purchaseOrder.PODate);

                command.Parameters.AddWithValue(
                    "@SupplierID", purchaseOrder.SupplierID);

                command.Parameters.AddWithValue(
                    "@Amount", purchaseOrder.Amount);

                command.Parameters.AddWithValue(
                    "@StatusID", purchaseOrder.StatusID);

                command.Parameters.AddWithValue(
                    "@Remarks",
                    string.IsNullOrWhiteSpace(purchaseOrder.Remarks)
                        ? (object)DBNull.Value
                        : purchaseOrder.Remarks);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<PurchaseOrderBO> GetPurchaseOrders(
            DateTime? fromDate,
            DateTime? toDate,
            int supplierID,
            int statusID)
        {
            List<PurchaseOrderBO> purchaseOrders =
                new List<PurchaseOrderBO>();

            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand("sp_GetPurchaseOrders", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@FromDate",
                    fromDate.HasValue
                        ? (object)fromDate.Value.Date
                        : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@ToDate",
                    toDate.HasValue
                        ? (object)toDate.Value.Date
                        : DBNull.Value);

                command.Parameters.AddWithValue(
                    "@SupplierID", supplierID);

                command.Parameters.AddWithValue(
                    "@StatusID", statusID);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        purchaseOrders.Add(new PurchaseOrderBO
                        {
                            PurchaseOrderID = Convert.ToInt32(
                                reader["PurchaseOrderID"]),

                            PONumber = Convert.ToString(
                                reader["PONumber"]),

                            PODate = Convert.ToDateTime(
                                reader["PODate"]),

                            SupplierID = Convert.ToInt32(
                                reader["SupplierID"]),

                            SupplierName = Convert.ToString(
                                reader["SupplierName"]),

                            Amount = Convert.ToDecimal(
                                reader["Amount"]),

                            StatusID = Convert.ToInt32(
                                reader["StatusID"]),

                            StatusName = Convert.ToString(
                                reader["StatusName"]),

                            Remarks = Convert.ToString(
                                reader["Remarks"])
                        });
                    }
                }
            }

            return purchaseOrders;
        }

        public PurchaseOrderKPIBO GetKPICounts()
        {
            PurchaseOrderKPIBO kpi = new PurchaseOrderKPIBO();

            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand(
                    "sp_GetPurchaseOrderKPICounts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kpi.TotalPO =
                            Convert.ToInt32(reader["TotalPO"]);

                        kpi.PendingCount =
                            Convert.ToInt32(reader["PendingCount"]);

                        kpi.ApprovedCount =
                            Convert.ToInt32(reader["ApprovedCount"]);

                        kpi.CancelledCount =
                            Convert.ToInt32(reader["CancelledCount"]);
                    }
                }
            }

            return kpi;
        }

        public void UpdatePurchaseOrder(
            PurchaseOrderBO purchaseOrder)
        {
            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand("sp_UpdatePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@PurchaseOrderID",
                    purchaseOrder.PurchaseOrderID);

                command.Parameters.AddWithValue(
                    "@PONumber", purchaseOrder.PONumber);

                command.Parameters.AddWithValue(
                    "@PODate", purchaseOrder.PODate);

                command.Parameters.AddWithValue(
                    "@SupplierID", purchaseOrder.SupplierID);

                command.Parameters.AddWithValue(
                    "@Amount", purchaseOrder.Amount);

                command.Parameters.AddWithValue(
                    "@StatusID", purchaseOrder.StatusID);

                command.Parameters.AddWithValue(
                    "@Remarks",
                    string.IsNullOrWhiteSpace(purchaseOrder.Remarks)
                        ? (object)DBNull.Value
                        : purchaseOrder.Remarks);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePurchaseOrder(int purchaseOrderID)
        {
            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            using (SqlCommand command =
                new SqlCommand("sp_DeletePurchaseOrder", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue(
                    "@PurchaseOrderID", purchaseOrderID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
