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
    public class ReservationController
    {
        ReservationService reservationservice;
        public ReservationController()
        {
            reservationservice = new ReservationService();
        }

        public List<MisChargeResult> getMisCharge(MisChargeFilter misChargeFilter, string token)
        {
            List<MisChargeResult> chargeResults = null;
            try
            {
                chargeResults = reservationservice.getMisCharge(misChargeFilter, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chargeResults;
        }

        public List<LocationTaxResult> getTax(TaxFilter taxFilter, string token)
        {
            List<LocationTaxResult> taxResults = null;
            try
            {
                taxResults = reservationservice.getTax(taxFilter, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return taxResults;
        }


        public CancelReservationMobileResponse cancelReservation(CancelReservationMobileRequest cancelReservation, string token)
        {
            CancelReservationMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.cancelReservation(cancelReservation, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetTaxMobileListResponse GetTaxMobileList(GetTaxMobileListRequest taxRequest, string token)
        {
            GetTaxMobileListResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.GetTaxMobileList(taxRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetMischargeSearchDetailsMobileResponse getMisChargeMobile(GetMischargeSearchDetailsMobileRequest misChargeRequest, string token)
        {
            GetMischargeSearchDetailsMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.getMisChargeMobile(misChargeRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetPromotionMobileResponse checkPromotion(GetPromotionMobileRequest promotionMobileRequest, string token)
        {
            GetPromotionMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.checkPromotion(promotionMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetCalculateSummaryMobileResponsecs getSummaryDetails(GetCalculateSummaryMobileRequest summaryMobileRequest, string token)
        {
            GetCalculateSummaryMobileResponsecs mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.getSummaryDetails(summaryMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public CreateReservationMobileResponse createReservationMobile(CreateReservationMobileRequest reservationMobileRequest, string token)
        {
            CreateReservationMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.createReservationMobile(reservationMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetTermsandConditionByTypeResponse getTermsAndConditions(GetTermsandConditionByTypeRequest termsandConditionByTypeRequest, string token)
        {
            GetTermsandConditionByTypeResponse Response = null;
            try
            {
                Response = reservationservice.getTermsAndConditions(termsandConditionByTypeRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Response;
        }

        public UpdateReservationMobileResponse updateReservationMobile(UpdateReservationMobileRequest reservationMobileRequest, string token)
        {
            UpdateReservationMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.updateReservationMobile(reservationMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public SearchAllCustomerResponse getCustomerDetails(SearchAllCustomerRequest searchAllCustomerRequest, string token)
        {
            SearchAllCustomerResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.getCustomerDetails(searchAllCustomerRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }

        public GetStoreHoursMobileResponse getStoreHoursMobile(GetStoreHoursMobileRequest getStoreHoursMobileRequest, string _token)
        {
            GetStoreHoursMobileResponse mobileResponse = null;
            try
            {
                mobileResponse = reservationservice.getStoreHoursMobile(getStoreHoursMobileRequest, _token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mobileResponse;
        }
    }
}
