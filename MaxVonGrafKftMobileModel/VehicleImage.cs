using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class VehicleImage
    {
        public int vehicleId { get; set; }
        public string imageView { get; set; }
        public string base64Img { get; set; }
        public int clientId { get; set; }
        public int customerId { get; set; }
        public int agreementId { get; set; }
        public string agreementNo { get; set; }

    }
}
