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
    public class LoginService
    {
        public GetClientSecretTokenResponse GetClientSecretToken(GetClientSecretTokenRequest getClientSecretTokenRequest)
        {
            GetClientSecretTokenResponse tokenResponse = new GetClientSecretTokenResponse();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Login/GetClientSecretToken");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var myContent = JsonConvert.SerializeObject(getClientSecretTokenRequest);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        tokenResponse = JsonConvert.DeserializeObject<GetClientSecretTokenResponse>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tokenResponse;
        }

        public CutomerAuthContext CheckLogin(CustomerLogin loginCustomer,string token)
        {
            CutomerAuthContext authContext = new CutomerAuthContext();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "Registration/RegistrationLogin");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var myContent = JsonConvert.SerializeObject(loginCustomer);
                    var buffer = Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync(client.BaseAddress, byteContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        authContext = JsonConvert.DeserializeObject<CutomerAuthContext>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return authContext;
        }

        public ApiToken GetAccessToken(GetAccessTokenRequest tokenRequest)
        {
            ApiToken _token = new ApiToken();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConstantData.ApiURL.ToString() + "api/token");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var body = new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("grant_type", "client_credentials"),
                            new KeyValuePair<string, string>("client_id", tokenRequest.client_id),
                            new KeyValuePair<string, string>("client_secret", tokenRequest.client_secret)
                        };
                    var content = new FormUrlEncodedContent(body);
                    var response = client.PostAsync(client.BaseAddress, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseStream = response.Content.ReadAsStringAsync().Result;
                        _token = JsonConvert.DeserializeObject<ApiToken>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _token;
        }
    }
}
