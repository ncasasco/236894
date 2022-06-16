using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Ticket
    {
        [Key]
        public string name {get; set;}
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
