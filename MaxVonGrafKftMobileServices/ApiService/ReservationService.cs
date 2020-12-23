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
    public class ReservationService
    {
        public List<MisChargeResult> getMisCharge(MisChargeFilter misChargeFilter, string token)
        {
            List<MisChargeResult> result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "MisCharges/Search");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(misChargeFilter);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<List<MisChargeResult>>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CancelReservationMobileResponse cancelReservation(CancelReservationMobileRequest cancelReservation, string token)
        {
            CancelReservationMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationMobile/CancelReservationMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(cancelReservation);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<CancelReservationMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetPromotionMobileResponse checkPromotion(GetPromotionMobileRequest promotionMobileRequest, string token)
        {
            GetPromotionMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "PromotionMobile/GetSearchPromotionMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(promotionMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetPromotionMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetTermsandConditionByTypeResponse getTermsAndConditions(GetTermsandConditionByTypeRequest termsandConditionByTypeRequest, string token)
        {
            GetTermsandConditionByTypeResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationConfigurationMobile/GetAllTermsAndConditionsByType");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(termsandConditionByTypeRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetTermsandConditionByTypeResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetStoreHoursMobileResponse getStoreHoursMobile(GetStoreHoursMobileRequest getStoreHoursMobileRequest, string token)
        {

            GetStoreHoursMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "StoreHoursMobile/GetStoreHourDetailsMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(getStoreHoursMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetStoreHoursMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public SearchAllCustomerResponse getCustomerDetails(SearchAllCustomerRequest searchAllCustomerRequest, string token)
        {
            SearchAllCustomerResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CustomerMobile/SearchAllCustomerMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(searchAllCustomerRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<SearchAllCustomerResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public UpdateReservationMobileResponse updateReservationMobile(UpdateReservationMobileRequest reservationMobileRequest, string token)
        {
            UpdateReservationMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationMobile/UpdateReservationMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(reservationMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<UpdateReservationMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public CreateReservationMobileResponse createReservationMobile(CreateReservationMobileRequest reservationMobileRequest, string token)
        {
            CreateReservationMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationMobile/CreateReservationMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(reservationMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<CreateReservationMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetCalculateSummaryMobileResponsecs getSummaryDetails(GetCalculateSummaryMobileRequest summaryMobileRequest, string token)
        {
            GetCalculateSummaryMobileResponsecs result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationConfigurationMobile/CalculateSummaryMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(summaryMobileRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetCalculateSummaryMobileResponsecs>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetMischargeSearchDetailsMobileResponse getMisChargeMobile(GetMischargeSearchDetailsMobileRequest misChargeRequest, string token)
        {
            GetMischargeSearchDetailsMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "MischargeMobile/GetAdditionalFeatureMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(misChargeRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetMischargeSearchDetailsMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetTaxMobileListResponse GetTaxMobileList(GetTaxMobileListRequest taxRequest, string token)
        {
            GetTaxMobileListResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "TaxMobile/GetSearchTaxMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(taxRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetTaxMobileListResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    

        public List<LocationTaxResult> getTax(TaxFilter taxFilter, string token)
        {
            List<LocationTaxResult> result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Tax/Search");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(taxFilter);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<List<LocationTaxResult>>(responseStream);
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
