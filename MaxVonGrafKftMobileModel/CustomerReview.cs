using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class CustomerReview
    {
        public CustomerReview()
        {
        }
        public int UserID { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string SIN { get; set; }

        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateOfbirth { get; set; }
        public string hPhone { get; set; }
        public string bPhone { get; set; }
        public string cPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? LicenseCountryId { get; set; }
        public string LicenseCountryName { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string BEmail { get; set; }
        public bool? EmailFlg { get; set; }
        public bool? PhoneFlg { get; set; }
        public bool? MailFlg { get; set; }
        public DateTime? Lastupdated { get; set; }
        public int? LastUpdatedby { get; set; }
        public string Memo { get; set; }
        public short? ReferenceTypeId { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? LicenseExpiryDate { get; set; }
        public string Insurancecompany { get; set; } //actuvaly this is Insurancecompany id, continuation from 1.0 no way to fix this flow issue :( 
        public short? LicenseCountry { get; set; }
        public string PolicyNumber { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? InsuranceExpiryDate { get; set; }
        public string InsurancePhone { get; set; }
        public string InsuranceFax { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public int? CompanyStateId { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyRegNo { get; set; }
        public short? BillTo { get; set; }
        public bool Active { get; set; }
        public int? InsuranceCountry { get; set; }
        public int? InsuranceProvince { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? CreditCardExpiryDate { get; set; }
        public string CreditCardCVSNo { get; set; }
        public string Province { get; set; }
        public string StateName { get; set; }
        public string InsuranceState { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public int? BillingStateId { get; set; }
        public int? BillingCountyId { get; set; }
        public string BillingZipCord { get; set; }
        public string BillStateName { get; set; }
        public string BillingAddress1 { get; set; }
        public string CustomerType { get; set; }
        public string InsuranceClaim { get; set; }
        public string HSTNumber { get; set; }
        public string CustomerNumber { get; set; }
        public int OpenedReservation { get; set; }
        public int ConfirmedReservation { get; set; }
        public int NoShowReservation { get; set; }
        public int CancelledReservation { get; set; }
        public int OpenedAgreements { get; set; }
        public int ClosedAgreements { get; set; }
        //public int TrafficTicket { get; set; }
        public int TotalTrafficTickets { get; set; }
        public int PendingPayments { get; set; }
        public int PendingDeposit { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalRevenueNew { get; set; }

        public string CountryName { get; set; }
        public DateTime? LicenseIssueDate { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpairyDate { get; set; }
        public string LicenseIssueState { get; set; }
        public string DateOfBirthStr { get; set; }
        public string LicenseIssueDateStr { get; set; }

        public string LicenseExpiryDateStr { get; set; }
        public string PassportIssueDateStr { get; set; }
        public string PassportExpiryDateStr { get; set; }
        public string InsuranceExpiryDateStr { get; set; }
        public string CreditCardExpiryDateStr { get; set; }

        public string Password { get; set; }
        public int? LocationId { get; set; }

        public int Points { get; set; }
        public decimal CurrencyValue { get; set; }
        public string CreditCardBillingZipCode { get; set; }

        public string RateName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        public int CreditCardYear { get; set; }
        public bool IsviewCardNum { get; set; }

        public int CreditCardMonth { get; set; }

        public int CurrentResId { get; set; }
        public int CurrentAgrId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreateBy { get; set; }
        public string LastEditedBy { get; set; }
        public string LastEditedByName { get; set; }

        public int ClientId { get; set; }

        public string CustomerImage { get; set; }

        public List<CustomerImages> CustomerImages { get; set; }

        // NNV-1738 USS 
        public string ProductionName { get; set; }

        public bool NoBirthDate { get; set; }

        public string NameOnCard { get; set; }

        public int? DrivingExperience { get; set; }

        public string CustomerInvoiceSequence { get; set; }

        public bool IsBlackListed { get; set; }
        public int BlackListId { get; set; }
        public string BlackListDescription { get; set; }
        public DateTime? BlackListDate { get; set; }

        public string BlackListDatestr { get; set; }

        public int BlackListReason { get; set; }
        public List<CustomerAddresses> CustomerAddress { get; set; }
        public CustomerAddresses CustomerAddresses { get; set; }

        public string AccoutNameInBank { get; set; }
        public string AccountNumber { get; set; }
        public string BSB { get; set; }
        public string EmergencyContactNo { get; set; }
        public string CCCardNo { get; set; }


        /////// ///// ///// New bits added for Checkboxes  NNV-3666 /////// /////// ////////
        public bool IsSMSOpted { get; set; }
        public bool IsEmailOpted { get; set; }
        public int InquiryId { get; set; }
    }
}
