using Microsoft.EntityFrameworkCore;

namespace SuperHeroesAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<SuperHeroes> SuperHeroes { get; set; }
    }
}
