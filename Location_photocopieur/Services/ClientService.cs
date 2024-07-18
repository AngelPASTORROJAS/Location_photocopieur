using Location_photocopieur.Data;
using Location_photocopieur.Entites;
using Location_photocopieur.Interface;

namespace Location_photocopieur.Services
{
    internal class ClientService
    {
        private readonly IRepository<Client> _clientRepository;

        private Database _data = new Database();
        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        // Business logic methods that utilize the repository
        // ...

        public static void GetClients()
        {
            // TODO
        }

        public void CreateTable()
        {
            _data.CreateTableClient();
        }

        public void DropTable()
        {
            _data.DropTable("Client");
        }
    }
}
