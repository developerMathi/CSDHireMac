using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    [Serializable]
    public class UpdateReservationMobileResponse
    {
        public string ReservationNumber { get; set; }
        public int ReservID { get; set; }

        public ApiMessage message { get; set; }
    }
}
