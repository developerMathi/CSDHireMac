using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public partial class Terms
    {
        public int? Id { get; set; }

        public int ClientId { get; set; }
        public string Term { get; set; }

        public string Description { get; set; }
        public Int16 Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Version { get; set; }
        public int OldReferencedId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
