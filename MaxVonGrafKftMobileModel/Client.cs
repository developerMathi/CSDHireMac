using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Client
    {
        public Client()
        {
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string PostCode { get; set; }
        public int? CountryId { get; set; }
        public string ContactName { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public int? Lastupdatedby { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Theme { get; set; }
        public string MasterPage { get; set; }
        public string CustomizationFolder { get; set; }
        public string GSTRegNo { get; set; }
        public int? MaxNoOfUser { get; set; }
        public float? MaxFileSize { get; set; }
        public float? UsedFileSize { get; set; }
        public string TimeZone { get; set; }
        public string Culture { get; set; }
        public string CountryName { get; set; }
        public int BEmployeeId { get; set; }

    }


    public class ClientBasicInfo
    {
        public string ClientName { set; get; }

        public string ClientAddress { set; get; }

        public string ClientCity { set; get; }

        public string ClientState { set; get; }

        public string ClientCountry { set; get; }

        public string ClientZipCode { set; get; }

        public string ClienPhoneNo { set; get; }

        public string ClientEmail { set; get; }
    }

    public class ClientDetailViewModel
    {

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        //start NNV-2264
        //To see required output for below to attributes test clientId: 223
        public string PaymentType { get; set; } = "N/A";
        public string AccountNo { get; set; } = "N/A";
        //end NNV-2264
        public bool IsActive { get; set; }

        //email history
        public List<EmailClientDetails> EmailH { get; set; }

        public List<ClientProducts> ProductList { get; set; }

        public List<ClientNotes> NotesList { get; set; }

        public List<ClientTrackPayment> PaymentList { get; set; }

        public decimal? TotalAmount { get; set; }
        public int BEmployeeId { get; set; }
        public string BEmployeeName { get; set; } = "N/A";
        public string ClientCurrency { get; set; } = "N/A";

        //  public string BEmployeeName { get; set; } 
    }
}
