using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class DetailedTransactionHistories
    {
        public string TransactionDate { get; set; }
        public string PaymentType { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int Subtotal { get; set; }

    }
}