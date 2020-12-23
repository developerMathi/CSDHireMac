using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Agreement
    {
        public Agreement()
        { }

        #region [Basic agreement data]

        public int AgreementID { get; set; }
        public int AgreementPrimaryId { get; set; }

        public string AgreementNumber { get; set; }

        public int? Status { get; set; }

        public string AgreementType { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int ClientId { get; set; }

        public bool IsReservation { get; set; }

        public bool? IsDeleted { get; set; }

        public int? AgreementSequence { get; set; }


        #endregion

        #region [Dates]


        public DateTime CheckoutDate { get; set; }


        public DateTime CheckinDate { get; set; }


        public DateTime? ReturnDate { get; set; }


        public DateTime? DeliveryDate { get; set; }


        public DateTime? CreatedDate { get; set; }


        public DateTime? UpdatedDate { get; set; }


        public DateTime? Invoice_Date { get; set; }


        public DateTime? PrimaryCheckoutDate { get; set; }


        public DateTime? PrimaryCheckinDate { get; set; }

        #endregion

        public int CustomerId { get; set; }

        #region [location]

        public int? CheckoutLocation { get; set; }

        public int? CheckinLocation { get; set; }

        public int? ReturnLocation { get; set; }

        public int? Location { get; set; }
        public string Destination { get; set; }

        public string DeliveryDateStr { get; set; }

        #endregion

        #region [vehilce] 
        public int VehicleId { get; set; }

        public int OldVehicleId { get; set; }

        public int? OdometerOut { get; set; }

        public int? OdometerIn { get; set; }

        public string FuelLevelOut { get; set; }

        public string FuelLevelIn { get; set; }

        public int? ReturnVehicleStatus { get; set; }

        public int? VehicleTypeId { get; set; }

        #endregion

        #region [rates]  
        public int? RateId { get; set; }
        public string RateName { get; set; }
        public string PackageName { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? HourlyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? DailyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? WeeklyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? MonthlyRate { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraHourlyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraDailyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraDaily { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraDayCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraWeekllyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraMonthlyRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? SpecialRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraSpecialRate { get; set; }

        #endregion

        #region [QTY]

        public int? HourlyQty { get; set; }

        public int? DailyQty { get; set; }

        public int? WeeklyQty { get; set; }

        public int? MonthlyQty { get; set; }

        public int? ExtraHourlyQty { get; set; }

        public int? ExtraDailyQty { get; set; }

        public int? ExtraWeeklyQty { get; set; }

        public int? ExtraMonthlyQty { get; set; }

        public int? SpecialQty { get; set; }

        public int? ExtraSpecialQty { get; set; }

        #endregion

        #region [charges]

        public decimal BaseCharge { get; set; }



        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? KMCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraKMCharge { get; set; }
        public decimal ExtraKMUsed { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PreAdjustment { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AgreementCharges { get; set; }

        public decimal FineCharges { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraFuelCharge { get; set; }

        public decimal? UnTaxAdditionalCharge { get; set; }

        public decimal? UnTaxableAdditional { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AdditionalCharges { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PostAdjustments { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Discount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AdvancePaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AmountPaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AmountPaying { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? BalanceDue { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Balance { get; set; }

        //----
        public bool? DropFee { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? KMorMileageCharge { get; set; }

        public decimal? Deposit { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtraBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PromotionDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InactiveDayDeduction { get; set; }

        //-----

        #endregion

        #region [other]
        public int PromoCodeID { get; set; }

        public int? KMDaily { get; set; }

        public int? KMWeekly { get; set; }

        public int? KMMonthly { get; set; }

        public int? KMSpecial { get; set; }

        public int? ReferralId { get; set; }
        public string RentalReason { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string ReturnPaymentMethod { get; set; }
        public int? ContractType { get; set; }
        public int? InvoiceId { get; set; }
        public bool? LowestRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? MaxLDW { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? MaxTLDW { get; set; }
        public string PONo { get; set; }

        public string RONo { get; set; }

        public string VoucherNo { get; set; }

        public bool IsPreAuthorized { get; set; }

        public string ProjectedMileage { get; set; }
        #endregion

        #region[ tax ??? ]

        public bool? TaxGST { get; set; }

        public bool? TaxTFFC { get; set; }

        public bool? TaxVLATR { get; set; }

        public bool? TaxProvinceState { get; set; }

        public bool? ChargeLossDamageWaiver { get; set; }

        public bool? ChargePhysicalDamageWaiver { get; set; }

        public bool? ChargeChildSeat { get; set; }

        public bool? TaxAirport { get; set; }

        public bool? PersonalInsurance { get; set; }



        #endregion

        // USS Change
        public bool Prep { get; set; }
        public bool Wrap { get; set; }
        public int? VehicleTypeID2 { get; set; }
        public int? VehicleId2 { get; set; }
        public string PONo2 { get; set; }
        public string RONo2 { get; set; }
    }

}