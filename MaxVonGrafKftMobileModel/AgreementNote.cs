using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class AgreementNote
    {
        public AgreementNote()
        { }
        [Key]
        public int NoteId { get; set; }
        public int? AgreementId { get; set; }
        public string Note { get; set; }
        public int? CreatedBy { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CreatedDate { get; set; }

        public string CreatedDateStr { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }

        public bool EditAvailable { get; set; }
        public bool DeleteAvailable { get; set; }

    }
}
