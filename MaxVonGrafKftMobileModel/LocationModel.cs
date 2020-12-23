using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class LocationModel
    {
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public int ClientId { get; set; }
        public string CreatedByName { get; set; }
        public string LastUpdatedByName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string Postal { get; set; }
        public bool? Active { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string Phone { get; set; }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }

        public bool IsSelected { get; set; }
        public bool IsReservation { get; set; }

    }

    public class StoreLocation
    {
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public bool? Active { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string EmailName { get; set; }
        public string Phone { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public bool IsReservation { get; set; }
    }
}
