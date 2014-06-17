namespace InterviewTest1.Models
{
    public class InvoiceItems
    {
        public string LineText { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Taxable { get; set; }
        public decimal SubTotal { get; set; }
    }
}
