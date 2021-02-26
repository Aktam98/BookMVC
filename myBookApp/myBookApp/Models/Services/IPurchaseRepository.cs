using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models.Services
{
    public interface IPurchaseRepository
    {
        void AddPurchase(Purchase purchase);
        IEnumerable<Purchase> GetPurchases(int id);
        IEnumerable<Purchase> GetAllPurchases();
    }
}
