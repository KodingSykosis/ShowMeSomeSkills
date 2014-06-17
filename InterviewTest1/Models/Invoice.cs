using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTest1.Models
{
    public class Invoice
    {
        public IEnumerable<InvoiceItems> LineItems { get; set; }
    }
}
