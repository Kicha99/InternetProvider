using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Model
{
    public enum RequestStatus
    {
        New, //необработанная
        Accept, //принята 
        Discard //Отклонена
    }
}
