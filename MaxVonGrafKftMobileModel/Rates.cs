using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Rates
    {
        public Rates()
        { }
        public int ClientId { get; set; }
        public int? LocationId { get; set; }
        public Int32 RateId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string CalculatedBy { get; set; }
        public decimal? KMorMileageCharge { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? OneWayCharge { get; set; }
        public short? GraceMinutes { get; set; }


        // Rental rates and qty
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? HourlyRate { get; set; }
        public int HourlyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? HalfDayRate { get; set; }
        public int HalfDayQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? DailyRate { get; set; }
        public int DailyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal WeekendDayRate { get; set; }
        public int WeekendDailyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? WeeklyRate { get; set; }
        public int WeeklyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? MonthlyRate { get; set; }
        public int MonthlyQty { get; set; }

        public string PackageName { get; set; }
        public decimal? PackageRate { get; set; }
        public int? PackageRateId { get; set; }

        //total days
        public int TotalDays { get; set; }
        public int DaysInWeek { get; set; }

        //Extra Rates and qty
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraHourlyRate { get; set; }
        public int ExtraHourlyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraDailyRate { get; set; }
        public int ExtraDailyQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraWeekEndDayRate { get; set; }
        public int ExtraWeekEndDayQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? ExtraWeeklyRate { get; set; }
        public int ExtraWeeklyQty { get; set; }


        // km allowed
        public int? DailyKMorMileageAllowed { get; set; }
        public int? WeeklyKMorMileageAllowed { get; set; }
        public int? MonthlyKMorMileageAllowed { get; set; }
        public int? TotalKMorMileageAllowed { get; set; }
        public int? PackageKMorMileageAllowed { get; set; }
        public int? PackageDaysIncluded { get; set; }


        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string RateName { get; set; }
        public bool? Active { get; set; }
        public decimal? SpecialRate { get; set; }
        public int? SpecialKMorMileageAllowed { get; set; }
        public decimal? ExtraSpecialRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }

        public double RateValue { get; set; }
        public double ExtraValue { get; set; }
        public int HowMany { get; set; }
        public int HowManyExtra { get; set; }
        public int KMAllowed { get; set; }
        public bool IsVisible { get; set; }
        public bool IsLowest { get; set; }
        public double RateTotal { get; set; }
        public double ExtraRateTotal { get; set; }
        public int UserId { get; set; }
        public decimal InitalRate { get; set; }
        public decimal IncrementValue { get; set; }

        public List<DayRate> DayRateList { get; set; }

    }

    public class DayRate
    {
        public int DiscountedDailyRateId { get; set; }

        public int RateId { get; set; }
        public int Day { get; set; }
        public int Days { get; set; }
        public double Rate { get; set; }

    }


    public class MileageBrakedownDetails
    {
        public int MileageBrakdownId { get; set; }
        public int MileageChargeId { get; set; }
        public string MileageRange { get; set; }
        public double Rate { get; set; }


        public string VehicleTypeId { get; set; }
        public string VehicleType { get; set; }

        public int LocationId { get; set; }
        public string Location { get; set; }

        public int ClientId { get; set; }

        public int RateId { get; set; }
        public string RateName { get; set; }
        public int StartKm { get; set; }
        public int EndKm { get; set; }
        public float Cost { get; set; }
    }
}
