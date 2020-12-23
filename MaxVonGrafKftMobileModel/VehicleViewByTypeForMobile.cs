using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class VehicleViewByTypeForMobile
    {
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public string Transmission { get; set; }
        public int Seats { get; set; }
        public string VehicleImageUrl { get; set; }
        public string sample { get; set; }
        public int NoOfLuggage { get; set; }
        public double RateTotal { get; set; }
        
        public RateDetail RateDetail { get; set; }

    }
}
