using MaxVonGrafKftMobileModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ClientTrackPayment
    {
        public int ClientPaymentId { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public int PaymentYear { get; set; }
        public int PaymentMonth { get; set; }
        public decimal? Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Note { get; set; }
        public Month PaymentMonthDisplay { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int IsBtnSearchClick { get; set; }
        public List<ClientTrackPayment> paymnttrack { get; set; }
        public string BillingType { get; set; }

    }
}
