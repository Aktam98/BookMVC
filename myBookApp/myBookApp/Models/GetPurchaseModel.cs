using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class GetPurchaseModel
    {
        public Book books { get; set; }
        public Client clients { get; set; }
        public DateTime Date { get; set; }
    }
}
