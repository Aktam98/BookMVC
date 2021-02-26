using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClient();
        Client GetClient(int id);
        void AddClient(int id, Client client);
        void DeleteClient(Client client);
        void UpdateClient(Client client);

    }
}
