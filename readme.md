# Learn Couchbase Lite with dotnet and Maui 

In this learning path you will be reviewing an dotnet Application written in C# and Maui that uses the Couchbase Lite .NET SDK. You will learn how to get and insert documents using the key-value engine, query the database using the QueryBuilder engine or SQL++, and learn how to sync information between your mobile app and either a Couchbase Server using Sync Gateway or using peer-to-peer technology.

Full documentation can be found on the [Couchbase Developer Portal](https://developer.couchbase.com/)

## Prerequisites
To run this prebuilt project, you will need:
- Familiarity with building dotnet Application with <a target="_blank" rel="noopener noreferrer" href="https://dotnet.microsoft.com/en-us/apps/maui">Maui</a>.
- [Visual Studio or Visual Studio Code](https://visualstudio.microsoft.com/downloads/)
- dotnet version 7 or above installed and setup
- Android SDK installed and setup (> v.33.0.0)
- Android Build Tools (> v.33.0.0)
- Android device or emulator running API level 24 or above

### Installing Couchbase Lite Framework

- Nuget can be used to install the Couchbase Lite nuget package.  From the terminal in your main project directory, run the following command:

```bash 
dotnet add package Couchbase.Lite
```
 
An entry should be added to your CSPROJ file.

```bash
...
	<ItemGroup>
		<PackageReference Include="Couchbase.Lite" Version="3.0.8" />
	</ItemGroup>

```

For more information on installation, please see the [Couchbase Lite Documentation](https://docs.couchbase.com/couchbase-lite/current/csharp/gs-install.html).

## Demo Application 

### Overview

The demo application used in this learning path is based on auditing <a target="_blank" rel="noopener noreferrer" href="https://en.wikipedia.org/wiki/Inventory">inventory</a>  for a fictitious company.  Most companies have some inventory - from laptops to office supplies and from time to time must audit their stock.  For example, when a user's laptop breaks, they can send out a replacement from the inventory of spare laptops they have on hand. 

Users running the mobile app would log into the application to see the projects they are assigned to work on. Then, the user would look at the project to see which office location they need to travel to. Once at the site, they would inspect the number of items, tracking them in the mobile application.

### Architecture

The demo application uses <a target="_blank" rel="noopener noreferrer" href="https://dotnet.microsoft.com/en-us/learn/maui/architecture">application architecture</a> concepts in developing modern Maui applications recommended by the Maui development team.  

<a target="_blank" rel="noopener noreferrer" href="https://learn.microsoft.com/en-us/dotnet/architecture/maui/dependency-injection">Dependency injection</a> is handled using the built-in dotnet classes that are popular with the dotnet community.  <a target="_blank" rel="noopener noreferrer" href="https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection">Microsoft.Extensions.DependencyInjection</a> is used to set up the dependency injection container.  The container is used to set up the services that are used throughout the application.  The services are then injected into the various classes that need them.  The services are also injected into the ViewModels that are used to control the state of the application.

## Try it out

* Open src/Couchbase.Maui.sln using Visual Studio. 
* Build and run the project.
* Verify that you see the login screen.
