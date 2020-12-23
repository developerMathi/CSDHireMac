using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetForgetPasswordMobileRequest
    {
        public string email { get; set; }
        public string callBackUrl { get; set; }
        public DateTime? clienTime { get; set; }
    }
}
