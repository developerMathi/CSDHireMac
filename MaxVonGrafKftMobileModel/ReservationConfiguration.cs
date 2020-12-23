using MaxVonGrafKftMobileModel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationConfiguration
    {
        public int ConfigurationID { get; set; }
        public int VehicleCategoryId { get; set; }
        public int LocationId { get; set; }
        public int VehicleTypeId { get; set; }
        public int VehicleMakeID { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public int Transmission { get; set; }
        public decimal Deposit { get; set; }
        public decimal AdditionalDeposit { get; set; }
        public int Baggages { get; set; }
        public int Seats { get; set; }
        public int KmAllowed { get; set; }
        public int Priority { get; set; }
        public string PickupDays { get; set; }
        public string[] PickingupDays { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public string AgeGap { get; set; }
        public bool IsOnline { get; set; }
        public decimal InsuranceExcess { get; set; }
        public int passengers { get; set; }
    }

    public class RentalRatePromotion
    {
        public int ReservationConfigId { get; set; }
        public int RentalRatePromotionId { get; set; }
        public RentalPeriod RentalPeriod { get; set; }
        public String RentalPeriodString { get; set; }
        public int RentalPeriodDigit { get; set; }
        public int RentalRateId { get; set; }
        public int PromotionRateId { get; set; }
        public string RentalRate { get; set; }
        public string PromotionRate { get; set; }
        public DateTime PromotionDatesStartDate { get; set; }
        public DateTime PromotionDatesEndDate { get; set; }
        public String PromotionStartDate { get; set; }
        public String PromotionEndDate { get; set; }

        public List<Rates> RentalRates { get; set; }
        public List<Rates> PromotionRates { get; set; }
    }

    public class RentalRatePromotionVM
    {
        public RentalRatePromotion Search { get; set; }
        public List<RentalRatePromotion> List { get; set; }
    }

    public class ReservationConfigurationViewModel : ReservationConfiguration
    {
        public string VehicleCategoryName { get; set; }
        public string LocationName { get; set; }
        public string VehicleTypeName { get; set; }
        public string VehicleMakeName { get; set; }
        public string VehicleModelName { get; set; }
    }

    public class ReservationConfigurationSearch
    {
        public int VehicleCategoryId { get; set; }
        public int LocationId { get; set; }
        public int VehicleTypeId { get; set; }
        public int VehicleMakeID { get; set; }
        public int ModelId { get; set; }
        public string AgeDuration { get; set; }
        public bool IsOnline { get; set; }
    }


    public class ReservationConfigurationVehicleSearch
    {
        public int VehicleCategoryId { get; set; }
        public int LocationId { get; set; }
        public int VehicleTypeId { get; set; }
        public int VehicleMakeID { get; set; }
        public int ModelId { get; set; }
        public string AgeDuration { get; set; }
        public bool IsOnline { get; set; }
        public int NumberOfSeats { get; set; }
        //public DateTime PickupDate { get; set; }
        public int RentalPeriod { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? VehicleId { get; set; }
        public int ClientId { get; set; }
        public string AgreementTypeName { get; set; }
        public int CheckInLocationId { get; set; }
        public string RateName { get; set; }
    }

    public class ReservationConfigurationSearchList
    {
        public ReservationConfigurationSearch Search { get; set; }
        public List<ReservationConfigurationViewModel> List { get; set; }

    }

    /// <summary>
    /// Use in API 
    /// </summary>
    public class ReservationConfigurationForAPI
    {
        public int ConfigurationID { get; set; }
        public int VehicleCategoryId { get; set; }
        public string VehicleCategoryName { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public int VehicleMakeID { get; set; }
        public string VehicleMake { get; set; }
        public int ModelId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public decimal Deposit { get; set; }
        public decimal AdditionalDeposit { get; set; }
        public decimal InsuranceExcess { get; set; }
        public int Baggages { get; set; }
        public int Seats { get; set; }
        public int KmAllowed { get; set; }
        public int Priority { get; set; }
        public string PickupDays { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public bool IsOnline { get; set; }
        public bool IsPromotionAvailable { get; set; }
        public string VehicleImageUrl { get; set; }  // get it from model
        public string LocationImageUrl { get; set; }
        public string LocationImage { get; set; }
        public string VehicleImageName { get; set; }
        public int RentalRatesId { get; set; }
        public int PromotionRateId { get; set; }
        // Actual Rate
        public LocationRate LocationActualRate { get; set; }
        // Promotion Rate
        public LocationRate LocationPromotionRate { get; set; }
    }

    public class VehiClePriority
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int MaximumNoOfVehicles { get; set; }
        public int Priority { get; set; }

    }
}
