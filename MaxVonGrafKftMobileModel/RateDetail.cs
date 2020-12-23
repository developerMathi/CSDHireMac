using System;
using System.Collections.Generic;

namespace MaxVonGrafKftMobileModel
{
    public class RateDetail
    {
        public int RateID { get; set; }
        public string RateName { get; set; }
        public double RateValue { get; set; }
        public double ExtraValue { get; set; }
        public int HowMany { get; set; }
        public int HowManyExtra { get; set; }
        public int KMAllowed { get; set; }
        public bool IsVisible { get; set; }
        public double RateTotal { get; set; }
        public double ExtraRateTotal { get; set; }

        public double ExtraKMValue { get; set; }

        public decimal InitalRate { get; set; }
        public decimal IncrementValue { get; set; }
        public int ClientId { get; set; }
        public int? LocationId { get; set; }
        public Int32 RateId { get; set; }
        public int? VehicleTypeId { get; set; }
        public decimal? KMorMileageCharge { get; set; }
        public decimal? FuelCharge { get; set; }

        public decimal? HourlyRate { get; set; }
        public int HourlyQty { get; set; }

        public decimal? HalfDayRate { get; set; }
        public int HalfDayQty { get; set; }

        public decimal? DailyRate { get; set; }
        public int DailyQty { get; set; }

        public decimal? WeekendDayRate { get; set; }
        public int WeekendDailyQty { get; set; }

        public decimal? WeeklyRate { get; set; }
        public int WeeklyQty { get; set; }

        public decimal? MonthlyRate { get; set; }
        public int MonthlyQty { get; set; }

        //total days
        public int TotalDays { get; set; }

        //Extra Rates and qty
        public decimal? ExtraHourlyRate { get; set; }
        public int ExtraHourlyQty { get; set; }

        public decimal? ExtraDailyRate { get; set; }
        public int ExtraDailyQty { get; set; }

        public decimal? ExtraWeekEndDayRate { get; set; }
        public int ExtraWeekEndDayQty { get; set; }

        public decimal? ExtraWeeklyRate { get; set; }
        public int ExtraWeeklyQty { get; set; }

        // km allowed
        public int? DailyKMorMileageAllowed { get; set; }
        public int? WeeklyKMorMileageAllowed { get; set; }
        public int? MonthlyKMorMileageAllowed { get; set; }
        public int? TotalKMorMileageAllowed { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsLowest { get; set; }
        public decimal EstimatedTotal { get; set; }
        public decimal MiscChargeTotal { get; set; }
        public decimal MiscChargeNonTaxableTotal { get; set; }
        public decimal TaxSum { get; set; }
        public ReservationSummaryDetails ReservationSummary { get; set; }
    }

    [Serializable]
    public class ReservationSummaryDetails
    {
        public string SubTotal { get; set; }
        public List<ReservationTaxDetails> TaxDetails { get; set; }
        public List<ReservationMiscDetails> MiscDetails { get; set; }
        public string TotalTax { get; set; }
        public string TotacMiscTaxable { get; set; }
        public string TotacMiscNonTaxable { get; set; }
        public string EstimatedTotal { get; set; }
        public string BaseTaxRate { get; set; }
        public string BaseRate { get; set; }
    }

    [Serializable]
    public class ReservationTaxDetails
    {
        public int LocationId { get; set; }
        public int TaxId { get; set; }
        public string Description { get; set; }
        public string TotalAmount { get; set; }
    }

    [Serializable]
    public class ReservationMiscDetails
    {
        public int VehicleTypeId { get; set; }
        public int MiscChargeID { get; set; }
        public string Name { get; set; }
        public string MiscChargePerDay { get; set; }
        public int Quantity { get; set; }
        public int TotaDays { get; set; }
        public string TotalMisc { get; set; }
        public bool IsTaxable { get; set; }
    }
}
