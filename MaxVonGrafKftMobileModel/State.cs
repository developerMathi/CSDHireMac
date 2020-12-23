using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class State
    {
        public State()
        {
        }
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CountryId { get; set; }

    }
}
