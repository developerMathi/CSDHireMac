using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ShowDriverInReservationResponse
    {
        public List<Driver> CustomerDriverList { get; set; }
        public ApiMessage message { get; set; }
    }
}
