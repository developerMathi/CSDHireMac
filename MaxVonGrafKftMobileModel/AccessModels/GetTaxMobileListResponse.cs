using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    public class GetTaxMobileListResponse
    {
        public List<LocationTaxModel> LocationTaxResult { get; set; }
        public IEnumerable<LocationTaxMobileList> locTax { get; set; }
        public ApiMessage message { get; set; }

    }
}
