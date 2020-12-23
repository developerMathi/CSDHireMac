using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Customer
    {
        public Customer()
        {
        }

        [Key]
        public int UserID { get; set; }
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SIN { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
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

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy }", ApplyFormatInEditMode = true)]
        public DateTime? LicenseExpiryDate { get; set; }
        public string Insurancecompany { get; set; }
        public short? LicenseCountry { get; set; }
        public string PolicyNumber { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy }")]
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

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy }")]
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
        public DateTime? LicenseIssueDate { get; set; }
        public string LicenseIssueState { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? PassportExpairyDate { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public int? LocationId { get; set; }

        public string DateOfBirthStr { get; set; }
        public string LicenseIssueDateStr { get; set; }

        public string LicenseExpiryDateStr { get; set; }
        public string PassportIssueDateStr { get; set; }
        public string PassportExpiryDateStr { get; set; }
        public string InsuranceExpiryDateStr { get; set; }
        public string CreditCardExpiryDateStr { get; set; }
        public int PageCount { get; set; }

        public int CurrentResId { get; set; }
        public int CurrentAgrId { get; set; }

        [RegularExpression(@"^[1-4][0-9]*$")]
        [Range(15, 40, ErrorMessage = "Year must be valid ")]
        public int CreditCardYear { get; set; }

        [RegularExpression(@"^[1-9][0-2]*$")]
        [Range(1, 12, ErrorMessage = "Month must be valid ")]
        public int CreditCardMonth { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool IsviewCardNum { get; set; }

        //USS 
        public string Designation { get; set; }
        public bool NoBirthDate { get; set; }

        /////// ///// ///// New bits added for Checkboxes  NNV-3666 /////// /////// ////////
        public bool IsSMSOpted { get; set; }
        public bool IsEmailOpted { get; set; }
    }

    public partial class CustomerSerach
    {
        public int UserID { get; set; }
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SIN { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public DateTime? DateOfbirth { get; set; }
        public string hPhone { get; set; }
        public string bPhone { get; set; }
        public string cPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
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
        public DateTime? LicenseExpiryDate { get; set; }
        public string Insurancecompany { get; set; }
        public short? LicenseCountry { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public string InsurancePhone { get; set; }
        public string InsuranceFax { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public int? CompanyStateId { get; set; }
        public string CompanyZipCode { get; set; }
        public short? BillTo { get; set; }
        public bool Active { get; set; }
        public int? InsuranceCountry { get; set; }
        public int? InsuranceProvince { get; set; }
        public string CreditCardType { get; set; }
        public string CreditCardNo { get; set; }
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
        public DateTime? LicenseIssueDate { get; set; }
        public string LicenseIssueState { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpairyDate { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public int? LocationId { get; set; }

        public string DateOfBirthStr { get; set; }
        public string LicenseIssueDateStr { get; set; }

        public string LicenseExpiryDateStr { get; set; }
        public string PassportIssueDateStr { get; set; }
        public string PassportExpiryDateStr { get; set; }
        public string InsuranceExpiryDateStr { get; set; }
        public string CreditCardExpiryDateStr { get; set; }
        public int PageCount { get; set; }

        public string UserName { get; set; }
        public bool IsviewCardNum { get; set; }


    }
}
