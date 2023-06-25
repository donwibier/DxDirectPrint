using DxDirectPrint.Data.DTO;
using DxDirectPrint.Data.EF;
using FluentValidation;
using MapsterMapper;

namespace DxDirectPrint.Data.Stores
{
    public class CustomerStore :  EFDataStore<ChinookContext, int, DTO.CustomerModel, Customer>
    {
        public CustomerStore(ChinookContext context, IMapper mapper, IValidator<Customer> validator) : base(context, mapper, validator)
        {

        }

        //public CustomerStore(ChinookContext context, IMapper mapper, IValidator<Customer> validator) 
        //    : base(context, mapper, validator)
        //{

        //}

        public override string[] KeyFields => new[] { nameof(Customer.CustomerId)};

        public override int ModelKey(CustomerModel model) => model.CustomerId;

        public override void SetModelKey(CustomerModel model, int key) => model.CustomerId = key;

        protected override int DBModelKey(Customer model) => model.CustomerId;
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {

        }
    }
    public class CustomerModelValidator : AbstractValidator<DTO.CustomerModel>
    {
        public CustomerModelValidator()
        {

        }
    }


}
