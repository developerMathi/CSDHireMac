using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class MisChargeOptionList
    {
        public MisChargeOption MisChargeOption { get; set; }
        public List<MisChargeOptionModel> List { get; set; }
    }

    public class DeductibleMisChargeList
    {
        public MisCharge MisCharge { get; set; }
        public List<MisChargeOption> MisChargeOptionList { get; set; }
    }
}
