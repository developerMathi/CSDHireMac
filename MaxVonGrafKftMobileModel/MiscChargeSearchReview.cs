using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class MiscChargeSearchReview
    {
        public int LocationMischargeId { get; set; }
        public int VehicleTypeId { get; set; }
        public int MiscChargeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CalculationType { get; set; }
        public decimal Value { get; set; }
        public decimal TotalValue { get; set; }
        public int MisChargeCode { get; set; }
        public int MiscChargeCode { get; set; }
        public bool IsOptional { get; set; }
        public int Unit { get; set; }
        public string PrintValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OldStartDateString { get; set; }
        public string OldEndDateString { get; set; }
        public string StartDateString { get; set; }
        public string CreateddateString { get; set; }
        public string EndDateString { get; set; }
        public bool isQuantity { get; set; }
        public int Quantity { get; set; }

        public bool IsSelected { get; set; }

        public bool IsDeleted { get; set; }

        public bool TaxNotAvailable { get; set; }

        public bool isFreeze { get; set; }

        public bool isAlreadySelected { get; set; }
        public bool IsDeductible { get; set; }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string VehicleType { get; set; }

        [Serializable]
        public enum CalcType
        {
            Fixed = 1,
            Percentage = 2,
            Perday = 3,
            Replace = 4
        }
    }
}
