using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class VehicleMake
    {
        public VehicleMake()
        {
        }

        [Key]
        public int VehicleMakeID { get; set; }
        public string VehicleMakeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public int ClientID { get; set; }
        public bool? IsDeleted { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public int? OldVehicleMakeID { get; set; }


    }

    public class VehicleMainMakeNames
    {
        public int VehicleMakeID { get; set; }
        public string VehicleMakeName { get; set; }
    }
}
