using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public partial class InvoiceItem
    {

        public int? InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int? AgreementId { get; set; }
        public int AgreementChargeId { get; set; }
        public int Quantity { set; get; }
        public decimal? Rate { set; get; }
        public string Description { set; get; }
        public string ChargeType { set; get; }

        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }
        public string PaymentTo { get; set; }
        public string PaymentAddress { get; set; }
        public string InvoiceType { get; set; }
        public string Status { get; set; }
        public bool? IsPaid { get; set; }
        public int? LastUpdateBy { get; set; }
        public DateTime? LastUpdatesDate { get; set; }
        public decimal? Amount { get; set; }
        public string BillTo { get; set; }
        public DateTime? BillingDate { get; set; }
        public string BillingDateStr { get; set; }
        public bool? IsTaxInclude { get; set; }
        public bool GenerateAgreementCharge { get; set; }
        public DateTime CreatedDate { get; set; }

        public string AgreementNumber { get; set; } // Consolidated Invoice


        public decimal? InvoiceItemWOGST { set; get; } // InvoiceItem  need to change as InvoiceItemViewModel and use this variable here ***
        public decimal? InvoiceItemGST { set; get; } // InvoiceItem  need to change as InvoiceItemViewModel and use this variable here ***
        public decimal? InvoiceItemWithGST { set; get; } // InvoiceItem  need to change as InvoiceItemViewModel and use this variable here ***
        public int? ReservationId { get; set; }
        public string ReservationNumber { get; set; }
        public bool IsReservation { get; set; }
    }
}
