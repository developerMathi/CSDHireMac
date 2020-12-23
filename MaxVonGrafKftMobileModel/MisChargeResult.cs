using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class MisChargeResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int VehicleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary> 
        public int LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MiscChargeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Fixed, Percentage, Perday
        /// </summary>
        public string CalculationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MisChargeCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOptional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool TaxNotAvailable { get; set; }

        public bool IsQuantity { get; set; }

        public bool isSelected { get; set; }

    }
}
