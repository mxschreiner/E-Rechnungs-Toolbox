using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XRechnung2PDF
{
    class XML_Invoice_Mapper
    {
        public static Invoice MapXMLToInvoice(XDocument xml)
        {
            var invoice = new Invoice();

            foreach(var e in GetInvoiceLines(xml))
            {
                var line = new InvoiceLine();
                line.Id = Int32.Parse(e.GetElementByLocalName("ID").Value);
                line.Quantity = Double.Parse(e.GetElementByLocalName("InvoicedQuantity").Value);
                line.PricePerUnit = Double.Parse(e.GetElementByLocalName("LineExtensionAmount").Value);
                line.Name = e.GetElementByLocalName("Item").GetElementByLocalName("Name").Value;
                line.Description = e.GetElementByLocalName("Item").GetElementByLocalName("Description").Value;

                invoice.AddInvoiceLine(line);
            }


            return invoice;
        }

        
        private static IEnumerable<XElement> GetInvoiceLines(XDocument xml)
        {
            return xml.Root.Descendants()
                        .Where(c => c.Name.LocalName == "InvoiceLine");
        }

    }

    static class XElementAddedMethods
    {
        public static XElement GetElementByLocalName(this XElement e, string name)
        {
            return e.Elements().Where(x => x.Name.LocalName == name).First();
        }
    }
}
