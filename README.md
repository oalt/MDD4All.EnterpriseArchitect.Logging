# MDD4All.EnterpriseArchitect.Logging

![Nuget Package Build](https://github.com/oalt/MDD4All.EnterpriseArchitect.Logging/workflows/Nuget%20Package%20Build/badge.svg)

[Nlog](https://nlog-project.org/) logging for Sparx Enterprise Architect output window.

# Usage
* Add the nuget package to your Enterprise Architect Plugin code project
* Initialize the logging provider in the `EA_FileOpen` event handler. This will write all Nlog 
logging messages into the Enterprise Architect output window tab with your given name (e.g. `My Plugin Name`).
```C#
using MDD4All.EnterpriseArchitect.Logging;

...

public void EA_FileOpen(EA.Repository repository)
{
     EaPluginNlogConfigurator.InitializePluginLogging(repository, "My Plugin Name");
     
     ...
}
```
