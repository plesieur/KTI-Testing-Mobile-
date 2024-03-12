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
    }
}
