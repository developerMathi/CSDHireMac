using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class VehicleTypeResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int VehicleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VehicleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ClientID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? FullValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Seats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Doors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReservation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Baggages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Deposit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string HtmlContent { get; set; }


        public string Price { get; set; }

        public bool selected { get; set; }
    }
}
