using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class LocationRate
    {
        public int RateId { get; set; }
        public decimal? KMorMileageCharge { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? OneWayCharge { get; set; }
        public short? GraceMinutes { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public decimal? ExtraDailyRate { get; set; }
        public decimal? WeeklyRate { get; set; }
        public decimal? ExtraWeekllyRate { get; set; }
        public decimal? MonthlyRate { get; set; }
        public int? DailyKMorMileageAllowed { get; set; }
        public int? WeeklyKMorMileageAllowed { get; set; }
        public int? MonthlyKMorMileageAllowed { get; set; }
        public string RateName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public decimal? SpecialRate { get; set; }
        public int? SpecialKMorMileageAllowed { get; set; }
        public decimal? ExtraSpecialRate { get; set; }

        public decimal? DailyRateIncluingTax { get; set; }
        public decimal? WeeklyRateIncluingTax { get; set; }


    }
}
