using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DxDirectPrint.Data;
using DxDirectPrint.Data.DTO;
using DxDirectPrint.Reports;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
        readonly UserManager<ApplicationUser> userManager;
        public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService,
            UserManager<ApplicationUser> userManager)
        {
            this.invoiceService = invoiceService;
            this.userManager = userManager;
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
            byte[] content = await invoiceService.GetInvoiceReceiptPDFAsync(HttpContext?.User?.Identity?.Name, id);
            return File(content, "application/pdf");
        }

        [Authorize(AuthenticationSchemes = $"JWT_OR_COOKIE,{JwtBearerDefaults.AuthenticationScheme}")]
        [HttpPost("PDF")]
        public async Task<IActionResult> OrderPDF([FromBody] PostPDFModel model)
        {
            var user = HttpContext?.User?.Identity?.Name;
            if (string.IsNullOrEmpty(user))
            {
                var u = await userManager.FindByIdAsync(model.UserID);
                user = u.UserName;
            }
            if (string.IsNullOrEmpty(user))
            {
                throw new UnauthorizedAccessException();
            }
            var result = await invoiceService.GetInvoiceReceiptPDFAsync(user, model.OrderID);
            if (result != null)
            {
                return File(result, "application/pdf");
            }

            throw new UnauthorizedAccessException();
        }
    }

    public record PostPDFModel(int OrderID, string UserID);
}
