using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DxDirectPrint.Data;
using DxDirectPrint.Data.DTO;
using DxDirectPrint.Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DxDirectPrint.Controllers
{
    public class InvoiceController : Controller
    {
        readonly ILogger<InvoiceController> logger;        
        readonly IDataService<int, InvoiceModel> invoiceService;
        public InvoiceController(ILogger<InvoiceController> logger, IDataService<int, InvoiceModel> invoiceService)
        {
            this.invoiceService = invoiceService;
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
            var order = await invoiceService.GetByKeyAsync(id);                            
            if (order == null)
            {
                throw new KeyNotFoundException();
            }



            //await dbCtx.Entry(order)
            //    .Reference(o => o.Customer).LoadAsync();
			//await dbCtx.Entry(order)
			//	.Collection(o => o.InvoiceLines).LoadAsync();


			XtraReport report = new XtraReport1();
            report.DataSource = new List<InvoiceModel>(new[] { order });
            
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
