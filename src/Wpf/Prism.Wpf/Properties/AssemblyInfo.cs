using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
#if !HAS_WINUI
using System.Windows.Markup;
#endif

[assembly: ComVisible(false)]

#if !HAS_WINUI
[assembly: CLSCompliant(true)]

// -----  Legacy -----
[assembly: XmlnsDefinition("http://www.codeplex.com/prism", "Prism.Regions")]
[assembly: XmlnsDefinition("http://www.codeplex.com/prism", "Prism.Regions.Behaviors")]
[assembly: XmlnsDefinition("http://www.codeplex.com/prism", "Prism.Mvvm")]
[assembly: XmlnsDefinition("http://www.codeplex.com/prism", "Prism.Interactivity")]
// -----  Legacy -----

[assembly: XmlnsDefinition("http://prismlibrary.com/", "Prism.Regions")]
[assembly: XmlnsDefinition("http://prismlibrary.com/", "Prism.Regions.Behaviors")]
[assembly: XmlnsDefinition("http://prismlibrary.com/", "Prism.Mvvm")]
[assembly: XmlnsDefinition("http://prismlibrary.com/", "Prism.Interactivity")]
[assembly: XmlnsDefinition("http://prismlibrary.com/", "Prism.Services.Dialogs")]


#endif
