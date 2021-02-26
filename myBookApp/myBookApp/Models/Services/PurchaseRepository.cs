using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models.Services
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly BookContext _bookContext;

        public PurchaseRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        public void AddPurchase(Purchase purchase)
        {
            _bookContext.purchases.Add(purchase);
            _bookContext.SaveChanges();
        }

        public IEnumerable<Purchase> GetAllPurchases()
        {
            return _bookContext.purchases;
        }

        public IEnumerable<Purchase> GetPurchases(int id)
        {
            return (IEnumerable<Purchase>)_bookContext.purchases.FirstOrDefault(x => x.ClientId.Equals(id));
        }
    }
}
