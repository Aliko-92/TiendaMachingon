namespace TiendaMachingon.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using TiendaMachingon.Web.Data.Entities;

    public class DataContext:DbContext
    {
        public DbSet<Shop>
            public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
                    
    }
}
