using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class LocationMiscCharge
    {
        public LocationMiscCharge() { }
        public int LocationMiscChargeID { get; set; }
        public int MiscChargeID { get; set; }
        public decimal Value { get; set; }
        public int ClientId { get; set; }
        public int LocationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public bool? CalculatedBy { get; set; }
        public string CalculationType { get; set; }
        public int? VehicleTypeId { get; set; }
        public bool? IsOptional { get; set; } //  true = Mandatory , false = Optional
        public int Option { get; set; }
        public decimal TotalValue { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public bool IsSelected { get; set; }

    }
}
