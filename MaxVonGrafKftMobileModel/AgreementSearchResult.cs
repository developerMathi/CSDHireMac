using MaxVonGrafKftMobileModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class AgreementSearchResult
    {
        public DateTime? ReturnDateTemp { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int AgreementId { get; set; }
        public bool IsPrimary { get; set; }
        public int? ReserveId { get; set; }
        public int VehicleId { get; set; }
        public int MakeId { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleMakeName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string Year { get; set; }
        public string Trim { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedByName { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string HPhone { get; set; }
        public string CPhone { get; set; }
        public AgreementStatusConst agreementStatusId { get; set; }
        public string AgreementNumber { get; set; }
        public double TotalAmount { get; set; }
        public string Note { get; set; }
        public string Color { get; set; }
        public int? Status { get; set; }
        public int? OdometerIn { get; set; }
        public int? OdometerOut { get; set; }
        public string ProductionName { get; set; }
        public string DriverName { get; set; }
        public string ReferralName { get; set; }
        public string PolicyNo { get; set; }
        public int CheckoutLocation { get; set; }
        public int CheckinLocation { get; set; }
        public string CheckoutLocationName { get; set; }
        public string CheckinLocationName { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string ClaimNo { get; set; }
        public bool IsSelected { get; set; }
        public int InsuranceCompanyID { get; set; }
        public int VehicleId2 { get; set; }
        public string VehicleNo2 { get; set; }
        public int VehicleTypeID2 { get; set; }
        public string VehicleType2 { get; set; }
        public int TotalRows { get; set; }
        public List<ColumnListViewModel> Columlist { get; set; }

    }

    // Added ClaimSearchResult for Insurance Claim by Abbas on 2019.07.10
    public class ClaimSearchResult
    {
        public int CustomerId { get; set; }
        public int InsuranceClaimId { get; set; }
        public int UserId { get; set; }
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public string ClaimNo { get; set; }
        public string ClaimName { get; set; }
        public string Phone { get; set; }
        public string HPhone { get; set; }
        public string CPhone { get; set; }
        public string Status { get; set; }
        public int InsuranceCompanyId { get; set; }
        public string InsuranceName { get; set; }
        public string PolicyNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedByName { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CurrentDate { get; set; }
        public int PageCount { get; set; }
        public int TotalRows { get; set; }

        public string AdjusterName { get; set; }
        public int ClaimStatus { get; set; }
        public string Note { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string FollowUpDateString { get; set; }
    }
}
