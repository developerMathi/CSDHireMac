using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ClientProducts
    {
        public int ListId { get; set; }
        public int ClientProductId { get; set; }
        public int ProductId { get; set; }
        public string BillingReference { get; set; }
        public decimal? Price { get; set; }
        public int ClientId { get; set; }
        public string ProductName { get; set; }
        public string BillingType { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
