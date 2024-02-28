using CMS.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.WebApp.ModelConfiguration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(nameof(Customer));
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x=>x.Email).HasMaxLength(50).IsRequired();
        builder.Property(x=>x.Phone).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Address).HasMaxLength(200).IsRequired();
        builder.HasData(new Customer
        {
            Id = 1,
            Name= "Tamim",
            Email="tamim@gmail.com",
            Phone= "01348347233",
            Address="Dhaka"
        });

    }
}
