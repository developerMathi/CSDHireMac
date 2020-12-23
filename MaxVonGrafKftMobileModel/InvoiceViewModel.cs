using MaxVonGrafKftMobileModel.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class InvoiceViewModel
    {
        public Invoice Invoice { get; set; }

        public List<Invoice> List { get; set; }

        public InvoiceType InvoiceType { get; set; }

        public List<InvoiceItem> InvoiceItemList { set; get; }

        public List<InvoiceItem> DisplayInvoiceItemList { get; set; }

        public decimal? SubTotal { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TotalMiscChargeWithOutTax { get; set; }
        public decimal? TotalPromotionDiscount { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? AdditionalCharge { get; set; }
        public decimal? AgreementCharge { get; set; }  // toll charge
        public decimal? FineCharge { get; set; } // traffic ticket 

        public decimal? TotalAmont { get; set; }
        public decimal? AdjustmentPostTax { get; set; }
        public decimal? AmountPaid { get; set; }

        public string DisplayTotals { get; set; }
        public string AgreementNo { get; set; }
        public string ReservationNo { get; set; }


        public int AgreementId { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public string AgreementType { get; set; }

        public int CustomerId { get; set; }

        public List<ClientPdfTemplates> ClientPdfTemplatesList { get; set; }
        public bool IsWithoutTax { get; set; }
        public bool IsReservation { get; set; }

    }

    public class InvoiceHtmlViewModel
    {
        //Agreement information
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CheckinDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CheckoutDate { get; set; }
        public int? OdometerIn { get; set; }
        public int? OdometerOut { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleType { get; set; }
        public string VehicleLicense { get; set; }
        public string VehicleModel { get; set; }



        //Invoice information
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public bool IsTaxInclude { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? InvoiceDate { get; set; }
        public decimal? Amount { get; set; }
        public string InvoiceType { get; set; }

        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }

        public string PaymentTo { get; set; }
        public string PaymentAddress { get; set; }

        public string ClaimNo { get; set; }


        //Client information
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string Phone { get; set; }
        public string GstRegNo { get; set; }

        // customer information 
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerPostcode { get; set; }
        public string CustomerStateName { get; set; }
        public string CustomerStateCode { get; set; }
        public string CustomerCountryName { get; set; }
        public string CustomerCountryCode { get; set; }
        public string CustomerPhone { get; set; }

        //After Sub Total
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalTaxPercentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalMischargeWithOutTax { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalPromotionDiscount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AdditionalCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FuelCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AgreementCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FineCharge { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PostAdjustments { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal AmountPaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal BalanceDue { get; set; }

        public string Header { get; set; }

        public string Footer { get; set; }
        public List<MessageField> MessageFields { get; set; }
        public List<InvoiceItem> InvoiceItemList { set; get; }
        public List<InvoiceItem> DisplayInvoiceItemList { get; set; }
        public List<LocationTaxModel> TaxList { get; set; }

        public decimal? InvoiceItemsWithGSTTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? InvoiceItemsWOGSTTotal { get; set; }
        public decimal? InvoiceItemsGSTTotal { get; set; }
        public decimal? PromotionValTotal { get; set; }
    }

    public class CustomerInvoiceHtmlViewModel
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }

        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }

        public string PaymentTo { get; set; }
        public string PaymentAddress { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? InvoiceDate { get; set; }


        public decimal? AmountPaid { get; set; }
        public decimal? InvoiceItemsWithGSTTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? InvoiceItemsWOGSTTotal { get; set; }
        public decimal? InvoiceItemsGSTTotal { get; set; }
        public decimal? PromotionValTotal { get; set; }

        public List<InvoiceItem> InvoiceItemList { set; get; }
        public List<InvoiceItem> DisplayInvoiceItemList { get; set; }

        public string Header { get; set; }
        public string Footer { get; set; }

        //Client information
        #region [Client information
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string Phone { get; set; }
        public string GstRegNo { get; set; }

        #endregion

        // customer information 
        #region [customer information ]

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerPostcode { get; set; }
        public string CustomerStateName { get; set; }
        public string CustomerStateCode { get; set; }
        public string CustomerCountryName { get; set; }
        public string CustomerCountryCode { get; set; }
        public string CustomerPhone { get; set; }

        #endregion

    }
}
