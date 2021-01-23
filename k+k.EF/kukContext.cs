using k_k.Model;
using Microsoft.EntityFrameworkCore;

public class KuKContext : DbContext
{
    public KuKContext()
    { 

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=tcp:maid.database.windows.net,1433;Initial Catalog=kukDB;Persist Security Info=False;User ID=maid1991;Password=Palladium9911;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");//TO Do Password in Code
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    //entities
    public DbSet<kukUser> Users { get; set; }
    public DbSet<kukNotice> Notices { get; set; }
    public DbSet<kukMessage> Messages { get; set; }

}