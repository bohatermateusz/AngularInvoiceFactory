using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHRVS.Models
{
    public class Invoice
    {
        int invoiceId { get; set; }
        int year { get; set; }
        int month { get; set; }
        int number { get; set; }
        Client client { get; set; }
        DateTime selldate { get; set; }
        DateTime issuedate { get; set; }
        int paytime { get; set; }
        PaymentType paymentType { get; set; }
        bool isPayed { get; set; }
        InvoiceRows invoiceRows { get; set; }
        int sum { get; set; }

    }

    internal class Client
    {
        int nip { get; set; }
        string address { get; set; }
        string country { get; set; }
    }

    internal class PaymentType
    {
        bool trasfer { get; set; }
        bool cash { get; set; }
        bool card { get; set; }
    }

    internal class InvoiceRows
    {
        string nameOfGood { get; set; }
        int price { get; set; }
        int amount { get; set; }

        int tax { get; set; }
    }


}
