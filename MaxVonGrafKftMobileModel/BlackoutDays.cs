using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class BlackoutDays
    {
        public int? BlackoutDateId { get; set; }
        public int? ReferenceId { get; set; }
        public Constants.ReferenceType ReferenceType { get; set; } // Reservation / agreement 
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DateType { get; set; }
        public string DateDescription { get; set; }
        public int ClientId { get; set; }
        public int? VehicleStatus { get; set; }

        //USS
        public int BlackoutType { get; set; }

    }

    public class BlackoutDaysViewModel : BlackoutDays
    {
        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool IsLastRecord { get; set; }
        public bool IsUsedInContract { get; set; }
        public bool IsReturnDateAvailable { get; set; }

        public List<BlackoutDaysViewModel> List { get; set; }
    }

    public class BlackoutDaysBasicInfo
    {
        public Constants.ReferenceType ReferenceType { get; set; } // Reservation / agreement 
        public int? ReferenceId { get; set; }
        public string ReferenceNumber { get; set; }
        public int Status { get; set; } // Agreement or reservation status
        public decimal PerDayRate { get; set; } // agrement per day rate 
        public int NoOfInactiveDays { get; set; }
        public decimal InactiveDayDeduction { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime CheckinDate { get; set; }
        public bool IsCanAddNewRecord { get; set; }
        public bool IsReturnDateAvailable { get; set; }

    }

    public class BlackoutDaysList
    {
        public BlackoutDaysBasicInfo BasicInfo { get; set; }
        public List<BlackoutDaysViewModel> List { get; set; }
    }

    public class BlackOutDayAmounts
    {
        public decimal PerDayRate { get; set; }
        public int NoOfInactiveDays { get; set; }
        public decimal InactiveDayDeduction { get; set; }
    }
}
