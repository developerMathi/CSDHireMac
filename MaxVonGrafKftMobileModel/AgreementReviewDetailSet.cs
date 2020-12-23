using MaxVonGrafKftMobileModel.DynamicAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class AgreementReviewDetailSet
    {
        public AgreementReview AgreementDetail { get; set; }
        public List<MiscChargeSearchReview> MischargeList { get; set; }
        public List<LocationTaxModel> TaxList { get; set; }
        public AgreementInsurence AgreementInsuranceReview { get; set; }
        public AgreementBilling AgreementBillingReview { get; set; }
        public List<AgreementBilling> AgreementBillingList { get; set; }
        public List<PaymentViewModel> PaymentList { get; set; }
        public List<Rates> RateDetailsList { get; set; }
        public List<RateDetail> RateList { get; set; }
        public List<AgreementNote> AgreementNote { get; set; }
        public DepositViewModel DepositDetails { get; set; }
        public AgreementTotalViewModel AgreementTotal { get; set; }
        public string SignatureImageUrl { get; set; }
        public List<string> SignatureImageUrls { get; set; }
        public List<ClientPdfTemplates> ClientPdfTemplatesList { get; set; }
        public DepositTotals DepositTotals { get; set; }
        public List<EmailTrack> EmailTrackList { get; set; }
        public DateTime CurrentTime { get; set; }

        public NavotarDynamicAttribute navDynamicAttribute { get; set; }
    }

    public class AgreementTotalViewModel
    {
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public int? Status { get; set; }
        public string AgreementType { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? BaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? PromotionDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InactiveDayDeduction { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PerDayRate { get; set; }
        public int NoOfInactiveDays { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? FinalBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalMiscCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? KmCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraDurationCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? PreAdjustment { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? SubTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalTaxPercentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalMischargeWithOutTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AdditionalCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? FuelCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AgreementCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? FineCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? PostAdjustments { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AmountPaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? BalanceDue { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Deposit { get; set; }

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

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? WriteOffAmount { get; set; }

    }

    public class AgreementBasicInfoViewModel
    {
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public int? Status { get; set; }

        public DateTime CheckoutDate { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int CustomerId { get; set; }
        public int ClientId { get; set; }

        public int? OdometerOut { get; set; }
        public int? OdometerIn { get; set; }

        public string FuelLevelOut { get; set; }
        public string FuelLevelIn { get; set; }

        public int VehicleId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string VehicleNo { get; set; }

        public string VehicleType { get; set; }
        public int MakeId { get; set; }
        public string VehicleMakeName { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public string Trim { get; set; }
        public int? Year { get; set; }
        public int? OrigionalOdometer { get; set; }
        public int? CurrentOdometer { get; set; }
        public string FuelLevel { get; set; }
        public string LicenseNo { get; set; }

        public string CheckoutLocationName { get; set; }
        public string CheckinLocationName { get; set; }
        public string ReturnLocationName { get; set; }

        public int? CheckoutLocation { get; set; }
        public int? CheckinLocation { get; set; }
        public int? ReturnLocation { get; set; }

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }

        public string DamageUrl { get; set; }
        public int LogId { get; set; }
        public string SignatureImageUrlOut { get; set; }
        public string SignatureImageUrlIn { get; set; }

        // Secondary vehicle information
        public int VehicleId2 { get; set; }
        public int? VehicleTypeID2 { get; set; }
        public string VehicleNo2 { get; set; }
        public int MakeId2 { get; set; }
        public string VehicleMakeName2 { get; set; }
        public string ModelName2 { get; set; }
        public string LicenseNo2 { get; set; }
        public string DamageUrl2 { get; set; }
        public string VehicleType2 { get; set; }
    }
}