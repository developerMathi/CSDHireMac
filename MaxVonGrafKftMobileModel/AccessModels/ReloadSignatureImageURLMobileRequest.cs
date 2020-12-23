using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class ReloadSignatureImageURLMobileRequest
    {
        public string SignatureImageUrl { get; set; }
        public int agreementId { get; set; }
        public bool IsCheckIn { get; set; }
        public bool isDamageView { get; set; }
    }
}
