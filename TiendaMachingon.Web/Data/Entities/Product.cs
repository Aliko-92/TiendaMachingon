namespace TiendaMachingon.Web.Data.Entities
{
    public class Product: IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Precio { get; set; }

        public int MyProperty { get; set; }
    }
}
