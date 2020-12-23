using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class EmailClientDetails
    {
        public int ClientEmailId { get; set; }
        public int EmailTrackId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string CCAddresss { get; set; }
        public string Subject { get; set; }
        public string HtmlContent { get; set; }
        public DateTime? SentDate { get; set; }
        //public int? SentBy { get; set; }
        public bool? IsSuccess { get; set; }
        public string UserName { get; set; }

    }
}
