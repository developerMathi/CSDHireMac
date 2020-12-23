using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class AddRateViewModel
    {
        public AddRateDropDownListSet AddRateDropDownListSet { get; set; }
        public AddRateFieldValueSet FieldValuSet { get; set; }
        public string RateName { get; set; }
        public string LocationId { get; set; }
        public string VehicleTypeId { get; set; }
        public float InitialRate { get; set; }
        public float IncrementRate { get; set; }
        public List<LocationRate> List { get; set; }
        public List<DayRate> DayRate { get; set; }

        public List<AddRateFieldValueSet> rateList { get; set; }
    }
    public class RateSearchModel
    {
        public AddRateDropDownListSet AddRateDropDownListSet { get; set; }
        public string RateName { get; set; }
        public string LocationId { get; set; }
        public string VehicleTypeId { get; set; }
        public List<LocationRate> List { get; set; }
    }
    public class AddRateFieldValueSet : VehicleTypeModel
    {
        /// <summary>
        /// Following properties are not visible in the view
        /// </summary>
        public int RateId { get; set; }
        public int? RateNameId { get; set; }
        public int? LocationId { get; set; }
        public string RateName { get; set; }
        /// <summary>
        /// The followong parameters are visible on the view
        /// </summary>
        public decimal? HourlyRate { get; set; }
        public decimal? DailyRate { get; set; }
        public decimal? SpecialRate { get; set; }
        public decimal? ExtraSpecialRate { get; set; }
        public decimal? WeeklyRate { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? ExtraDailyRate { get; set; }
        public decimal ExtraWeeklyRate { get; set; }
        public decimal? FuelCharge { get; set; }
        public decimal? MilesCharge { get; set; }
        public int? DailyMilesAllowed { get; set; }
        public int? WeeklyMilesAllowed { get; set; }
        public int? SpecialMilesAllowed { get; set; }
        public int? MonthlyMilesAllowed { get; set; }
        public short? GraceMinitues { get; set; }
        public decimal? OneWayCharge { get; set; }
        public bool Active { get; set; }
        public decimal? WeekendCharge { get; set; }
        public decimal? ExtraWeekendCharge { get; set; }
        public decimal? HalfDayRate { get; set; }
        public string CalculatedBy { get; set; }
        public int? LastUpdatedBy { get; set; }
        public decimal? ExtraHourlyRate { get; set; }
        public int UserId { get; set; }
        public decimal? KMorMileageCharge { get; set; }
        public int DailyKMorMileageAllowed { get; set; }

        public decimal? ActualHourlyRate { get; set; }
        public decimal? ActualHalfDayRate { get; set; }
        public decimal? ActualDailyRate { get; set; }
        public decimal? ActualWeeklyRate { get; set; }
        public decimal? ActualMonthlyRate { get; set; }
        public decimal? ActualExtraHourlyRate { get; set; }
        public decimal? ActualExtraDailyRate { get; set; }
        public decimal? ActualExtraWeekllyRate { get; set; }
        public List<LocationView> LocationList { get; set; }

        public float InitialRate { get; set; }
        public float IncrementRate { get; set; }

        public bool EditAvailable { get; set; }
        public bool DeleteAvailable { get; set; }

        public string CreatedByName { get; set; }
        public string LastUpdatedByName { get; set; }
        public string LocationName { get; set; }

    };
    public class AddRateDropDownListSet
    {
        public List<RateNameView> RateNameList { get; set; }
        public List<VehicleTypeView> VehicleTypeList { get; set; }
        public List<LocationView> LocationList { get; set; }
    }
    public class RateNameView
    {
        public string RateName { get; set; }
        public int RateNameId { get; set; }
    }
    public class VehicleTypeView
    {
        public string VehicleTypeName { get; set; }
        public int VehicleTypeId { get; set; }

    }
    public class LocationView
    {
        public string LocationName { get; set; }
        public int LocationId { get; set; }
    }

    /// <summary>
    /// Mileage charge breakdown
    /// </summary>
    public class MileageChargeViewModel
    {
        public int MileageChargeId { get; set; }
        public string VehicleTypeId { get; set; }
        //public string VehicleType { get; set; }

        public int LocationId { get; set; }
        //public string Location { get; set; }

        //public int ClientId { get; set; }

        public int RateId { get; set; }
        //public string RateName { get; set; }

        //public string Description { get; set; }
        //public int StartKm { get; set; }
        //public int EndKm { get; set; }

        //public double Cost { get; set; }

        public List<MileageBrakedownDetails> MileageBrakedowns { get; set; }
    }

}
