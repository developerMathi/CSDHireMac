using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class VehicleTypeModel
    {
        public VehicleTypeModel()
        {
        }
        [Key]
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public int ClientID { get; set; }
        public decimal? FullValue { get; set; }
        public bool? IsDeleted { get; set; }
        public int? UpdatedBy { get; set; }
        //public DateTimeOffset? UpdatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Sample { get; set; }
        public string Seats { get; set; }
        public string Doors { get; set; }
        public bool GetWithImage { get; set; }
        public bool IsReservation { get; set; }
        public int DeletedBy { get; set; }
        public int Baggages { get; set; }
        public decimal Deposit { get; set; }
        public int VehicleTypeImageID { get; set; }
        //public DateTimeOffset? StartDate { get; set; }
        public DateTime? StartDate { get; set; }
        //public DateTimeOffset? EndDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string path { get; set; }
        public string HtmlContent { get; set; }
        public bool IsShowOnline { get; set; }

    }

    public class VehicleTypeViewModel
    {
        public List<VehicleTypeModel> List { get; set; }
        public ApiMessage message { get; set; }
    }

    public class VehicleTypeWithRatesViewModel
    {
        public double Rate { get; set; }
        public double TotalRateCharge { get; set; }
        public short VehicleTypeID { get; set; }
        public string VehicleTypeName { get; set; }
        public bool IsAvailable { get; set; }
        public string Sample { get; set; }
        public string Seats { get; set; }
        public string Doors { get; set; }
        public int Baggages { get; set; }
        public double Deposit { get; set; }
        public string Transmission { get; set; }
        public string HtmlContent { get; set; }
        public string Options { get; set; }
        public string ImageUrl { get; set; }

    }

    public class VehicleTypeAndRateViewModel
    {
        public VehicleTypeModel VehicleTypeModel { get; set; }
        public AddRateFieldValueSet FieldValuSet { get; set; }
    }

    public class VehicleTypeAndRateViewModelList
    {
        public List<VehicleTypeAndRateViewModel> VehicleTypeAndRatesList { get; set; }
        public Action Action { get; set; }
    }

    public class VehicleTypeAndRateResultViewModel
    {
        public List<AddRateFieldValueSet> ListVehicleTypeAndRate { get; set; }
        public ApiMessage message { get; set; }
    }
}
