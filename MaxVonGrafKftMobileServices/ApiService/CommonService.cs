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
    public class CommonService
    {
        public GetAllCountryForMobileResponse GetAllCountry(string access_token)
        {
            GetAllCountryForMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CommonMobile/GetAllCountryForMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");




                    var response = client.PostAsync(client.BaseAddress, httpContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetAllCountryForMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public GetClientDetailsForMobileResponse GetClientDetailsForMobile(string token)
        {
            GetClientDetailsForMobileResponse result = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CommonMobile/GetClientDetailsForMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");




                    var response = client.PostAsync(client.BaseAddress, httpContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        result = JsonConvert.DeserializeObject<GetClientDetailsForMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public EmailContactusRes contactUs(EmailContactusReq emailContactusReq, string token)
        {
            EmailContactusRes resp = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CommonMobile/Emailcontactus");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(emailContactusReq);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<EmailContactusRes>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public GetAllLocationForClientIDForMobileResponse getAllLocationsByClientId(GetAllLocationForClientIDForMobileRequest locationRequest, string token)
        {
            GetAllLocationForClientIDForMobileResponse resp = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CommonMobile/GetAllLocationForClientIDForMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(locationRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<GetAllLocationForClientIDForMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public List<LocationModel> GetAllLocation(string token)
        {
            List<LocationModel> locations = null;
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Location/GetAll");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    

                    var response = client.GetAsync(client.BaseAddress).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        locations = JsonConvert.DeserializeObject<List<LocationModel>>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return locations;
        }

        public GetAllStateForMobileResponse GetAllStateByCountryID(GetAllStateForMobileRequest stateRequest, string token)
        {
            GetAllStateForMobileResponse resp = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "CommonMobile/GetAllStateByCountryIDForMobile");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(stateRequest);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        resp = JsonConvert.DeserializeObject<GetAllStateForMobileResponse>(responseStream);
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }
    }
}
