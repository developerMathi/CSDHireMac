using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    /// <summary>
    /// GetChecklistMobileRequest
    /// </summary>
    [Serializable]
    public class GetChecklistMobileRequest
    {

        /// <summary>
        /// 
        /// </summary>
        public int AgreementId { get; set; }
        public int clientId { get; set; }

    }

}
