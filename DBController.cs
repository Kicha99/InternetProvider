using InternetProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider
{
    public class DBController
    {
        private static DBController instance;
        private ProviderContext providerContext = new ProviderContext();

        public static DBController Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBController();
                return instance;
            }
        }

        private DBController()
        {
        }

        public List<Tariff> Tariffs
        {
            get
            {
                return providerContext.Tariffs.ToList();
            }
        }

        public void Update(Tariff tariff)
        {
            if (tariff.Id == 0)
                providerContext.Tariffs.Add(tariff);
            providerContext.SaveChanges();
        }

        public void Remove(Tariff tariff)
        {
            providerContext.Tariffs.Remove(tariff);
            providerContext.SaveChanges();
        }

        public List<Client> Clients 
        {
            get 
            {
                return providerContext.Clients.ToList();
            }
        }

        public void Update(Client client) 
        {
            if (client.Id == 0)
                providerContext.Clients.Add(client);
            providerContext.SaveChanges();
        }

        public void Remove(Client client) 
        {
            providerContext.Clients.Remove(client);
            providerContext.SaveChanges();
        }

        public List<Request> Requests 
        {
            get 
            {
                return providerContext.Requests.ToList();
            }
        }

        public List<Request> GetRequests(Client client)
        {
            return providerContext.Requests.Where(t => t.Client.Id == client.Id).ToList();
        }

        public List<Request> GetNewRequests()
        {
            return providerContext.Requests.Where(t => t.Status == RequestStatus.New).ToList();
        }

        public List<Request> GetProcessRequests()
        {
            return providerContext.Requests.Where(t => t.Status != RequestStatus.New).ToList();
        }

        public void Update(Request request) 
        {
            if (request.Id == 0)
                providerContext.Requests.Add(request);
            providerContext.SaveChanges();
        }

        public void Remove(Request request) 
        {
            providerContext.Requests.Remove(request);
            providerContext.SaveChanges();
        }

        public List<Administrator> Administrators
        {
            get
            {
                return providerContext.Administrators.ToList();
            }
        }

        public void Update(Administrator administrator) 
        {
            if (administrator.Id == 0)
                providerContext.Administrators.Add(administrator);
            providerContext.SaveChanges();
        }

        public void Remove(Administrator administrator) 
        {
            providerContext.Administrators.Remove(administrator);
            providerContext.SaveChanges();
        }

        public List<Contract> Contracts
        {
            get
            {
                return providerContext.Contracts.ToList();
            }
        }

        public void Update(Contract contract)
        {
            if (contract.Id == 0)
                providerContext.Contracts.Add(contract);
            providerContext.SaveChanges();
        }

        public void Remove(Contract contract)
        {
            providerContext.Contracts.Remove(contract);
            providerContext.SaveChanges();
        }

        public void Update(Payment payment)
        {
            if (payment.Id == 0)
                providerContext.Payments.Add(payment);
            providerContext.SaveChanges();
        }

        public int MaxNumberRequest()
        {
            int max = 1;
            if (providerContext.Requests.Any())
                max = providerContext.Requests.Max(t => t.Number);
            return max;
        }
    }
}
