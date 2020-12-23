using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using MaxVonGrafKftMobileServices.ApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileController
{
    public class CommonController
    {
        private CommonService commonService;
        public CommonController()
        {
            commonService = new CommonService();
        }

        public GetAllCountryForMobileResponse GetAllCountry(string access_token)
        {
            return commonService.GetAllCountry(access_token);
        }

        public GetAllStateForMobileResponse GetAllStateByCountryID(GetAllStateForMobileRequest stateRequest, string token)
        {
            return commonService.GetAllStateByCountryID(stateRequest, token);
        }

        public List<LocationModel> GetAllLocation(string token)
        {
            return commonService.GetAllLocation(token);
        }

        public GetAllLocationForClientIDForMobileResponse getAllLocationsByClientId(GetAllLocationForClientIDForMobileRequest locationRequest, string token)
        {
            GetAllLocationForClientIDForMobileResponse locations = null;
            try

            {
                locations = commonService.getAllLocationsByClientId(locationRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return locations;
        }

        public EmailContactusRes contactUs(EmailContactusReq emailContactusReq, string token)
        {
            EmailContactusRes contactusRes = null;
            try

            {
                contactusRes = commonService.contactUs(emailContactusReq, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contactusRes;
        }

        public GetClientDetailsForMobileResponse GetClientDetailsForMobile(string token)
        {
            GetClientDetailsForMobileResponse response = null;
            try

            {
                response = commonService.GetClientDetailsForMobile(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}
