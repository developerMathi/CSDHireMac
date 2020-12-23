using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    using System.Security.Principal;
    using System.Web;
    public class CutomerContext
    {
        #region Public Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CutomerContext()
        {
            ClientID = 0;
            CustomerId = 0;
        }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <param name="userName"></param>
        public CutomerContext(int CustomerId, string CustomerUserName)
        {
            ClientID = 0;
            this.CustomerId = CustomerId;
            this.CustomerUserName = CustomerUserName;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the customer id.
        /// </summary>
        /// <value>The user id.</value>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the client ID.
        /// </summary>
        /// <value>The client ID.</value>
        public int ClientID { get; set; }

        /// <summary>
        /// Gets the user name.
        /// </summary>
        /// <value>The user name.</value>
        public string CustomerUserName { get; set; }

        /// <summary>
        /// Gets the type of the user authentication.
        /// </summary>
        /// <value>The type of the user authentication.</value>
        public string CustomerAuthenticationType { get; set; }

        #endregion
    }
}
