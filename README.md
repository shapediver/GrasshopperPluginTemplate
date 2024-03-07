# Grasshopper and Rhino Plug-in Template
This repository contains a template for plug-ins to Grasshopper and [Rhino](https://www.rhino3d.com/). 
The template follows best practices we use at ShapeDiver. 

## Features

### Centralized versioning and metadata 

see [CommonVariables.csproj](CommonVariables.csproj)

The version of all assemblies built by the solution can be configured in a central place. 
The same principle is used for further metadata like plug-in authorship, and properties
of the [Package Manifest](https://developer.rhino3d.com/guides/yak/the-package-manifest/)
for the [Yak Package Manager](https://developer.rhino3d.com/guides/yak/). 


### Centralized nuget package versioning
see [Directory.Packages.props](Directory.Packages.props)

Version of nuget packages are configured in a central place for all projects. 

### Shared assembly between Grasshopper and Rhino plug-in

The setup includes two shared assemblies: 

  * [Shared](Shared) for shared code which does not depend on Rhino.
  * [SharedRhino](SharedRhino) for shared code depending on Rhino. 

### Setup for unit tests, including tests using Rhino.Inside
  
Two test projects are used for unit testing of the shared assemblies. Since [Rhino.Inside](https://github.com/mcneel/rhino.inside) this is very useful, 
because one can test and debug code depending on Rhino without starting Rhino. 

  * [TestShared](TestShared) tests for the assembly [Shared](Shared)  
  * [TestSharedRhino](TestSharedRhino) tests for the assembly [SharedRhino](SharedRhino)
  
How to use this? Start the _Test Explorer_ in Visual Studio. 
  
### Build scripts for Rhino 7 and 8, Windows and Mac

The solution includes separate build configurations for Rhino 7 and Rhino 8. Rhino 6 can easily be added.

The following batch scripts are available for building using a single click.

  * [BuildRhino7.bat](BuildRhino7.bat) build for Rhino 7 including yak package
  * [BuildRhino8.bat](BuildRhino8.bat) build for Rhino 8 including yak package
  * [BuildYakOnlyRhino7.bat](BuildYakOnlyRhino7.bat) build yak package for Rhino 7 (requires the plugins to be built separately beforehand)
  * [BuildYakOnlyRhino8.bat](BuildYakOnlyRhino8.bat) build yak package for Rhino 8 (requires the plugins to be built separately beforehand)

### Multi-targeting for Rhino 8

The solution is configured to build a multi-targeted yak package in case of Rhino 8 (.NET Framework 4.8, .NET 7 for Windows and Mac). 

Note: There is still a [bug related to this](https://discourse.mcneel.com/t/net-multi-targeting-for-yak-packages/166183/10?u=snabela) in yak for Rhino 8 SR 4, this should be fixed soon. 


## How to use this

Download the code or fork the repository. 
Please open GitHub issues or submit a PR in case you find a problem or have suggestions for improvement. 

Building the solution is supposed work out of the box in Visual Studio 2022. 
We still need to test and add instructions for building using Visual Studio Code on Mac. 

The following steps are important when starting your own plug-in from this: 

  * Review and adapt the variable values in [CommonVariables.csproj](CommonVariables.csproj).
    * Create a new Guid for the Grasshopper plug-in and replace `00000000-0000-0000-0000-000000000000`.
    * Create a new Guid for the Rhino plug-in and replace `00000000-0000-0000-0000-000000000000`.
    * Set your version number.
    * Adapt information about Author, Company, Copyright, Product
  * Review and adapt the variable values in [CommonVariables.bat](CommonVariables.bat).
    * Installation path of Visual Studio
    * Path to Yak package manager
  * In case you don't need a Rhino or Grasshopper plug-in, remove it from the solution.
  * Set Rhino plug-in metadata in [AssemblyInfo.cs](PluginRhino/Properties/AssemblyInfo.cs) (still need to implement to create this automatically).
  * Adapt the images in [PluginGrasshopper/EmbeddedResources](PluginGrasshopper/EmbeddedResources) and [PluginRhino/EmbeddedResources](PluginRhino/EmbeddedResources).


