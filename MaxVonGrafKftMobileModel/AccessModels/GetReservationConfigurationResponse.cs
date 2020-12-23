using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetReservationConfigurationResponse
    {

        public List<ReservationVehicleSearchViewModel> listVehicle { get; set; }
        public ApiMessage message { get; set; }
    }
}
