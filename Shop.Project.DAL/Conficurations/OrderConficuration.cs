using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Project.Models.Concrate;

namespace Shop.Project.DAL.Conficurations;

public class OrderConficuration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.
            HasKey(x => x.Id);
    }
}
