namespace TiendaMachingon.Web.Data.Entities
{
    public class Sale: IEntity
    {
        [key]

        public int Id { get; set; }

        public double Date { get; set; }

        public int Subtotal { get; set; }

        public int IVA { get; set; }

        public int TotalSale { get; set; }

        public int Quantity { get; set; }

        public string PaymentType { get; set; }
        

    }
}
