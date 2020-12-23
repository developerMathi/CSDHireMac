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
    public class AgreementController
    {
        AgreementService agreementService;
        public AgreementController()
        {
            agreementService = new AgreementService();
        }

        public GetAgreementByCustomerIdMobileResponse getAgreementMobile(getAgreementByCustomerIdMobileRequest getAgreementByCustomerIdMobileRequest, string token)
        {
            throw new NotImplementedException();
        }

        public GetAgreementByAgreementIdMobileResponse getAgreement(GetAgreementByAgreementIdMobileRequest agreementByAgreementIdMobileRequest, string token)
        {
            GetAgreementByAgreementIdMobileResponse response = null;
            try
            {
                response = agreementService.getAgreement(agreementByAgreementIdMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public AddAgreementSignMobileResponse saveSignature(AddAgreementSignMobileRequest signMobileRequest, string token)
        {
            AddAgreementSignMobileResponse response = null;
            try
            {
                response = agreementService.saveSignature(signMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public AddDamageSignMobileResponse saveDamageSignature(AddDamageSignMobileRequest signMobileRequest, string token)
        {
            AddDamageSignMobileResponse response = null;
            try
            {
                response = agreementService.saveDamageSignature(signMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public ReloadSignatureImageURLMobileResponse getDamageSignature(ReloadSignatureImageURLMobileRequest imageURLMobileRequest, string token)
        {
            ReloadSignatureImageURLMobileResponse response = null;
            try
            {
                response = agreementService.getDamageSignature(imageURLMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public AddfourTypeVehicleImagesResponse addfourTypeVehicleImages(VehicleImage vehicleImage, string token)
        {
            AddfourTypeVehicleImagesResponse response = null;
            try
            {
                response = agreementService.addfourTypeVehicleImages(vehicleImage, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public LoadvehicleViewImagesResponse loadvehicleViewImages(LoadvehicleViewImagesReq loadvehicleViewImagesReq, string token)
        {
            LoadvehicleViewImagesResponse response = null;
            try
            {
                response = agreementService.loadvehicleViewImages(loadvehicleViewImagesReq, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public LoadvehicleViewImagesResponse loadvehicleViewImagesCheckIn(LoadvehicleViewImagesReq loadvehicleViewImagesReq, string token)
        {
            LoadvehicleViewImagesResponse response = null;
            try
            {
                response = agreementService.loadvehicleViewImagesCheckIn(loadvehicleViewImagesReq, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}
