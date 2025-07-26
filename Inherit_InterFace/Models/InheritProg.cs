namespace Inherit_InterFace.Models
{
    public class BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            var today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (Birthday.Date > today.AddYears(-age)) age--;
            return age;
        }
        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
    }

    public interface IDescription
    {
        string Describe();
    }

    public class Customer : BaseEntity, IDescription
    {
        public int CustomerId { get; set; }
        public virtual string Describe()
        {
            return $"Customer #{CustomerId}: {GetFullName()}, Age: {GetAge()}";
        }
    }

    public class VipCustomer : Customer
    {
        public override string Describe()
        {
            return $"VIP Customer #{CustomerId}: {GetFullName()}, Age: {GetAge()} - Exclusive Benefits!";
        }
    }
}
