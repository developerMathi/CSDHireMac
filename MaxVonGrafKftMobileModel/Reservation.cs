using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Reservation
    {
        public Reservation()
        {
        }
        public int ReserveId { get; set; }

        public int ClientId { get; set; }

        public int? CustomerId { get; set; }

        public int? VehicleId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Notes { get; set; }

        public DateTime? Lastupdated { get; set; }

        public int? lastupdatedBy { get; set; }

        public DateTime? createdDate { get; set; }

        public string createdDateStr { get; set; }

        public int? RateId { get; set; }

        public decimal? InsuranceAmt { get; set; }

        public int? StartLocationId { get; set; }

        public int? EndLocationId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Company { get; set; }

        public Int16 Status { get; set; }

        public DateTime? CanceledDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal BasePrice { get; set; }

        public int? AgreementID { get; set; }

        public decimal? DailyRate { get; set; }

        public decimal? WeeklyRate { get; set; }

        public decimal? ExtraWeekllyRate { get; set; }

        public decimal? MonthlyRate { get; set; }

        public decimal? HourlyRate { get; set; }

        public int? KMDaily { get; set; }

        public int? KMWeekly { get; set; }

        public int? KMMonthly { get; set; }

        public int? ExtraDaily { get; set; }

        public decimal? KMCharge { get; set; }

        public string Note { get; set; }

        public string CustomerMail { get; set; }

        public int? VehicleTypeID { get; set; }

        public bool? LowestRate { get; set; }

        public string ReservationNumber { get; set; }

        public decimal? CancellationCharge { get; set; }

        public string CreditCardType { get; set; }

        public string CreditCardNo { get; set; }

        public DateTime? CreditCardExpiryDate { get; set; }

        public string CreditCardCVSNo { get; set; }

        public bool IsOnline { get; set; }

        public decimal? MaxLDW { get; set; }

        public decimal? MaxTLDW { get; set; }

        public decimal? SpecialRate { get; set; }

        public int? KMSpecial { get; set; }

        public int? VehicleStatus { get; set; }

        public string Mode { get; set; }

        public bool? IsDeleted { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AdvancedPayment { get; set; }

        public string SpecialNote { get; set; }

        public decimal AdditionalCharge { get; set; }

        public int PromotionID { get; set; }

        public string ReservationType { get; set; }

        // mileage breakdown for reservation
        public List<AgreementReservationMileageBreakdownViewModel> AgreementReservationMileageBreakdown { get; set; }

        // USS Change
        public bool Prep { get; set; }

        public bool Wrap { get; set; }

        public int? VehicleTypeID2 { get; set; }

        public int? VehicleId2 { get; set; }

        public string PONo { get; set; }

        public string RONo { get; set; }

        public string PONo2 { get; set; }

        public string RONo2 { get; set; }

        public DateTime? PrimaryCheckoutDate { get; set; }

        public DateTime? PrimaryCheckinDate { get; set; }

        public string ProjectedMileage { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public int? ReferralId { get; set; }

        public Referral ReservationReferral { get; set; }

        public string VoucherNo { get; set; }
    }
}
