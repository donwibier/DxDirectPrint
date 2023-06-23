using DxDirectPrint.Data.DTO;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace DxDirectPrint.Data.Services
{
    public class InvoiceService : BaseDataService<int, DTO.InvoiceModel>
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
    }
}
