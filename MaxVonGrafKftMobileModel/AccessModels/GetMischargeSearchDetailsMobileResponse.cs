using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetMischargeSearchDetailsMobileResponse
    {
        public List<MiscChargeSearchReview> MischargeResultList { get; set; }

        public IEnumerable<MischargeResultMobile> MiscResult { get; set; }

        public ApiMessage message { get; set; }

    }
}
