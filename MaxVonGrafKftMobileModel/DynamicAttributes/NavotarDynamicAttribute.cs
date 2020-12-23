using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;

namespace MaxVonGrafKftMobileModel.DynamicAttributes
{
    /// <summary>
    /// NavotarDynamicAttribute
    /// </summary>
    [Serializable]
    public class NavotarDynamicAttribute
    {
        public NavotarDynamicAttribute() { }
        public VehicleAttribute vehicleAttrib { get; set; }
        public ReservationAttribute ReservationAttrib { get; set; }
        public CustomerAttribute CustomerAttrib { get; set; }
        public AgreementAttribute AgreementAttrib { get; set; }
    }

    #region Main TAB
    /// <summary>
    /// VehicleAttribute
    /// </summary>
    public class VehicleAttribute : CommonAttributes
    {
        public VehicleAttribute() { }

        public V_VehicleImage vVehicleImage { get; set; }
        public V_Technical vTechnical { get; set; }
        public V_LicenseAndInsurance vLicenseAndInsurance { get; set; }
        public V_Ownership vOwnership { get; set; }
        public V_VehicleOption vVehicleOption { get; set; }
        public V_OtherInformation vOtherInformation { get; set; }
    }

    /// <summary>
    /// ReservationAttribute
    /// </summary>
    public class ReservationAttribute : CommonAttributes
    {
        public ReservationAttribute() { }
        public R_Note rNote { get; set; }
        public R_AirportInformation rAirportInformation { get; set; }
        public R_OtherInformation rOtherInformation { get; set; }
    }

    /// <summary>
    /// CustomerAttribute
    /// </summary>
    public class CustomerAttribute : CommonAttributes
    {
        public CustomerAttribute() { }
        public C_InsuranceInformation cInsuranceInformation { get; set; }
        public C_OtherInformation cOtherInformation { get; set; }
        public C_BankAccountInformation cBankAccountInformation { get; set; }
        public C_CreditCardInformation cCreditCardInformation { get; set; }
    }

    /// <summary>
    /// AgreementAttribute
    /// </summary>
    public class AgreementAttribute : CommonAttributes
    {
        public AgreementAttribute() { }
        public A_Note aNote { get; set; }
        public A_OtherInformation aOtherInformation { get; set; }
        public A_AirportInformation aAirportInformation { get; set; }
    }

    #endregion

    #region Vehicle Related TAB Class
    public class V_VehicleImage : MainAttributes { }

    public class V_Technical : MainAttributes { }

    public class V_LicenseAndInsurance : MainAttributes { }

    public class V_Ownership : MainAttributes { }

    public class V_VehicleOption : MainAttributes { }

    public class V_OtherInformation : MainAttributes { }

    #endregion

    #region Customer related TAB Class

    public class C_InsuranceInformation : MainAttributes { }

    public class C_OtherInformation : MainAttributes { }

    public class C_BankAccountInformation : MainAttributes { }

    public class C_CreditCardInformation : MainAttributes { }


    #endregion

    #region Reservation related TAB Class

    public class R_Note : MainAttributes { }

    public class R_AirportInformation : MainAttributes { }

    public class R_OtherInformation : MainAttributes { }


    #endregion

    #region Agreement related TAB Class

    public class A_Note : MainAttributes { }

    public class A_OtherInformation : MainAttributes { }

    public class A_AirportInformation : MainAttributes { }

    #endregion

    /// <summary>
    /// DynamicDropdownList
    /// </summary>
    public class DynamicDropdownList
    {
        public int clientMappingID { get; set; }
        public string KeyValue { get; set; }
        public string DisplayName { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool IsMandatory { get; set; }
    }

    /// <summary>
    /// MainAttributes
    /// </summary>
    public class MainAttributes
    {
        public List<DynamicDropdownList> dropDownList = new List<DynamicDropdownList>();
        public Dictionary<string, List<object>> Fields { get; set; }
    }

    /// <summary>
    /// CommonAttributes
    /// </summary>
    public class CommonAttributes
    {
        public int ClientID { get; set; }
        public int ReferenceID { get; set; }
        public string ReferenceName { get; set; }
        public int ClientAttributeID { get; set; }
    }
}
