using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductLib;
using ProductLib.Extensions;

namespace ProductApi;

public class SqlDbContext : DbContext, IDbContext
{
    public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityTypeConfig());
        SeedProductData(modelBuilder.Entity<Product>());
        modelBuilder.ApplyConfiguration(new StaffEntityTypeConfig());
        SeedStaffData(modelBuilder.Entity<Staff>());
    }

    private void SeedProductData(EntityTypeBuilder<Product> entityTypeBuilder)
    {
        var reqs = new List<ProductCreateReq>()
        {
            new()
            {
                Code = "PRD001",
                Name = "Nike Jacket",
                Category= "Jacket"
            },
            new()
            {
                Code = "PRD002",
                Name = "Puma Shirt",
                Category= "Shirt"
            },
            
        };
        entityTypeBuilder.HasData(reqs.Select(x => x.ToEntity()));
    }
    private void SeedStaffData(EntityTypeBuilder<Staff> entityTypeBuilder)
    {
        var reqs = new List<StaffCreateReq>()
        {
            new()
            {
                StaffKey = "STF001",
                SName = "Rothna",
                Position= "Seller"
            }
        };
        entityTypeBuilder.HasData(reqs.Select(x => x.ToEntity()));
    }
}
