using MaxVonGrafKftMobileModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Driver
    {
        public Driver()
        {
        }

        public int DriverId { get; set; }

        public int CustomerId { get; set; }

        public int OriginalDriverId { get; set; }

        public int? AgrimentId { get; set; }

        public string DriverName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        //public string FirstName
        //{
        //    get
        //    {
        //        string[] driverNm = DriverName.Split(' ');
        //        return DriverName?.Split(' ')[0];
        //    }
        //    set { }
        //}

        //public string LastName
        //{
        //    get
        //    {
        //        return DriverName?.Split(' ')[1];
        //    }
        //    set { }
        //}

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public int CheckForDelete { get; set; }

        public DateTime? DateofBirth { get; set; }

        public string DateofBirthStr { get; set; }

        public DriverTypes DriverType { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdateBy { get; set; }

        public string DriverLicenseNumber { get; set; }

        public string DriverLicenseCategory { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]

        public DateTime? DriverLicenseExpiryDate { get; set; }

        public string Email { get; set; }

        public DateTime? LicenseIssueDate { get; set; }

        public string LicenseIssueState { get; set; }

        public string hPhone { get; set; }

        public string bPhone { get; set; }

        public string cPhone { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public int? StateId { get; set; }

        public string ZipCode { get; set; }

        public int? CountryId { get; set; }

        public bool IsDelete { get; set; }

        //for validate driver license
        public bool IsFromCustomer { get; set; }
        public string Phone { get; set; }
        public string SignatureImageUrl { get; set; }
        public string SignatureName { get; set; }
        public string SignatureImageUrlString { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? ReservationId { get; set; }

        public int? ReferenceType { get; set; } //For driver mapping status only
        public int? ReferenceId { get; set; } //For driver mapping status only
    }
}
