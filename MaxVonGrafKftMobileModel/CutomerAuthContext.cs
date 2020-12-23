using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class CutomerAuthContext : CutomerContext
    {
        #region Properties

        public string Address { get; set; }

        public string Email { get; set; }

        public int StateId { get; set; }

        public string StateName { get; set; }

        public int Country { get; set; } //? 

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        //   public int ClientId { get; set; }

        private string firstName = string.Empty;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string phone = string.Empty;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string lastName = string.Empty;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CustomerName { get; set; }

        public string ConsumerType { get; set; }

        public int UserRoleID { get; set; }

        public int UserGroupID { get; set; }

        private string roleName = string.Empty;
        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        private string customizationFolder = string.Empty;
        public string CustomizationFolder
        {
            get { return customizationFolder; }
            set { customizationFolder = value; }
        }

        private string theme = string.Empty;
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

        public double MaxFileSize { get; set; }

        public double UsedFileSize { get; set; }

        public int MaxNoOfVehicles { get; set; }

        public int MaxNoOfUser { get; set; }

        private string masterPage = string.Empty;
        public string MasterPage
        {
            get { return masterPage; }
            set { masterPage = value; }
        }

        private string culture = string.Empty;
        public string Culture
        {
            get { return culture; }
            set { culture = value; }
        }

        private string uiculture = string.Empty;
        public string UICulture
        {
            get { return uiculture; }
            set { uiculture = value; }
        }

        public string TimeZone { get; set; }

        public string userCultureInfo { get; set; }

        public string ClientCurrency { get; set; }

        public string ClientCurrencySymbol { get; set; }

        #endregion

        public CutomerAuthContext()
        {
            UserRoleID = 0;
        }
    }
}
