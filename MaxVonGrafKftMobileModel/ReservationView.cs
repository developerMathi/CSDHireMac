using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationView : Reservation
    {
        public int? OwningLocationId { get; set; }
        public string VehicleMakeName { get; set; }
        public string Trim { get; set; }
        public int? Year { get; set; }
        public string VehicleNo { get; set; }
        public string LicenseNo { get; set; }
        public string FuelType { get; set; }
        public string FuelLevel { get; set; }
        public string Transmission { get; set; }
        public int? CurrentOdometer { get; set; }
        public string Color { get; set; }
        public short? Doors { get; set; }
        public string Vin { get; set; }
        public short? StatusId { get; set; }
        public string StartLocationName { get; set; }
        public string EndLocationName { get; set; }
        public string VehicleType { get; set; }
        public string CreatedBy { get; set; }
        public int? ModelId { get; set; }
        public string ModelName { get; set; }
        public string PageTitle { get; set; }
        public string RateName { get; set; }
        public string LastUpdateByName { get; set; }
        public int ReservationStatus { get; set; }
        public string PackageName { get; set; }
        public int? RateLocation { get; set; }
        public string AgreementNumber { get; set; }
        public decimal? ExtraDailyRate { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? LDW { get; set; }
        public string MaxLDWStr { get; set; }
        public string MaxTLDWStr { get; set; }
        public decimal? TLDW { get; set; }
        public decimal? Deposit { get; set; }
        public string DepositPaymentType { get; set; }
        //public string ReservationType { get; set; }
        public int TempCustomerId { get; set; }
        public string ProductionName { get; set; }

        // datat string
        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }
        public string CreditCardExpiryDateStr { get; set; }
        public string PromotionIssue { get; set; }

        // total day reservation
        public int TotalDays { get; set; }

        // public int RentalDays { get; set; }


        //Drop Off charge
        public decimal PreAdjustment { get; set; }

        // extra calculations data
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal RateTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal EstimatedTotal { get; set; }

        public decimal AdvancePayment { get; set; }
        public bool IsProcessedPayment { get; set; }

        public string PaymentMethodForAdvancepaymnts { get; set; }

        public string PaymentMethodForCancellationchrgs { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Balance { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalMischarge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalTax { get; set; }
        public decimal TaxCharges { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalMischargeWithOutTax { get; set; }

        public decimal Total { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PromotionDiscount { get; set; }

        //***
        public string PromotionCode { get; set; }
        public bool IsNewCustomer { get; set; }
        public int LogId { get; set; }
        public string CreditCardBillingZipCode { get; set; }


        //list data
        public List<Rates> RateDetailsList { get; set; }
        public List<LocationTaxModel> TaxList2 { get; set; }
        public List<MiscChargeSearchReview> MiscList2 { get; set; }
        public List<MisChargeOption> MiscChargeOptions { get; set; }
        public List<MisChargeOption> MiscChargeOptionsTLDW { get; set; }
        public List<ReservationLocationTax> TaxList { get; set; }  //???
        public List<ReservationNote> NoteDetailsCollection { get; set; }
        public List<DeductibleMisChargeList> DeductibleMisChargeList { get; set; }
        public List<Driver> CustomerDriverList { get; set; }
        public List<ClientPdfTemplates> ClientPdfTemplatesList { get; set; }

        public DepositTotals DepositTotals { get; set; }

        public Deposit depositdetails { get; set; }

        public int CreditCardYear { get; set; }

        public int CreditCardMonth { get; set; }

        public ReservationNote NoteDetail { get; set; }

        public List<ReservationAttributeViewModel> ReservationAttributes { get; set; }

        public string ReservationMode { get; set; } // For Reservation History

        public bool IsviewCardNum { get; set; }

        //Installment
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FullDepositAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InstallmentAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PerInstallmentAmount { get; set; }

        public int InstallmentQty { get; set; }

        //Multiple Promotion Codes
        //------------------------------------------------------- 
        public int PromotionListId { get; set; }

        public List<PromotionItem> PromotionList { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalDiscount { get; set; }

        public bool isCompound { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubDiscount { get; set; }

        public int? BaseDailyKM { get; set; }
        public int? SubDailyKM { get; set; }

        public int? BaseWeeklyKM { get; set; }
        public int? SubWeeklyKM { get; set; }

        public int? BaseMonthlyKM { get; set; }
        public int? SubMonthlyKM { get; set; }
        public bool IsRateInfoEdited { get; set; }
        //-------------------------------------------------------

        public bool IsRedirectedReservation { get; set; }

        // mileage breakdown for reservation
        //public List<AgreementReservationMileageBreakdownViewModel> AgreementReservationMileageBreakdown { get; set; }

        //NNV-1743	NNV-1738 USS change
        public int ReservationPrimaryId { get; set; }
        public string VehicleMakeName2 { get; set; }
        public string ModelName2 { get; set; }
        public int? Year2 { get; set; }
        public string VehicleType2 { get; set; }
        public string LicenseNo2 { get; set; }
        public string VehicleNo2 { get; set; }

        //USS 
        public List<BlackoutDaysViewModel> BlackoutDaysList { get; set; }
        public bool isPrimary { get; set; }

        public bool NoBirthdate { get; set; }

        public int DaysInWeek { get; set; }

        // Booking Maintenance 
        public bool IsDelivery { get; set; }
        public bool IsRetrieval { get; set; }
        public bool IsDeliveryOld { get; set; }
        public bool IsRetrievalOld { get; set; }
        public bool IsCalculate { get; set; }
        public string PaymentTransactionReferenceNumber { get; set; }

        // Billing
        public string billingtype { get; set; }
        public bool billingtypeCustomer { get; set; }
        public bool billingtypeInsurance { get; set; }
        public bool billingtypeOther { get; set; }

        public ReservationBilling ReservationBilling { get; set; }
        public List<ReservationBilling> ReservationBillingList { get; set; }

    }

    public class TempKmAlloed
    {
        public int? DailyKMorMileageAllowed { get; set; }
        public int? WeeklyKMorMileageAllowed { get; set; }
        public int? MonthlyKMorMileageAllowed { get; set; }

        public decimal? KMorMileageCharge { get; set; }

        //For Multiple PromotionCodes
        public int? BaseDailyKM { get; set; }
        public int? SubDailyKM { get; set; }

        public int? BaseWeeklyKM { get; set; }
        public int? SubWeeklyKM { get; set; }

        public int? BaseMonthlyKM { get; set; }
        public int? SubMonthlyKM { get; set; }
    }
}
