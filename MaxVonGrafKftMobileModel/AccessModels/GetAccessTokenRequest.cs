using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetAccessTokenRequest
    {
        public string client_id { get; set; }
        public string grant_type { set; get; }
        public string client_secret { get; set; }
    }
}
