using Microsoft.EntityFrameworkCore;

public class MobileContext : DbContext
{
    public MobileContext(DbContextOptions<MobileContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
}
