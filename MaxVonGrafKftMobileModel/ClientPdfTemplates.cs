using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ClientPdfTemplates
    {
        public int TemplateId { get; set; }

        public int Status { get; set; }

        public int TemplateType { get; set; }

        public string TemplateName { get; set; }

        public string TemplateURL { get; set; }

        public bool IsActive { get; set; }

        public bool isSeleted { get; set; }

    }
}
