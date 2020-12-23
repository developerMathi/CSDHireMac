using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class PromotionItem
    {
        public int PromotionID { get; set; }

        public string PromotionCountNumber { get; set; }

        public string PromotionCode { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PromotionDiscount { get; set; }

        public string PromotionIssue { get; set; }

        public int PromotionListId { get; set; }

        public int OrderNo { get; set; }
    }
}
