using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class Promotion
    {
        public int PromotionID { get; set; }
        public int VehicleTypeId { get; set; }
        public string PromotionCode { get; set; }
        public int ClientId { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true,  DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }
        public string StartDateStr { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true,  DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndDate { get; set; }
        public string EndDateStr { get; set; }

        public string VehicleType { get; set; }
        public int DiscountTypeNo { get; set; }
        public string DiscountType { get; set; }
        public double DiscountValue { get; set; }
        public int MilesAllowedDiscountType { get; set; }
        public double MilesAllowedDiscountValue { get; set; }
        public int MinimumDay { get; set; }
        public bool OneTimeUse { get; set; }
        public bool Active { get; set; }
        public string ActiveText { get; set; }
        public int? LocationId { get; set; }
        public bool IsAutoApply { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal MinimumTotal { get; set; }
    }
}
