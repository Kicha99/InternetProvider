using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    public class Request
    {
       
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public virtual Client Client { get; set; }
        public virtual Tariff Tariff { get; set; }
        public RequestStatus Status { get; set; }
        public string Answer { get; set; }
        public string Address { get; set; }
        public virtual Contract Contract { get; set; }

    }
}
