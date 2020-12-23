using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class VehicleTypeMobileResult
    {

        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public int ClientID { get; set; }
        public decimal? FullValue { get; set; }
        public string Sample { get; set; }
        public string Seats { get; set; }
        public string Doors { get; set; }
        public bool IsReservation { get; set; }
        public int Baggages { get; set; }
        public decimal Deposit { get; set; }
        public string path { get; set; }
        public string HtmlContent { get; set; }
        public string Price { get; set; }
        public bool selected { get; set; }

    }
}
