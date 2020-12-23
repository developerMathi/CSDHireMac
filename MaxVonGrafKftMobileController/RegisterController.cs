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
    public class RegisterController
    {
        RegisterService registerservice;
        public RegisterController()
        {
            registerservice = new RegisterService();
        }

        public int registerUser(CustomerReview customer, string _token)
        {
            return registerservice.registerUser(customer, _token);
        }

        public RegistrationDBModel getRegistrationDBModel(int customerId, string _token)
        {
            return registerservice.getRegistrationDBModel(customerId, _token);
        }

        public List<CustomerReservationModel> getReservations(int customerId, string token)
        {
            List<CustomerReservationModel> reservationModels = null;
            try
            {
                reservationModels = registerservice.getReservations(customerId, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return reservationModels;
        }

        public List<CustomerAgreementModel> getAgreements(int customerId, string token)
        {
            List<CustomerAgreementModel> agreementModels = null;
            try
            {
                agreementModels = registerservice.getAgreements(customerId, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return agreementModels;
        }

        public CustomerReservationModel getReservation(int reservationId, string token)
        {
            CustomerReservationModel model = null;
            try
            {
                model = registerservice.getReservation(reservationId, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        public GetReservationByIDMobileResponse getReservationByID(GetReservationByIDMobileRequest reservationByIDMobileRequest, string token)
        {
            GetReservationByIDMobileResponse getReservationByID = null;
            try
            {
                getReservationByID = registerservice.getReservationByID(reservationByIDMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return getReservationByID;
        }

        public UpdateCustomerProfileDetailsMobileResponse updateUser(UpdateCustomerProfileDetailsMobileRequest profileDetailsMobileRequest, string token)
        {
            UpdateCustomerProfileDetailsMobileResponse response = null;

            try
            {
                response = registerservice.updateUser(profileDetailsMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public GetReservationAgreementMobileResponse getMobileRegistrationDBModel(GetReservationAgreementMobileRequest registrationDBModelRequest, string token)
        {
            GetReservationAgreementMobileResponse response = null;

            try
            {
                response = registerservice.getMobileRegistrationDBModel(registrationDBModelRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public UploadCustomerImageMobileResponse addCustomerImage(UploadCustomerImageMobileRequest imageMobileRequest, string _token)
        {
            UploadCustomerImageMobileResponse response = null;

            try
            {
                response = registerservice.addCustomerImage(imageMobileRequest, _token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
