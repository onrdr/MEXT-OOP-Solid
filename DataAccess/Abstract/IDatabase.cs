using Entities.Abstract; 

public interface IDatabase 
{
    public void Add(IPerson student);
    public void Update(IPerson student);
    public void Delete(IPerson student);
}



