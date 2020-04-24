using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SyncHRVS.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SyncHRVS.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        InvoiceAccessDataLayer objInvoice = new InvoiceAccessDataLayer();

        [HttpPost]
        [Route("api/Invoice/Create")]
        public int Create([FromBody] Invoice employee)
        {
            return objInvoice.AddInvoiceData(employee);
        }

    }
}
