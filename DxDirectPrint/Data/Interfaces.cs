using DevExpress.Blazor;
using DxDirectPrint.Data.DTO;
using FluentValidation;

namespace DxDirectPrint.Data
{
	public enum DataMode
	{
		Create,
		Update,
		Delete
	}

	public interface IDataResult
	{
		bool Success { get; set; }
		DataMode Mode { get; set; }
		ValidationException Exception { get; set; }
	}

	public interface IDataStore<TKey, TModel>
		where TKey : IEquatable<TKey>
		where TModel : class, new()
	{
		string[] KeyFields { get; }
		TModel GetByKey(TKey key);
		IQueryable<T> Query<T>() where T : class, new();
		IQueryable<TModel> Query();
		TKey ModelKey(TModel model);
		void SetModelKey(TModel model, TKey key);
		Task<IDataResult> CreateAsync(params TModel[] items);
		Task<IDataResult> UpdateAsync(params TModel[] items);
		Task<IDataResult> DeleteAsync(params TKey[] ids);
        Task<TModel> GetByKeyAsync(TKey key);
    }

    public interface IDataService<TKey, TModel>
        where TKey : IEquatable<TKey>
        where TModel : class, new()
    {
        IValidator<TModel> Validator { get; }
        IDataStore<TKey, TModel> MainStore { get; }

        Task<TModel> GetByKeyAsync(TKey key);
        GridDevExtremeDataSource<TModel> GetMainDatasource();
        
    }

	public interface IInvoiceService : IDataService<int, InvoiceModel>
	{
        Task<byte[]> GetInvoiceReceiptPDFAsync(string username, int invoiceId, string reportName);
    }
}
