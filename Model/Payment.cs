using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public virtual Contract Contract { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
