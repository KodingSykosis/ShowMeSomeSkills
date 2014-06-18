using System;
using System.Collections.Generic;

namespace InterviewTest1.Models
{
    public class Invoice
    {
        public string CompanyName { get; set; }

        public string BillingContact { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }

        public DateTime PostedDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime RequisitionDate { get; set; }

        public IEnumerable<InvoiceItem> LineItems { get; set; }

        public decimal TaxRate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }
    }
}