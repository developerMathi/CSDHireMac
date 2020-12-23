using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    public class CustomerLoginModel
    {
        public CustomerLoginModel()
        {
            Login = new CustomerLogin();
            Registration = new CustomerReview();
        }
        public CustomerLogin Login { get; set; }
        public CustomerReview Registration { get; set; }
    }
    public class CustomerLogin
    {
        public string hPhone { get; set; }

        public string Password { get; set; }

        public int clientId { get; set; }

        public int CustomerId { get; set; }

        public string RequestIp { get; set; }
        public string ErrorMsg { get; set; }
        public string Country { get; set; }
        public bool RememberMe { get; set; }
        public string email { get; set; }
    }
}
