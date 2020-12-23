using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    class VehicleStatus
    {
        public VehicleStatus()
        { }
        public int VehicleStatusId { get; set; }
        public int Status { get; set; }
        public int Description { get; set; }
    }
}
