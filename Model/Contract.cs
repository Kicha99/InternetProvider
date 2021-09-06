using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    public class Contract
    {
        [Key]
        [ForeignKey("Request")]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public virtual Client Client { get; set; }
        public virtual Tariff Tariff { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public ContractStatus TypeStatus { get; set; }
        public virtual Request Request { get; set; }

        public virtual List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
