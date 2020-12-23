using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum = MaxVonGrafKftMobileModel.Constants;

namespace MaxVonGrafKftMobileModel
{
    public class Deposit
    {

        public int DepositId { set; get; } //using for all ids --> AgreementDepositId  / AgreementRefundId / ReservationDepositId / ReservationRefundId    

        //public Enum.ReferenceType ReferenceType { set; get; }
        public int ReferenceType { set; get; }

        public int ReferenceId { set; get; }

        public int AgreementId { set; get; }

        public string DepositNumber { set; get; }

        public string AgreementNumber { set; get; }

        public string Number { get; set; }

        public string Type { get; set; }

        public Enum.DepositType TypeEnum { get; set; }

        public int ReservationId { set; get; }

        public string ReservationNumber { set; get; }

        public DateTime DepositDate { set; get; }

        public string DepositDateStr { get; set; }

        public DateTime? RefundDate { set; get; }

        public double DepositAmount { set; get; }

        public double? RefundAmount { set; get; }

        public double? HoldingAmount { set; get; } //??? 

        public string Remark { set; get; }

        public string Status { set; get; } // DepositType are same

        public string DepositPaymentType { get; set; }

        public string ReferenceNumber { get; set; }

        public int CreatedBy { set; get; }

        public DateTime CreatedDate { set; get; }

        public string CreatedDateStr { get; set; }

        public int LastUpdatedBy { set; get; }

        public DateTime LastUpdatesDate { set; get; }

        public string LastUpdatesDateStr { get; set; }

        public string CreatedByName { get; set; }

        public string LastUpdatedByName { get; set; }


        public decimal BalanceDeposit { set; get; }

        public decimal BalanceDepositOnhold { get; set; }

        public string DepositType { set; get; } //if Sending data to database =>change 'pre Authorized' to 'On-hold' / if getting data and showing, change otherway

        public int? PaymentLogId { get; set; }

        public bool EditAvailable { get; set; }
        public bool DeleteAvailable { get; set; }

    }

    public class DepositReceiptViewModel
    {
        public int DepositId { set; get; } // Deposit Number

        public string Status { set; get; } // DepositType

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double DepositAmount { set; get; } //Amount

        public string Remark { set; get; }

        public DateTime DepositDate { set; get; }

        public string DepositDateStr { get; set; }

        public string DepositPaymentType { get; set; }

        public string CustomerFisrtName { set; get; }

        public string CustomerLastName { set; get; }

        public string CustomerEmail { set; get; }

        public int AgreementId { set; get; }

        public string AgreementNumber { set; get; }
        public int CheckOutLocation { set; get; }

        public int ReservationId { set; get; }

        public string ReservationNumber { set; get; }
        public int StartLocationId { set; get; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalDepositAmount { set; get; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalRefundAmount { set; get; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal BalanceDepositAmount { set; get; }

        public ClientBasicInfo ClientBasicInfomation { set; get; }

        public string LogoImageUrl { set; get; }

        public string PassportNo { set; get; }
        public string LicenseNumber { set; get; }
    }

    public class DepositInfo
    {
        public int AgreementId { set; get; }
        public string AgreementNumber { set; get; }


        public int ReservationId { set; get; }
        public string ReservationNumber { set; get; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal FullDepositAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal InstallmentAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PerInstallmentAmount { get; set; }
        public int InstallmentQty { get; set; }

    }
}
