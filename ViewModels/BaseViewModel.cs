using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace KTI_Testing__Mobile_.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public bool _isBusy;
        [ObservableProperty]
        public string _title;
    }
}
