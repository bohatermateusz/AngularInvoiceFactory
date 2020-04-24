using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHRVS.Models
{
    public class InvoiceAccessDataLayer
    {
            //Lista imitujaca polaczenie do bazy danych
            List<Invoice> dbImitation = new List<Invoice>();
                                          
            public int AddInvoiceData(Invoice invoice)
            {
                try
                {
                    dbImitation.Add(invoice);
                    return 1;
                }
                catch
                {
                    throw;
                }
            }   
    }
}
