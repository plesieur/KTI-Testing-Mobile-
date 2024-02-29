using KTI_Testing__Mobile_.Models;
using KTI_Testing__Mobile_.NewFolder;
using KTI_Testing__Mobile_.NewFolder1;
using MauiApp2;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KTI_Testing__Mobile_.Resources.viewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        readonly ILoginRepos loginRepos = new LoginServices();

        [ICommand]

        public async void Login() 
        {
            if(!string.IsNullOrEmpty(UserName)&& !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepos.Login(UserName, Password);

                if (Preferences.ContainsKey(nameof(App.UserInfo))) 
                {
                    Preferences.Remove(nameof(App.UserInfo));
                }

                string userDetails = JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo = userInfo;

                AppShell.Current.FlyoutHeader = new NewContent1();


                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
        }
    }
}
