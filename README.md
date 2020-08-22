# Prism for the Uno Platform and WinUI 2

This port allows for [Uno-based](https://github.com/unoplatform/Uno) apps to use [Prism](https://github.com/PrismLibrary/Prism) on Windows, iOS, Android and WebAssembly, as well as WinUI 2 based applications.

The following packages are available:
- [Uno.Prism.Uno](https://www.nuget.org/packages/Uno.Prism.Uno)
- [Uno.Prism.Unity.Uno](https://www.nuget.org/packages/Uno.Prism.Unity.Uno)
- [Uno.Prism.DryIoc.Uno](https://www.nuget.org/packages/Uno.Prism.DryIoc.Uno)

These package depend on the official [Prism.Core](https://www.nuget.org/packages/Prism.Core) and are named `Uno.*.Uno` 
to avoid future conflicts with a possible intregration of those packages in the Prism repository.

This library is currently a port of the WPF feature set. If you need to get support for Frame control type navigation, Pull Requests are welcome!

## How to use Uno with Prism

To start a new Uno project with Prism support, take a look at [this](https://github.com/unoplatform/uno.Prism/tree/uno/Sandbox/Windows10/HelloWorld) project.  

## Contributing to Uno.Prism

The main solution to use is [PrismLibrary_Uno.sln](PrismLibrary_Uno.sln) with the included samples applications.
### E2E Build Status

# Prism

Prism is a framework for building loosely coupled, maintainable, and testable XAML applications in WPF, and Xamarin Forms. Separate releases are available for each platform and those will be developed on independent timelines. Prism provides an implementation of a collection of design patterns that are helpful in writing well-structured and maintainable XAML applications, including MVVM, dependency injection, commands, EventAggregator, and others. Prism's core functionality is a shared code base supported in .NET Standard 2.0, .Net Core 3, and .NET Framework 4.5. Those things that need to be platform specific are implemented in the respective libraries for the target platform. Prism also provides great integration of these patterns with the target platform. For example, Prism for Xamarin Forms allows you to use an abstraction for navigation that is unit testable, but that layers on top of the platform concepts and APIs for navigation so that you can fully leverage what the platform itself has to offer, but done in the MVVM way.

For more information, [visit the official Prism repository](https://github.com/PrismLibrary/Prism).
