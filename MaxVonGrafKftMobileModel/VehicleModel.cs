using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class VehicleModel
    {
        public VehicleModel()
        {
        }
        [Key]
        public int ModelId { get; set; }
        public int VehicleMakeID { get; set; }
        public string ModelName { get; set; }
        public int ClientId { get; set; }
        public bool? Flag { get; set; }
        public bool? IsDeleted { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int MakeId { get; set; }
        public string VehicleMakeName { get; set; }

    }
    public class VehicleMainModelNames
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int VehicleMakeID { get; set; }
    }
}
