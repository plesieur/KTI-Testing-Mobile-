﻿using MauiApp2;
using Microsoft.Toolkit.Mvvm.Input;

namespace KTI_Testing__Mobile_.Resources.viewModels
{
    public partial class AppShellViewMode : BaseViewModel
    {
        [ICommand]

        async void SignOut()
        {
            if (Preferences.ContainsKey("UserInfo")) 
            {
                Preferences.Remove(nameof(App.UserInfo));
            }
            await Shell.Current.GoToAsync("//MauiLoginPage");
        }
    }
}
