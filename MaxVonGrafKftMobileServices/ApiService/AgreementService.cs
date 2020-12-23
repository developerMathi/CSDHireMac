using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Newtonsoft.Json;

namespace MaxVonGrafKftMobileServices.ApiService
{
    public class AgreementService
    {
        public GetAgreementByAgreementIdMobileResponse getAgreement(GetAgreementByAgreementIdMobileRequest agreementByAgreementIdMobileRequest, string token)
        {
            GetAgreementByAgreementIdMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/getAgreementByAgreementId");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(agreementByAgreementIdMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetAgreementByAgreementIdMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public AddAgreementSignMobileResponse saveSignature(AddAgreementSignMobileRequest signMobileRequest, string token)
        {
            AddAgreementSignMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/SaveAgreementSignMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(signMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<AddAgreementSignMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public LoadvehicleViewImagesResponse loadvehicleViewImages(LoadvehicleViewImagesReq loadvehicleViewImagesReq, string token)
        {
            LoadvehicleViewImagesResponse result = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/LoadvehicleViewImages");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(loadvehicleViewImagesReq);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<LoadvehicleViewImagesResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public LoadvehicleViewImagesResponse loadvehicleViewImagesCheckIn(LoadvehicleViewImagesReq loadvehicleViewImagesReq, string token)
        {
            LoadvehicleViewImagesResponse result = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/LoadvehicleViewImagesCheckin");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(loadvehicleViewImagesReq);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<LoadvehicleViewImagesResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public AddfourTypeVehicleImagesResponse addfourTypeVehicleImages(VehicleImage vehicleImage, string token)
        {
            AddfourTypeVehicleImagesResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/SaveVehicleViewImages");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(vehicleImage);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<AddfourTypeVehicleImagesResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ReloadSignatureImageURLMobileResponse getDamageSignature(ReloadSignatureImageURLMobileRequest imageURLMobileRequest, string token)
        {
            ReloadSignatureImageURLMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/ReloadSignatureImageURLMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(imageURLMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<ReloadSignatureImageURLMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public AddDamageSignMobileResponse saveDamageSignature(AddDamageSignMobileRequest signMobileRequest, string token)
        {
            AddDamageSignMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/SaveDamageSign");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(signMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<AddDamageSignMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
