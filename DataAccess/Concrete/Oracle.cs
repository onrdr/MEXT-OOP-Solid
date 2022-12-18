using Entities.Abstract;

public class Oracle : IDatabase
{
    public void Add(IPerson student)
    {
        Console.WriteLine($"Oracle => {student.FirstName} is added to database");
    }

    public void Update(IPerson student)
    {
        Console.WriteLine($"Oracle => {student.FirstName} is updated in database");
    }

    public void Delete(IPerson student)
    {
        Console.WriteLine($"Oracle => {student.FirstName} is removed from database");
    }
}



