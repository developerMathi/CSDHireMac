using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class ReservationVehicleSearchViewModel
    {
        public int vehicleId { get; set; }
        public int ClientId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int VehicleMakeID { get; set; }
        public string VehicleMake { get; set; }
        public string Model { get; set; }
        public string LocationImage { get; set; }
        public string VehicleImage { get; set; }
        public string VehicleMakeName { get; set; }
        public string ModelName { get; set; }
        public string Vin { get; set; }
        public string LicenseNo { get; set; }
        public string VehicleTypeImage { get; set; }
        public string ModelCode { get; set; }
        public int? Year { get; set; }
        public string HtmlContent { get; set; }

        public string Transmission { get; set; } // Auto or Manual
        public string VehicleCategory { get; set; } // Luxury / or etc
        public int NoOfPassanger { get; set; }
        public int NoOfLuggage { get; set; }
        public bool isPromotion { get; set; }

        public decimal? InsuranceAmount { get; set; }
        public decimal? AdditionalDeposit { get; set; }
        public decimal? MileagePerDay { get; set; }

        public decimal ActualPrice { get; set; }
        public decimal? PromotionPrice { get; set; }
        public decimal? DepositAmount { get; set; }


        //////////////////////////////////////////////
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public string Enabled { get; set; }

        public string VehicleCategoryName { get; set; }
        public decimal Deposit { get; set; }
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
        public string VehicleImageName { get; set; }
        public int RentalRatesId { get; set; }
        public int PromotionRateId { get; set; }
        // Actual Rate
        public LocationRate LocationActualRate { get; set; }
        // Promotion Rate
        public LocationRate LocationPromotionRate { get; set; }
        public DateTime? PromotionStartDate { get; set; }
        public DateTime? PromotionEndDate { get; set; }
        public string Sample { get; set; }
        public string Doors { get; set; }
        public int TransmissionNO { get; set; }
        public double Rate { get; set; }
        public string Enable { get; set; }
        public bool Status { get; set; }
        public RateDetail RateDetail { get; set; }
        public int days { get; set; }
        public int hours { get; set; }
        public int weeks { get; set; }
        public int months { get; set; }
        public int VehicleStatusId { get; set; }
        public List<LocationTaxModel> Tax { get; set; }
        public string VehicleNo { get; set; }
    }
}
