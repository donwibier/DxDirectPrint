using DxDirectPrint.Data.DTO;
using DxDirectPrint.Data.EF;
using FluentValidation;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace DxDirectPrint.Data.Stores
{
	public class InvoiceStore : EFDataStore<ChinookContext, int, DTO.InvoiceModel, Invoice>
	{
        public InvoiceStore(ChinookContext context, IMapper mapper, IValidator<Invoice> validator) 
			: base(context, mapper, validator)
        {

        }

        public override string[] KeyFields => new[] { nameof(Invoice.InvoiceId) };

		public override int ModelKey(DTO.InvoiceModel model) => model.InvoiceId;

		public override void SetModelKey(DTO.InvoiceModel model, int key) => model.InvoiceId = key;

		protected override int DBModelKey(Invoice model) => model.InvoiceId;
	}

	public class InvoiceValidator : AbstractValidator<Invoice>
	{
		public InvoiceValidator()
		{
			RuleFor(x => x.InvoiceDate > DateTime.MinValue);
		}
	}
    public class InvoiceModelValidator : AbstractValidator<DTO.InvoiceModel>
    {
        public InvoiceModelValidator()
        {
            RuleFor(x => x.InvoiceDate > DateTime.MinValue);
        }
    }

	public class InvoiceLineStore : EFDataStore<ChinookContext, int, DTO.InvoiceLineModel, InvoiceLine>
	{
        public InvoiceLineStore(ChinookContext context, IMapper mapper, IValidator<InvoiceLine> validator) 
			: base(context, mapper, validator)
        {

        }

        public override string[] KeyFields => new[] { nameof(InvoiceLine.InvoiceLineId) };

        public override int ModelKey(InvoiceLineModel model) => model.InvoiceLineId;

        public override void SetModelKey(InvoiceLineModel model, int key) => model.InvoiceLineId = key;

        protected override int DBModelKey(InvoiceLine model) => model.InvoiceLineId;

        protected override IQueryable<InvoiceLine> EFQuery()
        {
            return base.EFQuery().Include($"{nameof(InvoiceLine.Track)}.{nameof(Track.Album)}.{nameof(Album.Artist)}");
        }
    }

    public class InvoiceLineValidator : AbstractValidator<InvoiceLine>
    {
        public InvoiceLineValidator()
        {
            
        }
    }
    public class InvoiceLineModelValidator : AbstractValidator<DTO.InvoiceLineModel>
    {
        public InvoiceLineModelValidator()
        {
            
        }
    }

}
