using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.AccessModels
{
    [Serializable]
    public class LocationTaxResult
    {
        /// <summary>
        /// 
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LocationName { get; set; }
        public bool isSelected { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class LocationTaxResultOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOption { get; set; }


    }
}
