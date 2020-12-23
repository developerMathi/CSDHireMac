using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class AgreementInsurence
    {
        public AgreementInsurence()
        {

        }
        [Key]
        public int InsurenceDetId { get; set; }
        public int? AgreementId { get; set; }
        public string InsurenceCompanyName { get; set; }
        public string PolicyNo { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string ClaimNo { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public int? InsurenceType { get; set; }
        public string StateName { get; set; }
        public string InsurancePersonName { get; set; }
        public string AccidnetVehicleInformation { get; set; }
        public string Dol { get; set; }
        public string AFNAF { get; set; }
        public int? InsuranceCompanyID { get; set; }
        public string ExtNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime? DateOut { get; set; }
        public DateTime? DateIn { get; set; }

        public string ExpiryDateStr { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PerDayAllowance { get; set; }

        public int NumberOfDayAllowed { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal MaximumAllowance { get; set; }

        /*Driver Insurance different in Claim Details*/
        [Key]
        public int InsurenceDetIdClaim { get; set; }
        public int? InsuranceCompanyIDClaim { get; set; }
        public string InsurenceCompanyNameClaim { get; set; }
        public string PolicyNoClaim { get; set; }
        public DateTime? ExpiryDateClaim { get; set; }
        public string ExpiryDateStrClaim { get; set; }

        /*Insurance Claim - Added by Abbas 03/07/2019 */
        public int InsuranceClaimId { get; set; }
        public int? ClientId { get; set; }
        public int StatusId { get; set; }
        public int? EmployeeId { get; set; }
        public int MaximumDaysForApproval { get; set; }
        public string AdjusterEmail { get; set; }


        public int InsuranceNoteId { get; set; }

        public bool IsSameInsuranceAsDriver { get; set; }

        public List<InsuranceClaimStatusModel> List { get; set; }

        public int? ReservationId { get; set; }

        public CreditCards CreditCards { get; set; }

    }

}
