using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Invoice
    {
        public Invoice()
        {
        }

        [Key]
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string NoOfAgreements { get; set; }
        public string CreatedByName { get; set; }
        public string InvoiceDateStr { get; set; }
        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string BillPhone { get; set; }
        public string BillTo { get; set; }

        public string PaymentTo { get; set; }
        public string PaymentAddress { get; set; }
        public int InvoiceTypeNum { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceDescription { get; set; }
        public string Status { get; set; }
        public bool? IsPaid { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatesDate { get; set; }
        public decimal? Amount { get; set; }
        public bool IsTaxInclude { get; set; }
        public string AgreementNo { get; set; }
        public decimal? AmountPaid { get; set; }
        public int CustomerId { get; set; }

        public int IsAutomated { get; set; }

        public bool EditAvailable { get; set; }
        public bool DeleteAvailable { get; set; }

        public string Description { get; set; }

        public string LastUpdatedByName { get; set; }

        public decimal? GrandTotal { get; set; }

        public bool IsWithTax { get; set; }
        public int ReservationId { get; set; }
        public string ReservationNumber { get; set; }

        public bool IsReservation { get; set; }
    }
}
