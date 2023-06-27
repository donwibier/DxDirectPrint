using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DxDirectPrint.Data;
using DxDirectPrint.Data.DTO;
using DxDirectPrint.Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DxDirectPrint.Controllers
{
    public class InvoiceController : Controller
    {
        readonly ILogger<InvoiceController> logger;        
        readonly IInvoiceService invoiceService;
        
        public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
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
            byte[] content = await invoiceService.GetInvoiceReceiptPDFAsync(HttpContext?.User?.Identity?.Name!, id, "Receipt");
            return File(content, "application/pdf");
        }

        //[Authorize(AuthenticationSchemes = $"JWT_OR_COOKIE,{JwtBearerDefaults.AuthenticationScheme}")]
        [HttpPost("PDF")]
        public async Task<IActionResult> OrderPDF([FromBody] PostPDFModel model)
        {
            var user = HttpContext?.User?.Identity?.Name??model.UserID;
            var result = await invoiceService.GetInvoiceReceiptPDFAsync(user!, model.OrderID, model.ReportName);
            if (result != null)
            {
                return File(result, "application/pdf");
            }

            throw new UnauthorizedAccessException();
        }
    }

    public record PostPDFModel(int OrderID, string UserID, string ReportName);

}
