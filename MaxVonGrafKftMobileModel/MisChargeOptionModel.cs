using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class MisChargeOptionModel
    {
        public string MiscName { get; set; }
        public string VehicleTypeName { get; set; }
        public int MischargeOptionID { get; set; }
        public int? MisChargeID { get; set; }
        public decimal? OptionValue { get; set; }
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public int? ClientId { get; set; }
        public decimal? Option { get; set; }
        public int? VehicleType { get; set; }

        public string LocationName { get; set; }
    }
}
