using System;
using System.Collections.Generic;
using FixFlow.Data;
using FixFlow.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace FixFlow.Services
{
    public class BillingSummary
    {
        public int OrderId { get; set; }
        public decimal Labor { get; set; }
        public decimal PartsCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
    }

    public class BillingService
    {
        private readonly RepairOrderRepository _orders = new RepairOrderRepository();
        private readonly PaymentRepository _payments = new PaymentRepository();

        public BillingSummary GetSummary(int orderId)
        {
            AccessControl.RequireLogin();

            RepairOrder order = _orders.GetById(orderId);
            if (order == null)
                throw new InvalidOperationException("Repair order not found.");
            return GetSummary(order);
        }

        public BillingSummary GetSummary(RepairOrder order)
        {
            AccessControl.RequireLogin();

            if (order == null)
                throw new ArgumentNullException("order");

            decimal paid = _payments.GetTotalPaid(order.OrderId);
            return new BillingSummary
            {
                OrderId = order.OrderId,
                Labor = order.ComputeLaborFee(),
                PartsCost = order.PartsCost,
                TotalCost = order.TotalCost,
                AmountPaid = paid,
                Balance = order.TotalCost - paid
            };
        }

        public decimal GetBalance(RepairOrder order)
        {
            return GetSummary(order).Balance;
        }

        public Payment RecordPayment(int orderId, decimal amount)
        {
            AccessControl.RequireRole(UserRole.Administrator, UserRole.Receptionist);

            if (amount <= 0)
                throw new ArgumentException("Payment amount must be above zero.");

            RepairOrder order = _orders.GetById(orderId);
            if (order == null)
                throw new InvalidOperationException("Repair order not found.");

            decimal balance = GetBalance(order);
            if (amount > balance)
                throw new InvalidOperationException(
                    "The payment is more than the balance of " + balance.ToString("0.00") + ".");

            Payment payment = new Payment(0, orderId, amount, DateTime.Now);
            _payments.Add(payment);
            return payment;
        }

        // ===== Newly Added Methods =====

        public DataTable GetOrderBalances()
        {
            AccessControl.RequireRole(UserRole.Administrator, UserRole.Receptionist);

            DataTable table = new DataTable();
            using (SqlConnection conn = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT OrderId, Customer, TotalCost, AmountPaid, Balance " +
                "FROM dbo.vw_OrderBalances ORDER BY OrderId DESC", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public decimal GetCollectedToday()
        {
            AccessControl.RequireRole(UserRole.Administrator, UserRole.Receptionist);

            decimal total = 0m;
            foreach (Payment p in _payments.GetAll())
                if (p.PaymentDate.Date == DateTime.Today)
                    total += p.Amount;
            return total;
        }
    }
}