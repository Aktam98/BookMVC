using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class Purchase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int BookId{ get; set; }
        public DateTime Date { get; set; } = DateTime.Now.Date;
    }
}
