using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class ReservationNote
    {

        [Key]
        public int ReservationNoteId { get; set; }
        public int? ResevartionId { get; set; }
        public string Note { get; set; }
        public int? CreatedBy { get; set; }


        public DateTime? CreatedDate { get; set; }

        public string CreatedDateStr { get; set; }

        public string UserName { get; set; }

        public int NoteId { get; set; }
    }
}
