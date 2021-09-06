using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetProvider.Model;

namespace InternetProvider
{
    public class ProviderContext : DbContext
    {
        static ProviderContext()
        {
            Database.SetInitializer(new MyContextInitializer());
        }

        public ProviderContext() : base("DBConnection")
        {
        }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
