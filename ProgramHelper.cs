using InternetProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider
{
    public static class ProgramHelper
    {
        public static decimal Splitter(string s) 
        {
            string[] res = s.Split();

            if (decimal.TryParse(res[0], out decimal result))
                return result;
            else
                throw new ArgumentException();
        }
        
        public static decimal ARPUCounter(DateTime time) 
        {
            if (CountOfCilents(time) == 0)
                return 0;
            return CountOfIncome(time) / CountOfCilents(time);
        }

        private static decimal CountOfIncome(DateTime time) 
        {
            decimal res = 0;

            for (int i = 0; i < DBController.Instance.Contracts.Count; i++)
            {
                for (int j = 0; j < DBController.Instance.Contracts[i].Payments.Count; j++)
                {
                    if (DBController.Instance.Contracts[i].Payments[j].Date.Month == time.Month 
                        && DBController.Instance.Contracts[i].TypeStatus == ContractStatus.Active)
                        res += DBController.Instance.Contracts[i].Payments[j].Sum;
                }
            }
            return res;
        }
        
        private static int CountOfCilents(DateTime time) 
        {
            int count = 0;
            HashSet<Client> clients = new HashSet<Client>();
            
            for (int i = 0; i < DBController.Instance.Contracts.Count; i++)
            {
                if (DBController.Instance.Contracts[i].Date.Month == time.Month
                    && DBController.Instance.Contracts[i].TypeStatus == ContractStatus.Active)
                {
                    if (!clients.Contains(DBController.Instance.Contracts[i].Client))
                    {
                        clients.Add(DBController.Instance.Contracts[i].Client);
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
