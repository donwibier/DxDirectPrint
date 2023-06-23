using DevExpress.Blazor;
using FluentValidation;

namespace DxDirectPrint.Data.Services
{

    public abstract class BaseDataService<TKey, TModel> : IDataService<TKey, TModel>
        where TKey : IEquatable<TKey>
        where TModel : class, new()
    {
        public BaseDataService(IDataStore<TKey, TModel> mainStore, IValidator<TModel> validator)
        {
            Validator = validator;
            MainStore = mainStore;
        }
        public IValidator<TModel> Validator { get; }
        public IDataStore<TKey, TModel> MainStore { get; }

        protected virtual GridDevExtremeDataSource<T> GetDatasource<T>(IDataStore<TKey, T> datastore)
            where T : class, new()
        {
            var dataSource = new GridDevExtremeDataSource<T>(datastore.Query());
            dataSource.CustomizeLoadOptions = (loadOptions) =>
            {
                loadOptions.PrimaryKey = datastore.KeyFields;
                loadOptions.PaginateViaPrimaryKey = true;
            };
            return dataSource;

        }

        public virtual GridDevExtremeDataSource<TModel> GetMainDatasource()
        {
            return GetDatasource(MainStore);
        }

        public async virtual Task<TModel> GetByKeyAsync(TKey key) => await MainStore.GetByKeyAsync(key);
    }

}
