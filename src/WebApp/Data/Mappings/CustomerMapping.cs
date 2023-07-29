using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Domain;

namespace WebApp.Data.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(customer => customer.Id);

            builder.Property(customer => customer.Name)
                .IsRequired()
                .HasMaxLength(125);

            builder.Property(customer => customer.Email)
                .IsRequired();

            builder.Property(customer => customer.DateOfBirth);

            builder.Property(customer => customer.RegistrationDate)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(customer => customer.Active)
                .HasDefaultValue(true);
        }
    }
}
