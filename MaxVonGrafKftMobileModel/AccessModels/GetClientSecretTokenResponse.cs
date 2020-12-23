using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetClientSecretTokenResponse
    {
        public string apiConsumerId { get; set; }
        public string apiConsumerSecret { get; set; }
        public ApiToken apiToken { get; set; }
    }
}
