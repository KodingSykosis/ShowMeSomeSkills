namespace InterviewTest1.Models
{
    public class InvoiceItem
    {
        public string LineText { get; set; }
        public bool Taxable { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public byte Discount { get; set; }
        public decimal SubTotal { get; set; }

        public override string ToString()
        {
            return string.Format("{0}Quantity: {1:000}\tPer Unit: $ {2:#,0.00}\tDiscount: {3:00} %\tSubTotal: $ {4:#,0.00}",
                                 LineText.PadRight(20),
                                 Quantity,
                                 UnitPrice,
                                 Discount,
                                 SubTotal);
        }
    }
}
