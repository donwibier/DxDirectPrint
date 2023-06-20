using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DxDirectPrint.Data.EF;
using DxDirectPrint.Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DxDirectPrint.Controllers
{
    public class InvoiceController : Controller
    {
        readonly ILogger<InvoiceController> logger;
        readonly ChinookContext dbCtx;
        public InvoiceController(ILogger<InvoiceController> logger, ChinookContext dbCtx) {
            this.dbCtx = dbCtx;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize]
        [HttpGet("GetOrderPDF/{id}.pdf")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = dbCtx.Invoices.Where(i => i.InvoiceId == id).FirstOrDefault();
            if (order == null)
            {
                throw new KeyNotFoundException();
            }
            XtraReport report = new XtraReport1();
            report.DataSource = new List<Invoice>(new[] { order });
            
            byte[] content = null!;
            using (MemoryStream ms = new MemoryStream())
            {
                await report.ExportToPdfAsync(ms);
                content = ms.ToArray();
            }
            return File(content, "application/pdf");
        }
    }
}
