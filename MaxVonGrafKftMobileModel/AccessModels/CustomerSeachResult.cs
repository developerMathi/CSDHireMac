using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class CustomerSeachResult
    {

        public int UserID { get; set; }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string CountryName { get; set; }
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
        public decimal TicketFlag { get; set; }
        public string UserName { get; set; }
        public Customer cust { get; set; }
        public List<CustomerSeachResult> custList { get; set; }
        public int CreatedBy { get; set; }
        public List<ColumnListViewModel> Columlist { get; set; }

        //NNV-1738
        public string ProductionName { get; set; }

        public int TotalRows { get; set; }
    }
}
