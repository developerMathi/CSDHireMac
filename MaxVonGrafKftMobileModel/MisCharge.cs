using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class MisCharge
    {
        public MisCharge()
        {
        }

        [Key]
        public int MiscChargeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CalculationType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ClientID { get; set; }
        public int? MiscChargeCode { get; set; }
        public bool? ReservationModule { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Value { get; set; }
        public bool IsCommission { get; set; }
        public bool TaxNotAvailable { get; set; }
        public bool AddToRevenue { get; set; }
        public string CreatedByName { get; set; }
        public string LastUpdatedByName { get; set; }
        public bool IsInvoiceAutomated { get; set; }
        public int TotalAutomated { get; set; }
        public bool IsQuantity { get; set; }
        public bool IsDeductible { get; set; }

    }

    public class MisChargeAndLocationMisccharge
    {
        public MisCharge MisCharge { get; set; }
        public LocationMiscCharge LocationMiscCharge { get; set; }
    }

    public class MisChargeAndLocationMiscchargeList
    {
        public List<MisChargeAndLocationMisccharge> MisChargeAndLocationMiscchargesList { get; set; }
        public Action Action { get; set; }
    }

    public class MisChargeAndLocationMiscchargeResult
    {
        public List<MiscChargeSearchReview> LocationmiscChargesList { get; set; }
        public List<MisCharge> MiscChargesList { get; set; }

        public ApiMessage message { get; set; }
    }
}
