using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class Document
    {
        public Document()
        {
        }

        public int DocumentId { get; set; }
        public int ClientId { get; set; }
        public string NewFileName { get; set; }
        public string OldFileName { get; set; }
        public float FileSize { get; set; }
        public bool IsDeleted { get; set; }
        public int ReferenceId { get; set; }
        public Int16 ReferenceType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ContentType { get; set; }
        public int DocTypeId { get; set; }
        public string FilePath { get; set; }
        public string Image { get; set; }
        public string Side { get; set; }
        public string DocName { get; set; }
    }
}
