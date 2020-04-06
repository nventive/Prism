using Prism.Services.Dialogs;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HelloUnoWorld.Dialogs
{
    /// <summary>
    /// Interaction logic for AnotherDialogWindow.xaml
    /// </summary>
    public partial class AnotherContentDialog : ContentDialog, IContentDialog
    {
        public AnotherContentDialog()
        {
            InitializeComponent();
        }

        public IDialogResult Result { get; set; }

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
