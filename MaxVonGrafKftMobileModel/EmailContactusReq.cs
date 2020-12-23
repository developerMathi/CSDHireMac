using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class EmailContactusReq
    {
        public string email { get; set; }
        public string name { get; set; }
        public string phonenumber { get; set; }
        public string templatekey { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
