using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class AgreementEquipment
    {
        public AgreementEquipment()
        {

        }
        [Key]
        public int EquiptmentID { get; set; }
        public int OriginalEquiptmentID { get; set; }

        public int AgreementID { get; set; }
        public int? EquipmentType { get; set; }
        public string Note { get; set; }
        public string Condition { get; set; }
        public int? CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CreatedDate { get; set; }
        public int? LastupdatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? LastUpdateDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? EquipmentDelivryDate { get; set; }
        public string EquipmentDelivryDateStr { get; set; }
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? EquipmentReturnDate { get; set; }
        public string EquipmentReturnDateStr { get; set; }
        public string EquipmentTypeName { get; set; }
        public bool IsDelete { get; set; }

    }
}
