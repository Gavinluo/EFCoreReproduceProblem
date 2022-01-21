using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreReproduceProblem
{
    public class itemMap : IEntityTypeConfiguration<item>
    {

        public void Configure(EntityTypeBuilder<item> builder)
        {
            // Primary Key
            builder.HasKey(t => t.ItemGID);

            // Properties
            builder.Property(t => t.ItemGID)
                .IsRequired()
                .HasMaxLength(100);


            // Table & Column Mappings
            builder.ToTable("item");
            builder.Property(t => t.ItemGID).HasColumnName("ItemGID");
        }
    }
}
