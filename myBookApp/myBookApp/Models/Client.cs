using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class Client
    {
        
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Mobile { get; set; }        
        
            
    }
}
