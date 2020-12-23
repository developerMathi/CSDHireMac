using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class DepositViewModel
    {
        public Deposit Deposit { get; set; }
        public List<Deposit> List { get; set; }
        public List<string> agreementId { get; set; }
        public DepositTotals DepositTotals { get; set; }
    }

    public class DepositHistoryViewModel
    {
        public string AgreementNumber { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public decimal DepositAmount { set; get; }
        public decimal RefundAmount { set; get; }
        public decimal HoldingAmount { set; get; }
        public decimal Balance { get; set; }
    }
}