using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class PromotionMobileResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int PromotionID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int VehicleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PromotionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DiscountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double DiscountValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MinimumDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool OneTimeUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAutoApply { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal MinimumTotal { get; set; }
    }
}
