using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class AddAgreementSignMobileRequest
    {
        public int agreementId { get; set; }
        public string base64Img { get; set; }
        public string type { get; set; }

    }
}
