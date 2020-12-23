using MaxVonGrafKftMobileModel.DynamicAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{

    public class RegistrationDBModel
    {

        public RegistrationDBModel()
        {
            Reservations = new List<CustomerReservationModel>();
            Agreements = new List<CustomerAgreementModel>();
        }
        public decimal TotalPaid { get; set; }
        public decimal OverDues { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal BalanceDeposit { get; set; }
        public string Status { get; set; }
        public string NoReservations { get; set; }
        public List<CustomerReservationModel> Reservations { get; set; }
        public List<CustomerAgreementModel> Agreements { get; set; }
    }


    public class CustomerReservationModel
    {
        public CustomerReservationModel()
        {
        }

        public int ReservationId { get; set; }
        public string ReservationNumber { get; set; }
        public string VehicleModel { get; set; }
        public string CusLicenceNumber { get; set; }
        public string VehicleLicenceNo { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public int sid { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public string ClientName { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalRefund { get; set; }
        public decimal BalanceDeposit { get; set; }
        public int VehilceId { get; set; }
        public string imgeUrl { get; set; }
        public string ModelCode { get; set; }
        public string StartLocation { get; set; }
        public string Endlocation { get; set; }
        public bool IsPassed { get; set; }
        public bool isTwoHour { get; set; }
        public string CustomerName { get; set; }
        public bool IsAgreement { get; set; }
        public int ReferenceId { get; set; }
        #region Rate Related
        public decimal TotalAmount { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal TotalWoTax { get; set; }
        public int HourlyQty { get; set; }
        public int DailyQty { get; set; }
        public int WeeklyQty { get; set; }
        public int MonthlyQty { get; set; }
        #endregion
        public int ChckotLocationId { get; set; }
        public int ChckInLocationId { get; set; }
        public string CheckoutLocation { get; set; }
        public string CheckinLocation { get; set; }
        public List<Document> DocListOut { get; set; }
        public List<Document> DocListIn { get; set; }
        public NavotarDynamicAttribute navDynamicAttribute { get; set; }
        public List<NavotarDynamicAttribute> navAttributeList { get; set; }
        public string StartDatestr { get; set; }
        public string EndDatestr { get; set; }

    }

    public class CustomerAgreementModel
    {

        public CustomerAgreementModel()
        {

        }

        public int AgreementId { get; set; }
        public int VehicleId { get; set; }
        public string VehicleModel { get; set; }
        public string AgreementNumber { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime CheckoutDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime CheckinDate { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public string ClientName { get; set; }
        public string LicenseNumber { get; set; }
        public int NoOfInvoices { get; set; }
        public int NoOfReceipts { get; set; }
        public decimal AgreementTotal { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal BalanceDue { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalRefund { get; set; }
        public decimal BalanceDeposit { get; set; }
        public int ChckotLocationId { get; set; }
        public int ChckInLocationId { get; set; }
        public string CheckoutLocation { get; set; }
        public string CheckinLocation { get; set; }
        public List<Document> DocListOut { get; set; }
        public List<Document> DocListIn { get; set; }
        public NavotarDynamicAttribute navDynamicAttribute { get; set; }
        public List<NavotarDynamicAttribute> navAttributeList { get; set; }
        public string CheckoutDatestr { get; set; }
        public string CheckinDatestr { get; set; }

    }


    public class CustomerInvoiceModel
    {
        public List<CustomerInvoice> Invoices { get; set; }
        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalRefund { get; set; }
        public decimal BalanceDeposit { get; set; }
        public decimal TotalAmount { get; set; }
        public CustomerInvoiceModel()
        {
            Invoices = new List<CustomerInvoice>();
        }
    }
    public class CustomerInvoice
    {

        public CustomerInvoice()
        {

        }

        public int InvoiceNo { get; set; }
        public string InvoiceNumber { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceDatestr { get; set; }
    }


    public class CustomerReceiptModel
    {

        public int AgreementId { get; set; }
        public string AgreementNumber { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalRefund { get; set; }
        public decimal BalanceDeposit { get; set; }
        public CustomerReceiptModel()
        {
            payments = new List<CustomerPaymentModel>();
            deposits = new List<CustomerDepositModel>();
        }
        public List<CustomerPaymentModel> payments { get; set; }
        public List<CustomerDepositModel> deposits { get; set; }

    }

    public class CustomerPaymentModel
    {

        public CustomerPaymentModel()
        {

        }
        public int PaymentID { get; set; }
        public string PaymentNumber { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }
        public string PaymentDatestr { get; set; }


    }

    public class CustomerDepositModel
    {

        public CustomerDepositModel()
        {

        }
        public int DepositID { get; set; }
        public string DepositNumber { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }

        public decimal Amount { get; set; }
        public string InvoiceDatestr { get; set; }


    }
}
