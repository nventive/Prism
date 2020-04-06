using Prism.Services.Dialogs;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HelloUnoWorld.Dialogs
{
    /// <summary>
    /// Interaction logic for CustomDialogWindow.xaml
    /// </summary>
    public partial class CustomContentDialog : ContentDialog, IContentDialog
    {
        public CustomContentDialog()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get ; set; }

        event RoutedEventHandler IContentDialog.Loaded
        {
            add => Loaded += value;
            remove => Loaded -= value;
        }

        event TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> IContentDialog.Closing
        {
            add => Closing += value;
            remove => Closing -= value;
        }

        event TypedEventHandler<ContentDialog, ContentDialogClosedEventArgs> IContentDialog.Closed
        {
            add => Closed += value;
            remove => Closed -= value;
        }
    }
}
