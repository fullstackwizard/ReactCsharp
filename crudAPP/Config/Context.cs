namespace crudAPP.Config
{
    public class Context : DbContext        
    {
        public Context(DbContextOptions<Context> options) : base(options){
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set;}
    }
}