using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationInfo
    {
        public int? ReservationId { get; set; }
        public Rates RateInfo { get; set; }
        public List<LocationMiscCharge> MiscChargeList { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxCharges { get; set; }
        public decimal EstimatedTotal { get; set; }
        public decimal Balance { get; set; }
        public decimal AdvancePayment { get; set; }
        public int CustomerId { get; set; }

    }
}
