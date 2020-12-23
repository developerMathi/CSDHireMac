using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Admin
    {

        public Admin()
        {
        }


        public int ClientId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string PostCode { get; set; }
        public int BEmployeeId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        public string GSTRegNo { get; set; }
        public int? MaxNoOfUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ContactName { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string ClientCurrency { get; set; }
        public string ClientBillingCurrency { get; set; } = "";
        public string ClientCurrencySymbol { get; set; }
        public double? MaxFileSize { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? MaxNoOfVehicles { get; set; }
        public string PaymentType { get; set; }
        public string AccountNo { get; set; }
        public bool Active { get; set; }
        public bool IsActive { get; set; }
        public bool IsDemo { get; set; }
        public int LastUpdatedBy { get; set; }
        public Action Action { get; set; }
        public int StepId { get; set; }
        public string Web { get; set; }
        public int AccountManager { get; set; }
    }

    public class AdminViewModel
    {
        public Admin Admin { get; set; }
        public ApiMessage message { get; set; }
    }

    public class AccountManager
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
