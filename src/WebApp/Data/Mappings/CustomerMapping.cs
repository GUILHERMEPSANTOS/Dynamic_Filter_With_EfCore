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

            builder.HasData(
                new Customer("Guilherme", "guilherme@hotmail.com", true, DateTime.UtcNow.AddYears(-3), DateTime.UtcNow.AddYears(-18)),
                new Customer("Ana", "ana123@gmail.com", true, DateTime.UtcNow.AddYears(-2), DateTime.UtcNow.AddYears(-17)),
                new Customer("Carlos", "carlos45@yahoo.com", true, DateTime.UtcNow.AddYears(-4), DateTime.UtcNow.AddYears(-19)),
                new Customer("Maria", "maria87@hotmail.com", true, DateTime.UtcNow.AddYears(-1), DateTime.UtcNow.AddYears(-16)),
                new Customer("Rafael", "rafael.mtz@gmail.com", true, DateTime.UtcNow.AddYears(-5), DateTime.UtcNow.AddYears(-20))
            );

        }
    }
}
