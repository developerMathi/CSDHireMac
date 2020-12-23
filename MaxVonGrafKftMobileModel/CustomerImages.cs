using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class CustomerImages
    {
        public CustomerImages()
        {
        }

        public int ImageID { get; set; }
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string PhysicalPath { get; set; }

        public DateTime UploadedDate { get; set; }

        public string Base64 { get; set; }
    }
}
