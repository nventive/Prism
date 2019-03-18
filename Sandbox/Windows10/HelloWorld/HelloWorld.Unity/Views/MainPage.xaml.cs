using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Sample.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();

#if HAS_UNO // UNO TODO x:Bind eval sequence is different from UWP
            DataContextChanged +=
                (s, e) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ViewModel)));
#endif
        }

        ViewModels.MainPageViewModel ViewModel => DataContext as ViewModels.MainPageViewModel;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
