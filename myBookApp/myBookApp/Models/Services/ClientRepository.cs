using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly BookContext _db;

        public ClientRepository(BookContext bookContext)
        {
            _db = bookContext;
        }
        public void AddClient(int id,Client client)
        {
            
            _db.clients.Add(client);
            _db.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            _db.clients.Remove(client);
            _db.SaveChanges();
        }

        public IEnumerable<Client> GetAllClient()
        {              
            return _db.clients;
        }

        public Client GetClient(int id)
        {
            return _db.clients.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void UpdateClient(Client client)
        {
            _db.clients.Update(client);
            _db.SaveChanges();
        }
    }
}
