using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class AddDamageSignMobileRequest
    {
        public int agreementId { get; set; }
        public string base64Img { get; set; }
        public bool ischeckin { get; set; }

    }
}
