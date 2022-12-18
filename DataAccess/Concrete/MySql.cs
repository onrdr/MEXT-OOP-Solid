using Entities.Abstract;

namespace DataAccess.Concrete
{
    public class MySql : IDatabase
    {
        public void Add(IPerson student)
        {
            Console.WriteLine($"MySql => {student.FirstName} is added to database");
        }

        public void Update(IPerson student)
        {
            Console.WriteLine($"MySql => {student.FirstName} is updated in database");
        }

        public void Delete(IPerson student)
        {
            Console.WriteLine($"MySql => {student.FirstName} is removed from database");
        }
    }
}
