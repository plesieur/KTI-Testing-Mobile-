using KTI_Testing__Mobile_.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace KTI_Testing__Mobile_.NewFolder
{
    public class LoginServices : ILoginRepos
    {
        public async Task<UserInfo> Login(string username, string password)
        {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userinfo = new UserInfo();

                    using var client = new HttpClient();
                    Uri uri = new Uri("http://10.0.2.2:3000/test2");
                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("id", "john"),
                    });

                    var myHttpClient = new HttpClient();
                    var response = await myHttpClient.PostAsync(uri.ToString(), formContent);
                }   
                else 
                {
                    return null;
                }
            return null;
            
        }
        private static T MakeRequest<T>(string _apiBaseUri, string httpMethod, string route, Dictionary<string, string> postParams = null)
        {
            using (var client = new HttpClient())
            {
                HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{_apiBaseUri}/{route}");

                if (postParams != null)
                    requestMessage.Content = new FormUrlEncodedContent(postParams);   // This is where your content gets added to the request body


                HttpResponseMessage response = client.SendAsync(requestMessage).Result;

                string apiResponse = response.Content.ReadAsStringAsync().Result;
                try
                {
                    // Attempt to deserialise the reponse to the desired type, otherwise throw an expetion with the response from the api.
                    if (apiResponse != "")
                        return JsonConvert.DeserializeObject<T>(apiResponse);
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    throw new Exception($"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}");
                }
            }
        }
    }
}
