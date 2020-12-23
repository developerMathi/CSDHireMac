using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public partial class Vehicle
    {
        private VehicleMake makeInfo;
        private VehicleStatus status;
        private VehicleModel vehicleModelInfo;
        private string statusName;
        public string vehicleDescription;


        public Vehicle()
        {
        }

        public int vehicleId { get; set; }
        public int ClientId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public string ModelCode { get; set; }
        public int? Year { get; set; }
        public string Trim { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public short? Doors { get; set; }
        public int? OrigionalOdometer { get; set; }
        public int? CurrentOdometer { get; set; }
        public DateTime LastOdometerUpdated { get; set; }
        public decimal? DownPayment { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? LeaseAmt { get; set; }
        public short? Term { get; set; }
        public short? LeaseRemainingTerm { get; set; }
        public int? LeasingCompanyID { get; set; }
        public decimal? Cashvalue { get; set; }
        public decimal? AdditionalExpenses { get; set; }
        public DateTime Lastupdated { get; set; }
        public int LastupdatedBy { get; set; }
        public int VehicleTypeId { get; set; }
        public short? Cylinders { get; set; }
        public string Transmission { get; set; }
        public string Memo { get; set; }
        public Int16 StatusId { get; set; }
        public int CurrentLocationId { get; set; }
        public int? OwningLocationId { get; set; }
        public string SpotNumber { get; set; }
        public bool Active { get; set; }
        public string FuelType { get; set; }
        public string FuelLevel { get; set; }
        public short? TakeSize { get; set; }
        public short? BatteryLevel { get; set; }
        public Int16 MaintenanceEvery { get; set; }
        public int? InsuranceCompanyID { get; set; }
        public decimal? InsuranceAmount { get; set; }
        public DateTime? InspectionDate { get; set; }
        public short? InspectionFrequency { get; set; }
        public string LicenseNo { get; set; }
        public int? LicenseState { get; set; }
        public DateTime? LicenseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string VehicleNo { get; set; }
        public bool? IsSale { get; set; }
        public bool? IsReservation { get; set; }
        public string Ownership { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? SoldDate { get; set; }
        public DateTime? MOTExpairyDate { get; set; }
        public DateTime? TDExpairyDate { get; set; }
        public DateTime? PHVExpairyDate { get; set; }
        public string PHVNumber { get; set; }
        public VehicleTypeModel VehicleType { get; set; }
        public string ImagePath { get; set; }
        public string VehicleImageName { get; set; }
        public string ImageBase64 { get; set; }
        public List<ScheduledVehicleMaintenance> Services { get; set; }
        public bool IsTransfered { get; set; }
        public String TypeName { get; set; }
        public bool? IsTrack { get; set; }

        public VehicleModel ModelInfo
        {
            get
            {
                return vehicleModelInfo;
            }
            set
            {
                vehicleModelInfo = value;
            }
        }
        public VehicleMake MakeInfo
        {
            get
            {
                return this.makeInfo;
            }
            set
            {
                this.makeInfo = value;
            }
        }
        public string FullVehicleNameWithLicense
        {

            get
            {

                try
                {
                    vehicleDescription = Year.HasValue ? String.Format("{0} {1} {2} - {3} - {4}", MakeInfo.VehicleMakeName, ModelInfo.ModelName, Year, LicenseNo, VehicleNo) : String.Format("{0} {1} - {2} - {3} ", MakeInfo.VehicleMakeName, ModelInfo.ModelName, LicenseNo, VehicleNo);
                }
                catch
                {
                }

                return vehicleDescription;
            }
            set
            {
                vehicleDescription = value;
            }
        }
        //public VehicleStatus Status
        //{
        //    get
        //    {
        //        return status;
        //    }
        //    set
        //    {
        //        status = value;
        //    }
        //}

        //public string StatusName
        //{
        //    get
        //    {
        //        return statusName;
        //    }

        //    set
        //    {
        //        status = value;
        //    }
        //}

    }

    public class VehicleBasicInfoViewModel
    {
        public int vehicleId { get; set; }
        public string LicenseNo { get; set; }
        public string VehicleNo { get; set; }
        public string Vin { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int? Year { get; set; }
        public int VehicleTypeId { get; set; }
        public int CurrentLocationId { get; set; }
        public string FuelType { get; set; }
        public string FuelLevel { get; set; }
        public short? TakeSize { get; set; }

    }

    public class ScheduledVehicleMaintenance
    {
        public string MaintenanceName { get; set; }
        public int MaintenanceSchedulerId { get; set; }
        public int VehicleId { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime NextServiceDate { get; set; }
        public string LastServiceDateStr { get; set; }
        public string NextServiceDateStr { get; set; }
        public int IntervalMileage { get; set; }
        public bool InService { get; set; }
        public int IntervalMonths { get; set; }
        public int NextServiceMileage { get; set; }
        public int LastServiceMileage { get; set; }
        public int Interval { get; set; }
        public bool IsChecked { get; set; }
    }

}
