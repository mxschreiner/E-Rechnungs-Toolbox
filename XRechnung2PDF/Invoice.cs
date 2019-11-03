using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRechnung2PDF
{
    class Invoice
    {
        private List<InvoiceLine> invoiceLines;

        public List<InvoiceLine> InvoiceLines { get => invoiceLines; set => invoiceLines = value; }

        public void AddInvoiceLine(InvoiceLine line)
        {
            if (InvoiceLines == null)
                InvoiceLines = new List<InvoiceLine>();

            InvoiceLines.Add(line);
        }

    }
}
