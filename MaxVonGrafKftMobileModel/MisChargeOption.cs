using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class MisChargeOption
    {
        [Key]
        public int MischargeOptionID { get; set; }
        public int? MisChargeID { get; set; }
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public int? ClientId { get; set; }
        public decimal? Option { get; set; }
        public int? VehicleType { get; set; }
        public int? Unit { get; set; }
        public int? LocationID { get; set; }

    }
}
