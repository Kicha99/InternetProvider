using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Speed { get; set; }
        public int CountChannel { get; set; }
        public TariffStatus Status { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
