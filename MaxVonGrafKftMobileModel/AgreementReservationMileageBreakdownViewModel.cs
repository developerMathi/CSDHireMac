using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class AgreementReservationMileageBreakdownViewModel
    {
        public int AgreementReservationMileageBreakdownId { get; set; }
        public int AgreementId { get; set; }
        public int ReservationId { get; set; }

        public int StartKm { get; set; }
        public int EndKm { get; set; }
        public float Cost { get; set; }

        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }

        public int LocationId { get; set; }
        public string Location { get; set; }

        public int isDeleted { get; set; }
        public int ClientId { get; set; }
        public int RateId { get; set; }

        public int UpdatedBy { get; set; }
        public int CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
