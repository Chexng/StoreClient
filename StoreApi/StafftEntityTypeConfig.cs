using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductLib;

namespace ProductApi;

public class StaffEntityTypeConfig : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.ToTable("Staffs");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.StaffId).IsUnique(true);

        builder.Property(x => x.Id)
            .IsRequired(true)
            .HasColumnName(nameof(Staff.Id))
            .HasColumnType("varchar")
            .HasMaxLength(36)
            .IsUnicode(false)
            ;
        builder.Property(x => x.StaffId)
            .IsRequired(true)
            .HasColumnName(nameof(Staff.StaffId))
            .HasColumnType("nvarchar")
            .HasMaxLength(20)
            .IsUnicode(true)
            ;
        builder.Property(x => x.SName)
            .IsRequired(false)
            .HasColumnName(nameof(Staff.SName))
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsUnicode(true)
            ;
        builder.Property(x => x.Position)
            .IsRequired(true)
            .HasColumnName(nameof(Staff.Position))
            .HasColumnType("tinyint")
            ;
        builder.Property(x => x.CreatedOn)
            .IsRequired(false)
            .HasColumnName(nameof(Product.CreatedOn))
            .HasColumnType("datetime")
            ;
        builder.Property(x => x.LastUpdatedOn)
            .IsRequired(false)
            .HasColumnName(nameof(Product.LastUpdatedOn))
            .HasColumnType("datetime")
            ;
    }
}
