using KTI_Testing__Mobile_.Models;
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
                    var client = new HttpClient();

                    string url = "http://temp" + username + "/" + password;

                    client.BaseAddress = new Uri(url);

                    HttpResponseMessage reponse = await client.GetAsync("");

                    if (reponse.IsSuccessStatusCode)
                    {
                        userinfo = await reponse.Content.ReadFromJsonAsync<UserInfo>();
                        return await Task.FromResult(userinfo);
                    }
                    else
                    {
                        return null;
                    }
                }
                else 
                {
                    return null;
                }
            
        }
    }
}
