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

            DataContextChanged +=
                (s, e) =>
                {
                    ViewModel = DataContext as ViewModels.MainPageViewModel;
                    System.Console.WriteLine("VM Changed");
                };
        }

        public object ViewModel
        {
            get { return (object)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        
        // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(object), typeof(MainPage), new PropertyMetadata(null));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
