namespace Prism.Services.Dialogs
{
    internal static class IDialogWindowExtensions
    {
#if !HAS_WINUI
        internal static IDialogAware GetDialogViewModel(this IDialogWindow dialogWindow)
        {
            return (IDialogAware)dialogWindow.DataContext;
        }
#endif
    }
}
