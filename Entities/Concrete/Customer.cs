using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IPerson 
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public Customer(string id, string firstName, string lastName, string department)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
    }
}
