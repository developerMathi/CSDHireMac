using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationViewModel
    {
        public ReservationView Reservationview { get; set; }
        public List<MiscChargeSearchReview> MiscChargeList { get; set; }
        public List<LocationTaxModel> TaxList { get; set; }
        public List<Rates> RateDetailsList { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public ReservationlTotalViewModel ReservationTotal { get; set; }
        public List<ReservationAttributeViewModel> ReservationAttributeList { get; set; }
        public List<PaymentViewModel> PaymentList { get; set; }
        public List<ClientPdfTemplates> ClientPdfTemplatesList { get; set; }
        public List<EmailTrack> EmailTrackList { get; set; }
        public DepositTotals DepositTotals { get; set; }
        public InvoiceViewModel InvoiceList { get; set; }
        public ReservationBilling ReservtionBillingReview { get; set; }
        public List<ReservationBilling> ReservationBillingList { get; set; }

        // Mileage charges
        public List<MileageBrakedownDetails> MileageCharges { get; set; }

        // mileage breakdown for reservation
        public List<AgreementReservationMileageBreakdownViewModel> AgreementReservationMileageBreakdown { get; set; }

    }

    public class ReservationlTotalViewModel
    {
        public int ReservationId { get; set; }
        public string ReservationNumber { get; set; }
        public int? Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? BaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? PromotionDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? FinalBaseCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalMiscCharge { get; set; }


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
        public decimal? TotalAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AmountPaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? BalanceDue { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? CancellationCharge { get; set; }


        public string PromotionCode { get; set; }
        public int TotalDays { get; set; }

        //Drop Off charge
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PreAdjustment { get; set; }

    }

    public class ReservationBasicInfoModel
    {
        public int ReservationId { get; set; }
        public string ReservationNumber { get; set; }
        public short? Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }

        public string Note { get; set; }
        public string SpecialNote { get; set; }




    }
}
