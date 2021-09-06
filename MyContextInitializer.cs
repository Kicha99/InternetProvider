using InternetProvider.Entities;
using InternetProvider.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider
{
    public class MyContextInitializer : DropCreateDatabaseIfModelChanges<ProviderContext>
    {
        protected override void Seed(ProviderContext context)
        {
            base.Seed(context);

            Administrator administrator = new Administrator();
            administrator.Login = "admin";
            administrator.Password = Helper.GetHash("");

            context.Administrators.Add(administrator);

            Tariff tariff1 = new Tariff();
            tariff1.Cost = 900;
            tariff1.Name = "Мега";
            tariff1.Status = TariffStatus.Active;
            tariff1.CountChannel = 100;

            context.Tariffs.Add(tariff1);

            Client client = new Client();
            client.Birthday = new DateTime(2000, 1, 1);
            client.FIO = "Иванов Олег";
            client.Login = "oleg";
            client.Password = Helper.GetHash("1234");

            context.Clients.Add(client);

            context.SaveChanges();
        }
    }
}
