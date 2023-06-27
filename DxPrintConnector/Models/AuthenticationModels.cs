using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxPrintConnector.Models
{
    public class AuthenticationModel
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; } = string.Empty;
    }

    public class AuthResponseModel
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }

    public class RefreshModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }

	public record PrintPDFArgs(string Printer, int Copies, int OrderID, string UserID, string ReportName);
	public record PostPDFModel(int OrderID, string UserID, string ReportName);

}
