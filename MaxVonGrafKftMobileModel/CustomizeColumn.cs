using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class CustomizeColumn
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string vehicleHeader { get; set; }
        public string AgreementHeader { get; set; }
        public string ReservationHeader { get; set; }
        public string CustomerHeader { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int TypeId { get; set; }
        public bool IsSelected { get; set; }
        public List<CustomizeColumn> List { get; set; }
        public List<ColumnListViewModel> columlist { get; set; }
        public int ColumnId { get; set; }

    }

    public class ColumnListViewModel
    {
        public int? ClientId { get; set; }
        public int ColId { get; set; }
        public string ColumnHeader { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public bool IsSelected { get; set; }
        public int ColumnId { get; set; }

    }
}
