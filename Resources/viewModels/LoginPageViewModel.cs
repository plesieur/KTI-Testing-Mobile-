using KTI_Testing__Mobile_.Models;
using KTI_Testing__Mobile_.NewFolder;
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
                
                Preferences.Set("UserInfo", userDetails);

                App.UserInfo = userInfo;
                if (userInfo.Error == null) 
                {
                    await Shell.Current.GoToAsync("//MainPage");
                }
                else
                {
                    // throw error
                    Console.WriteLine(userInfo.Error);
                    Preferences.Remove(nameof(App.UserInfo));
                    await App.Current.MainPage.DisplayAlert("KTI Inventory", userInfo.Error, "Ok");
                }              
            }
            else
            {
                Console.WriteLine("EMPTYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
            }
        }
    }
}
