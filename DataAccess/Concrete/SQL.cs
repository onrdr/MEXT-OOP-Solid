using Entities.Abstract;

public class SQL : IDatabase
{
    public void Add(IPerson student)
    {
        Console.WriteLine($"SQL => {student.FirstName} is added to database");
    }

    public void Update(IPerson student)
    {
        Console.WriteLine($"SQL => {student.FirstName} is updated in database");
    }

    public void Delete(IPerson student)
    {
        Console.WriteLine($"SQL => {student.FirstName} is removed from database");
    }
}



