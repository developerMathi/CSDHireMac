using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Payment
    {
        public Payment()
        {
        }

        [Key]
        public int PaymentId { get; set; }
        public string PaymentNumber { get; set; }
        public int ReferenceType { get; set; }
        public int ReferenceId { get; set; }
        public int AgreementId { get; set; }
        public int PrimaryAgreementId { get; set; }
        public int ReservationId { get; set; }

        public bool EditAvailable { get; set; }
        public bool DeleteAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public DateTime? PaymentDate { get; set; }

        [Required]
        public string PaymentMethod { get; set; }
        public int? InvoiceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatesDate { get; set; }
        public string Mode { get; set; }

        [Required]
        public string PaymentType { get; set; }
        public string ReferenceNo { get; set; }
        public string PaymentBy { get; set; }
        public int? PaymentLogId { get; set; }

        public string TranscationId { get; set; }
        public string CreatedByName { get; set; }
        public string LastUpdatedByName { get; set; }
    }

    public class PaymentViewModel : Payment
    {
        public string AgreementNo { get; set; }
        public string PaymentDateStr { get; set; }
        public int PaymentMethodId { get; set; }
        public string PONumber { get; set; }
        public decimal? TotalPayable { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? AvailableDriverDeposit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsPaymentSchedule { get; set; }
        public int SubAgreementId { get; set; }
        public List<AgreementSearchResult> SubList { get; set; }
        public IList<int> InvoiceIds { get; set; }
        public IList<int> CreditNotes { get; set; }
        public IList<int> NegativeList { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AmountPaid { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? TotalBalanceDue { get; set; }
    }

    [Serializable]
    public class PaymentType
    {
        public int PaymentTypeId { set; get; }
        public string PaymentTypeName { set; get; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPossibleDelete { get; set; }
        public bool IsAddedByCustomer { get; set; }

    }


    public class Data2
    {
        public string referencenumber { get; set; }

    }

    public class Data1
    {
        public string message { get; set; }

        public string Status { get; set; }

        public Data2 Data { get; set; }

    }

    public class PaymentResult
    {
        public object ContentEncoding { get; set; }
        public object ContentType { get; set; }
        public Data1 Data { get; set; }
        public int JsonRequestBehavior { get; set; }
        public object MaxJsonLength { get; set; }
        public object RecursionLimit { get; set; }
    }
}
