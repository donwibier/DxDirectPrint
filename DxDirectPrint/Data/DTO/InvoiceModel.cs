using DxDirectPrint.Data.EF;

namespace DxDirectPrint.Data.DTO
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }

        public int CustomerId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string? BillingAddress { get; set; }

        public string? BillingCity { get; set; }

        public string? BillingState { get; set; }

        public string? BillingCountry { get; set; }

        public string? BillingPostalCode { get; set; }

        public decimal Total { get; set; }

        public virtual CustomerModel Customer { get; set; } = null!;

        public virtual List<InvoiceLineModel> InvoiceLines {  get; set; }  = new List<InvoiceLineModel>();

    }

    public class InvoiceLineModel
    {
        public int InvoiceLineId { get; set; }
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public virtual TrackModel Track { get; set; } = null!;
    }

    public class TrackModel
    {
        public int TrackId { get; set; }
        public string Name { get; set; } = null!;
        public int? AlbumId { get; set; }
        public string? Composer { get; set; }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual AlbumModel? Album { get; set; }
        //public virtual Genre? Genre { get; set; }
        //public virtual MediaType MediaType { get; set; } = null!;
    }

    public partial class AlbumModel
    {
        public int AlbumId { get; set; }
        public string Title { get; set; } = null!;
        public virtual Artist Artist { get; set; } = null!;
    }

    public partial class ArtistModel
    {
        public int ArtistId { get; set; }
        public string? Name { get; set; }
    }
}
