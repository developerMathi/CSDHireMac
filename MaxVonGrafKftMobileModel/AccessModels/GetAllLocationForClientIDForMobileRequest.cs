using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    [Serializable]
    public class GetAllLocationForClientIDForMobileRequest
    {
        public int ClientID { get; set; }
    }
}
