using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Prism
{
    internal static class DependencyObjectExtensions
    {
        public static bool CheckAccess(this DependencyObject instance)
#if __WASM__
            => true;
#else
            => instance.Dispatcher.HasThreadAccess;
#endif

        public static BindingExpression GetBinding(this FrameworkElement instance, DependencyProperty property)
            => instance.GetBindingExpression(property);
    }
}
