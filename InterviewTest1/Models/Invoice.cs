using System;
using System.Collections.Generic;

namespace InterviewTest1.Models
{
    public class Invoice
    {
        /// <summary>
        /// Customer invoice reference
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Name of our client's company
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Full Name of the billing contact
        /// </summary>
        public string BillingContact { get; set; }

        /// <summary>
        /// Billing number and street
        /// </summary>
        public string BillingStreet { get; set; }

        /// <summary>
        /// Billing City
        /// </summary>
        public string BillingCity { get; set; }

        /// <summary>
        /// Billing State
        /// </summary>
        public string BillingState { get; set; }

        /// <summary>
        /// Billing post code, may include non-numeric values
        /// </summary>
        public string BillingZip { get; set; }

        /// <summary>
        /// Date the invoice payment posted to company bank account
        /// </summary>
        public DateTime PostedDate { get; set; }

        /// <summary>
        /// Date we shipped products
        /// </summary>
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Purchase/Order date
        /// </summary>
        public DateTime RequisitionDate { get; set; }

        /// <summary>
        /// Purchased Products
        /// </summary>
        public IEnumerable<InvoiceItem> LineItems { get; set; }

        /// <summary>
        /// Tax rate in decimal format, ie: 0.07 for 7%
        /// </summary>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Total of all line items total, includes tax and discounts
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Actual shipping costs
        /// </summary>
        public decimal Shipping { get; set; }

        /// <summary>
        /// Grand total, invoice SubTotal and shipping
        /// </summary>
        public decimal Total { get; set; }
    }
}
