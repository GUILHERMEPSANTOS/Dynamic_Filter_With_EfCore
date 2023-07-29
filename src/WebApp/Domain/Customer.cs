namespace WebApp.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Active { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public Customer()
        {
        }

        public Customer(int id, string name, string email, string active, DateTime registrationDate, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Active = active;
            RegistrationDate = registrationDate;
            DateOfBirth = dateOfBirth;
        }

    }
}
