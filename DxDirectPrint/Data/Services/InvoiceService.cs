using DevExpress.PivotGrid.OLAP;
using DevExpress.XtraReports.UI;
using DxDirectPrint.Reports;
using DxDirectPrint.Data.DTO;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace DxDirectPrint.Data.Services
{
    public class InvoiceService : BaseDataService<int, DTO.InvoiceModel>, IInvoiceService
    {
        public IDataStore<int, InvoiceLineModel> InvoiceLineStore { get; }
        public IDataStore<int, CustomerModel> CustomerStore { get; }
        public InvoiceService(IDataStore<int, InvoiceModel> mainStore, IDataStore<int, InvoiceLineModel> invoiceLineStore,
                    IDataStore<int, CustomerModel> customerStore,
                    IValidator<InvoiceModel> validator)
            : base(mainStore, validator)
        {
            CustomerStore = customerStore;
            InvoiceLineStore = invoiceLineStore;
        }

        public async override Task<InvoiceModel> GetByKeyAsync(int key)
        {
            var result = await base.GetByKeyAsync(key);
            result.InvoiceLines = await InvoiceLineStore.Query().Where(o => o.InvoiceId == key).ToListAsync();
            result.Customer = await CustomerStore.GetByKeyAsync(result.CustomerId);

            return result;
        }

        public async Task<byte[]> GetInvoiceReceiptPDFAsync(string username, int invoiceId, string reportName)
        {
            ArgumentNullException.ThrowIfNull(invoiceId);
            ArgumentNullException.ThrowIfNull(username);
            //ArgumentNullException.ThrowIfNull(reportName);

            var order = await GetByKeyAsync(invoiceId);
            ArgumentNullException.ThrowIfNull(order);
            
            
            XtraReport report = (reportName == "Receipt") 
                ? new Receipt() 
                : new XtraReport1(); 

            ArgumentNullException.ThrowIfNull(report);

            report.DataSource = new List<InvoiceModel>(new[] { order });            
            //report.ApplyLocalization("en-US");
            
            byte[] content = null!;
            using (MemoryStream ms = new MemoryStream())
            {
                await report.ExportToPdfAsync(ms);
                content = ms.ToArray();
            }
            return content;
        }

    }
}
