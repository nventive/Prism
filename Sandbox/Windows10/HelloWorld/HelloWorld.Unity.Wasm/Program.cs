using Microsoft.Extensions.Logging;
using System;
using Uno.Extensions;
using Windows.UI.Xaml;

namespace Sample
{
    public class Program
    {
        private static App _app;

        static int Main(string[] args)
        {
#if DEBUG
            ConfigureFilters(LogExtensionPoint.AmbientLoggerFactory);
#endif

            Windows.UI.Xaml.Application.Start(_ => _app = new App());

            return 0;
        }

        static void ConfigureFilters(ILoggerFactory factory)
        {
            factory
                .WithFilter(new FilterLoggerSettings
                    {
                        { "Uno", LogLevel.Warning },
                        { "Windows", LogLevel.Warning },
						// { "Uno.Foundation.WebAssemblyRuntime", LogLevel.Debug },
						
						// Generic Xaml events
						//{ "Windows.UI.Xaml", LogLevel.Debug },
						// { "Windows.UI.Xaml.Shapes", LogLevel.Debug },
						//{ "Windows.UI.Xaml.VisualStateGroup", LogLevel.Debug },
						//{ "Windows.UI.Xaml.StateTriggerBase", LogLevel.Debug },
						// { "Windows.UI.Xaml.UIElement", LogLevel.Debug },
						// { "Windows.UI.Xaml.Setter", LogLevel.Debug },
						   
						// Layouter specific messages
						// { "Windows.UI.Xaml.Controls", LogLevel.Debug },
						//{ "Windows.UI.Xaml.Controls.Layouter", LogLevel.Debug },
						//{ "Windows.UI.Xaml.Controls.Panel", LogLevel.Debug },
						// { "Windows.Storage", LogLevel.Debug },
						//{ "Windows.UI.Xaml.Controls.VirtualizingPanelLayout", LogLevel.Debug },
						//{ "Windows.UI.Xaml.DependencyObjectStore", LogLevel.Debug },
						   
						// Binding related messages
						// { "Windows.UI.Xaml.Data", LogLevel.Debug },
						// { "Windows.UI.Xaml.Data", LogLevel.Debug },
						   
						//  Binder memory references tracking
						// { "ReferenceHolder", LogLevel.Debug },
					}
                )
                .AddConsole(LogLevel.Debug);
        }

    }
}
