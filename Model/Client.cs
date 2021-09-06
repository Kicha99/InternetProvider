using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    [Table("Client")]
    public class Client : Person
    {
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
    }
}
