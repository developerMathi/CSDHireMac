using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationLocationTax
    {
        public int ReservationId { get; set; }
        public int TaxID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public bool IsOption { get; set; }
        public bool IsSelected { get; set; }
        public bool IsDeleted { get; set; }
    }
}
