using Entities.Abstract;

namespace Business
{
    public class DatabaseCrudManager
    { 
        private readonly IDatabase _database;

        public DatabaseCrudManager(IDatabase database)
        {
            _database = database;
        }

        public void AddToDb(IPerson person)
        {
            _database.Add(person);
        }   
        
         public void UpdateInDb(IPerson person)
        {
            _database.Update(person);
        }

        public void DeleteFromDb(IPerson person)
        {
            _database.Delete(person);
        }
    }
}
