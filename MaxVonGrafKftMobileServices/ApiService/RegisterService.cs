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
    public class RegisterService
    {
        public int registerUser(CustomerReview customer, string _token)
        {
            int customerId = 0;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/RegisterCustomer");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                    var myContent = JsonConvert.SerializeObject(customer);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        customerId = JsonConvert.DeserializeObject<int>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerId;
        }

        public List<CustomerAgreementModel> getAgreements(int customerId, string token)
        {
            List<CustomerAgreementModel> agreementModels = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/getAgreements");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var url = string.Format(
                    client.BaseAddress +
                    "?customerId=" +
                    customerId);

                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        agreementModels = JsonConvert.DeserializeObject<List<CustomerAgreementModel>>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return agreementModels;
        }

        public UpdateCustomerProfileDetailsMobileResponse updateUser(UpdateCustomerProfileDetailsMobileRequest profileDetailsMobileRequest, string token)
        {
            UpdateCustomerProfileDetailsMobileResponse resp = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CustomerMobile/Update");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(profileDetailsMobileRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<UpdateCustomerProfileDetailsMobileResponse>(responseStream);
                    }
                    else
                    {
                        ApiMessage mes = new ApiMessage();

                        mes.ErrorCode = response.StatusCode.ToString();
                        mes.ErrorMessage = response.ReasonPhrase.ToString();
                        mes.Status = response.IsSuccessStatusCode.ToString();
                        resp.message = mes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public UploadCustomerImageMobileResponse addCustomerImage(UploadCustomerImageMobileRequest imageMobileRequest, string token)
        {
            UploadCustomerImageMobileResponse resp = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CustomerMobile/UploadImage");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(imageMobileRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<UploadCustomerImageMobileResponse>(responseStream);
                    }
                    else
                    {
                        ApiMessage mes = new ApiMessage();

                        mes.ErrorCode = response.StatusCode.ToString();
                        mes.ErrorMessage = response.ReasonPhrase.ToString();
                        mes.Status = response.IsSuccessStatusCode.ToString();
                        resp.message = mes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public GetReservationAgreementMobileResponse getMobileRegistrationDBModel(GetReservationAgreementMobileRequest registrationDBModelRequest, string token)
        {
            GetReservationAgreementMobileResponse resp = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "AgreementMobile/getRegistrationDBModel");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(registrationDBModelRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<GetReservationAgreementMobileResponse>(responseStream);
                    }
                    else
                    {
                        ApiMessage mes = new ApiMessage();

                        mes.ErrorCode = response.StatusCode.ToString();
                        mes.ErrorMessage = response.ReasonPhrase.ToString();
                        mes.Status = response.IsSuccessStatusCode.ToString();
                        resp.message = mes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public GetReservationByIDMobileResponse getReservationByID(GetReservationByIDMobileRequest reservationByIDMobileRequest, string token)
        {
            GetReservationByIDMobileResponse resp = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "ReservationMobile/GetReservationByIDMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(reservationByIDMobileRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<GetReservationByIDMobileResponse>(responseStream);
                    }
                    else
                    {
                        ApiMessage mes = new ApiMessage();

                        mes.ErrorCode = response.StatusCode.ToString();
                        mes.ErrorMessage = response.ReasonPhrase.ToString();
                        mes.Status = response.IsSuccessStatusCode.ToString();
                        resp.message = mes;


                    }


                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public CustomerReservationModel getReservation(int reservationId, string token)
        {
            CustomerReservationModel reservationModel = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/getReservationbyId");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var url = string.Format(
                    client.BaseAddress +
                    "?reservationId=" +
                    reservationId);

                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        reservationModel = JsonConvert.DeserializeObject<CustomerReservationModel>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reservationModel;
        }

        public List<CustomerReservationModel> getReservations(int customerId, string token)
        {
            List<CustomerReservationModel> reservationModels = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/getReservations");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var url = string.Format(
                    client.BaseAddress +
                    "?customerId=" +
                    customerId);

                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        reservationModels = JsonConvert.DeserializeObject<List<CustomerReservationModel>>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reservationModels;
        }

        public RegistrationDBModel getRegistrationDBModel(int customerId, string token)
        {
            RegistrationDBModel registrationDB = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/getRegistrationDBModel");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    
                    var url = string.Format(
                    client.BaseAddress +
                    "?customerId=" +
                    customerId);

                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        registrationDB = JsonConvert.DeserializeObject<RegistrationDBModel>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registrationDB;
        }
    }
}
