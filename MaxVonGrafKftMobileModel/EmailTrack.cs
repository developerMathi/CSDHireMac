using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class EmailTrack
    {
        public int EmailTrackId { get; set; }
        public int EmailType { get; set; }  // enum EmailType
        public int EmailTypeId { get; set; }
        public DateTime? SentDate { get; set; }
        public int? SentBy { get; set; } // User id 
        public int? SentFrom { get; set; } // enum EmailSentFrom
        public int? TemplateId { get; set; }
        public int? ClientId { get; set; }
        public bool? IsSuccess { get; set; }
        public string UserName { get; set; }
        public string ErrorLog { get; set; }
        public string StackTrace { get; set; }
        public string FromAddress { get; set; }
        public string NameForEmail { get; set; }
        public string ToAddress { get; set; }
        public string CCAddress { get; set; }
        public string BodyContent { get; set; }

    }
}
