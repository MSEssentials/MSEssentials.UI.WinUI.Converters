# MSEssentials.UI.WinUI.Converters

### Set of helpers, class extensions, UI controls used in my other C# projects

MSEssentials is package of useful classes, helpers, extensions and UI controls, I use in my C# projects. UI.WinUI.Converters subpackage contains XAML value converters for WinUI applications.

---

## NuGet registry status

| Subpackage                           | Status                                                                                                                                                                                                            |
|--------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **MSEssentials.UI.WinUI.Converters** | [![NuGet version (MSEssentials.UI.WinUI.Converters)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Converters.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Converters/)    |
| MSEssentials.Extensions             | [![NuGet version (MSEssentials.Extensions)](https://img.shields.io/nuget/v/MSEssentials.Extensions.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.Extensions/)                            |
| MSEssentials.AspNetCore.Attributes             | [![NuGet version (MSEssentials.AspNetCore.Attributes)](https://img.shields.io/nuget/v/MSEssentials.AspNetCore.Attributes.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.AspNetCore.Attributes/)                            |
| MSEssentials.UI.Common.MVVM                   | [![NuGet version (MSEssentials.UI.Common.MVVM)](https://img.shields.io/nuget/v/MSEssentials.UI.Common.MVVM.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.Common.MVVM/)                                              |
| MSEssentials.UI.Common.Converters              | [![NuGet version (MSEssentials.UI.Common.Converters)](https://img.shields.io/nuget/v/MSEssentials.UI.Common.Converters.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.Common.Converters/)                               |
| MSEssentials.UI.WinUI.Behaviors    | [![NuGet version (MSEssentials.UI.WinUI.Behaviors)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Behaviors.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Behaviors/) |
| MSEssentials.UI.WinUI.Controls      | [![NuGet version (MSEssentials.UI.WinUI.Controls)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Controls.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Controls/)       |

## Features

- **ObjectToIntConverter** - converts any object to int (e.g. enums)
- **ObjectToStringConverter** - converts any object to string

## Dependencies

Dependencies should be installed automatically with this package

- Microsoft.WindowsAppSDK 1.4.240211001
- MSEssentials.UI.Common.Converters

## Installation and usage

You can download package from official NuGet registry or .nupkg file itself from Releases tab.

**CLI:**

```
dotnet add package MSEssentials.UI.WinUI.Converters
```

**Package reference in .csproj file:**

```
<PackageReference Include="MSEssentials.UI.WinUI.Converters" Version="<version>" />
```

## Attribution and contribution

This project is open source on MIT License, so you can just copy and upload again to your repository. But according to the license, you must include information about the original author. You can find license [here](https://repos.mateuszskoczek.com/MSEssentials/MSEssentials.UI.WinUI.Converters/src/branch/main/LICENSE).

However, the preferred way to contribute would be to propose improvements in a pull request, through issues, or through other means of communication.

**Other sources:**

- Icon by [Icons8](icons8.com)