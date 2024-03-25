using HtmlAgilityPack;
using KTI_Testing__Mobile_.Models;

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
                Uri uri = new Uri("http://10.0.2.2:3000/login");
                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("email", username),
                    new KeyValuePair<string, string>("password", password),
                });

                var myHttpClient = new HttpClient();
                var response = await myHttpClient.PostAsync(uri.ToString(), formContent);
                var stringContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(stringContent);

                HtmlDocument htmlSnippet = new HtmlDocument();
                htmlSnippet.LoadHtml(stringContent);

                List<string> errors = new List<string>();

                foreach (HtmlNode link in htmlSnippet.DocumentNode.SelectNodes("//error"))
                {
                    string att = link.InnerHtml;
                    errors.Add(att.Trim());
                }

                if (errors[1] == "400")
                {
                    Console.WriteLine("Errored: " + errors[0]);
                }
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}
