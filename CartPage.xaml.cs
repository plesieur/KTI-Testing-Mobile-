﻿using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;


namespace MauiApp2
{
    public partial class CartPage : ContentPage
    {

        public CartPage()
        {
            InitializeComponent();
        }

        private void GoCancle_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "are you sure?";
        }
        private void Gosubmit_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "are you sure?";
        }
        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}