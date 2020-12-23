using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Referral
    {
        public Referral()
        {
        }

        public int ReferralId { get; set; }
        public int ClientId { get; set; }
        public string ReferralName { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string ZipCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }

        public string CountryName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }

        //Voucher no for USS
        public string VoucherNo { get; set; }
    }
}
