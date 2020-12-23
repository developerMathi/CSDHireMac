using MaxVonGrafKftMobileModel.Constants;
using MaxVonGrafKftMobileModel.DynamicAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class AgreementReview : Agreement
    {
        //customer extra details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string hPhone { get; set; }
        public string bPhone { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerType { get; set; }

        public string Company { get; set; }
        public string CustomerLicenseNumber { get; set; }

        public string CreditCardExpiryDateStr { get; set; }
        public string LicenseExpiryDateStr { get; set; }
        public bool IsRemoveValidate { get; set; }
        public string CreditCardCVSNo { get; set; }
        public string cPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? CountryId { get; set; }
        public int? ReservationId { get; set; }
        public bool isReservationPaymentNull { get; set; } = true;
        public bool isReservationDepositNull { get; set; } = true;
        public int? StateId { get; set; }
        public string CompanyName { get; set; }
        public string SignatureImageUrl { get; set; }
        public List<string> SignatureImageUrls { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
        public string CreatedByName { get; set; }
        public string SpecialNote { get; set; }
        public string Note { get; set; }
        public string LastUpdatedBy { get; set; }
        public string CheckedInByName { get; set; }
        public int AgreementStatusID { get; set; }
        // NNV-3278 - Secondary Agreement USS -3278
        public string ProductionName { get; set; }


        public int Points { get; set; }
        public decimal CurrencyValue { get; set; }

        public string LicenseIssueState { get; set; }
        public string LicenseIssueDate { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //public DateTimeOffset? CreditCardExpiryDate { get; set; }
        public DateTime? CreditCardExpiryDate { get; set; }
        public DateTime? LicenseExpiryDate { get; set; }
        public string BillingAddress1 { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public int TotalDays { get; set; }
        public int DaysInWeek { get; set; }
        public int EquipmentIdCount { get; set; }
        public int NoOfVehicles { get; set; }
        public decimal TotalKmUsed { get; set; }
        public int? AllVehicleTotalKmUsed { get; set; }
        public bool IsNewCustomer { get; set; }

        public string billingtype { get; set; }
        public bool billingtypeCustomer { get; set; }
        public bool billingtypeInsurance { get; set; }
        public bool billingtypeOther { get; set; }

        public string retrivalcode { get; set; }

        public string SignatureName { get; set; }

        public decimal TotalTax { get; set; }
        public string PromotionIssue { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalMischarge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalMischargeWithOutTax { get; set; }
        public string MaxLDWStr { get; set; }
        public string MaxTLDWStr { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal BaseTotal { get; set; }
        public decimal DailyKMorMileageAllowed { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public string PromotionCode { get; set; }
        public decimal RateTotal { get; set; }
        public bool IsApply { get; set; }
        public bool IsCalculate { get; set; }
        public double AlreadyPaidAmount { get; set; }
        public bool IsCalculateDeposit { get; set; }

        //vehicle extra details

        //model
        public string ModelName { get; set; }
        public int ModelId { get; set; }
        public string ModelName2 { get; set; }
        public int ModelId2 { get; set; }

        //make
        public int MakeId { get; set; }
        public string VehicleMakeName { get; set; }
        public int MakeId2 { get; set; }
        public string VehicleMakeName2 { get; set; }

        // vehicle type
        public string VehicleType { get; set; }
        public string VehicleType2 { get; set; }

        //vehicle
        public string Trim { get; set; }
        public int? Year { get; set; }
        public int? Year2 { get; set; }
        public int? OrigionalOdometer { get; set; }
        public int? CurrentOdometer { get; set; }
        public string FuelLevel { get; set; }
        public string LicenseNo { get; set; }
        public string LicenseNo2 { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleNo2 { get; set; }

        public string VehicleImageName { get; set; }
        public int TakeSize { get; set; }
        public Int16 StatusId { get; set; }

        //rate location details
        public string RateLocationName { get; set; }
        public string RateLocation { get; set; }

        //chk out location details

        // public int? CheckoutLocation { get; set; }
        public string CheckoutLocationName { get; set; }

        // chk in location details
        public string CheckinLocationName { get; set; }

        // return location details
        public string ReturnLocationName { get; set; }


        // public string AgreementNumber { get; set; }
        public int ExtraDays { get; set; }
        public string CheckoutDateString { get; set; }
        public string CheckinDateString { get; set; }
        public string ReturnDateStr { get; set; }
        public string InvoiceDateStr { get; set; }
        public DateTime? InvoiceDate { get; set; }

        //Deposit
        public string ReferenceNumber { get; set; }
        public string DepositPaymentType { get; set; }
        public string DepositType { set; get; }
        public decimal DepositAmount { set; get; }
        public decimal OnHoldAmount { set; get; }
        public decimal RefundAmount { set; get; }
        public decimal ReleaseAmount { set; get; }

        public decimal BalanceDepositOnhold { get; set; }

        public bool IsFromCustomer { get; set; }
        public Deposit Deposits { get; set; }

        //PaymentSchedule 
        public int ScheduleFrequencyType { get; set; }
        public int? PamentScheduleValue { get; set; }
        public int NoOfTerms { get; set; }
        public decimal? RentalFee { get; set; }

        public bool IsAutoAuthorize { get; set; }
        public int IsReleaseAuthorize { get; set; }
        public CustomerReview AgreementCustomer { get; set; }
        public AgreementInsurence AgreementInsuranceReview { get; set; } // ???
        public AgreementInsurence AgreementInsurance { get; set; }
        public Referral Referral { get; set; } // ???
        public Referral AgreementReferral { get; set; }
        public AgreementBilling AgreementBilling { get; set; }
        public AgreementBilling AgreementBillingReview { get; set; } //???
        public AgreementEquipment AgreementEquipment { get; set; }
        public AgreementNote NoteDetail { get; set; }
        public Customer Customer { get; set; } // To fill the customer details in the continue to agreement page
        public GetVehicleIdByCodeResponse vehicleResponse { get; set; }
        public DepositTotals DepositTotals { get; set; }

        public List<PaymentViewModel> PaymentList { get; set; }
        public List<Driver> CustomerDriverList { get; set; }
        public List<Driver> Driverlist { get; set; }  //???
        public List<AgreementEquipment> EquipmentList { get; set; }
        public List<AgreementNote> NoteDetailsCollection { get; set; }
        public List<AgreementBilling> AgreementBillingList { get; set; }
        public ReservationBilling ReservtionBilling { get; set; }
        public List<ReservationBilling> ReservationBillingList { get; set; }
        public List<Deposit> depositList { get; set; }
        public List<DepositHistoryViewModel> DepositHistoryViewModel { get; set; }
        public List<string> agreeNo { get; set; }
        public List<AgreementAttributeViewModel> AgreementAttributes { get; set; }

        public List<Rates> RateDetailsList { get; set; }
        public List<LocationTaxModel> TaxList { get; set; }
        public List<MiscChargeSearchReview> MiscList { get; set; }
        public List<MisChargeOption> MiscChargeOptions { get; set; }
        public List<MisChargeOption> MiscChargeOptionsTLDW { get; set; }
        public List<DeductibleMisChargeList> DeductibleMisChargeList { get; set; }
        public bool IsSecurity { get; set; }
        public double OtherCharges { get; set; }
        public AgreementStatusConst AgreementStatus { get; set; }

        public bool IsLoyalty { get; set; }
        public string CreditCardBillingZipCode { get; set; }

        public int CreditCardYear { get; set; }
        public int CreditCardMonth { get; set; }
        // Gps

        //********* Insurance Details *********//

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustomerBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InsuranceBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustomerTotalTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InsuranceTotalTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustomerTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InsuranceTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustomerPaidAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InsurancePaidAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustomerBalanceAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InsuranceBalanceAmount { get; set; }
        public bool IsviewCardNum { get; set; }

        //INstallment
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FullDepositAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InstallmentAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PerInstallmentAmount { get; set; }

        public int InstallmentQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ReimbursementAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? FuelCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? KMorMileageCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Deposit { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtraBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PromotionDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WriteOffAmount { get; set; }

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

        //Uss
        public bool isConAgreement { get; set; }

        // Mileage charges
        public List<MileageBrakedownDetails> MileageCharges { get; set; }

        // mileage breakdown for reservation
        public List<AgreementReservationMileageBreakdownViewModel> AgreementReservationMileageBreakdown { get; set; }

        public int ReservationPrimaryId { get; set; }

        //USS BlackoutDays
        public List<BlackoutDaysViewModel> BlackoutDaysList { get; set; }
        public bool isPrimary { get; set; }

        //Risk Note
        public bool IsRiskNote { get; set; } = false;
        public bool IsRiskAgeerment { get; set; }
        public string RiskNote { get; set; }
        public DateTime RiskDate { get; set; }
        public string UpdatedByName { get; set; }

        public bool NoBirthdate { get; set; }
        public ContractReason ContractReason { get; set; }
        public int ContractExtendedPerioid { get; set; }
        public string ContractExtendReasonDesc { get; set; }
        public DateTime OldChcekInDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangeDateString { get; set; }
        public string OldCheckInDateString { get; set; }
        public bool IsExtensionPeriod { get; set; }
        public DateTime CurrentDate { get; set; }

        public List<ScheduledVehicleMaintenance> ServiceModel { get; set; }

        // Booking Maintenance 
        public bool IsDelivery { get; set; }
        public bool IsRetrieval { get; set; }
        public bool IsDeliveryOld { get; set; }
        public bool IsRetrievalOld { get; set; }

        public int IsEditRate { get; set; }
        public bool? IsEarlyCheckIn { get; set; }

        public NavotarDynamicAttribute navDynamicAttribute { get; set; }

    }


    public class AgreementMiscChargeReview
    {
        public int MiscChargeId { get; set; }
        public int? MiscChargeCode { get; set; }
        public int Unit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CalculationType { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal VALUE { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalValue { get; set; }


    }


    public class AgreementInsuranceReview
    {
        public int InsurenceDetId { get; set; }
        public int? InsuranceCompanyID { get; set; }
        // public int? AgreementId { get; set; }
        public string InsurenceCompanyName { get; set; }
        public string PolicyNo { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ExpiryDate { get; set; }
        public string ExpiryDateStr { get; set; }
        // public int? UpdatedBy { get; set; }
        // public string UpdatedDate { get; set; }
        public string ClaimNo { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public int? InsurenceType { get; set; }
        public string StateName { get; set; }
        public string InsurancePersonName { get; set; }
        //public string IsDeleted { get; set; }
        public string Dol { get; set; }
        public string AFNAF { get; set; }



    }

    public class AgreementContractExtend
    {
        public int ContractExtendedPerioid { get; set; }
        public string ContractExtendReasonDesc { get; set; }
        public DateTime NewCheckInDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangeDateString { get; set; }
        public bool IsExtensionPeriod { get; set; }
    }


}
