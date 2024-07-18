using Location_photocopieur.Data;
using Location_photocopieur.Interface;

namespace Location_photocopieur.Repository
{
    internal class ClientRepository : IRepository<Database>
    {
        private Database _database;
        private Database Database { get => _database; }
        public ClientRepository(Database database)
        {
            _database = database;
        }

        public Database Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Database> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Database entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Database entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
