using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Project.Models.Concrate;
using System.Reflection.Emit;

namespace Shop.Project.DAL.Conficurations;

public class CategoryConficuration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).HasMaxLength(20);

    }
}
