using InternetProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider
{
    public class ApplicationHelper
    {
        private static ApplicationHelper instance;

        public static ApplicationHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationHelper();
                return instance;
            }
        }

        private ApplicationHelper()
        {
        }

        public Person CurrentUser { get; set; }

        public Role CurrentRole
        {
            get
            {
                if (CurrentUser is Administrator)
                    return Role.Admin;
                else if (CurrentUser is Client)
                    return Role.Client;
                else
                    return Role.Guest;
            }
        }
    }
}
