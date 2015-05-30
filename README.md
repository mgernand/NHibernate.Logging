NHibernate Logging Providers
============================
The current version **4.0.3** is available as [NuGet package](http://nuget.org/packages/NHibernate.Logging/).
This version is built against NHibernate 4.0.3 and Common.Logging 3.1.0.

Project Description
-------------------
NHibernate Logging Providers makes it possible to use your favourite logger with NHibernate. 
You no longer have to use log4net. The new NHibernate (since NH3) logging abstraction makes 
this possible. The provider is developed in C# using .NET 4.5.

Available Logging Providers
---------------------------
The current release contains log providers for the following logging frameworks.

* [Common.Logging 3.1.0](https://github.com/net-commons/common-logging)

Common.Logging 3.1.0 supports several other logging frameworks. So you can use
each of them with NHibernate via Common.Logging 3.1.0 abstraction.

Review the [NHibernate Wiki](http://nhforge.org/wikis/howtonh/using-nlog-via-common-logging-with-nhibernate.aspx) for additional informations. Please leave a comment if you 
like it or not. ;-)

NuGet available
---------------
The repository contains a *.nuspec file for creating a NuGet package since the last release. 
The file was created and contributed by [Matthew Ferreira](https://nuget.org/packages?q=Matthew%20Ferreira). 
Thanks again for the effort.

Getting Started
---------------
To use the Common.Logging 3.1.0 logging abstraction framework with NHibernate all you have 
to do is to copy the following Assemblies to you projects output directory:

* Common.Logging.dll
* Common.Logging.Core.dll
* NHibernate.Logging.CommonLogging.dll

Needless to say that you have to copy your loggers Assembly and the corresponding 
Common.Logging-Provider Assembly too. To enable the log provider you have to add the 
following lines to your Web.config or App.config:

```xml
<appSettings>
  <add key="nhibernate-logger" 
       value="NHibernate.Logging.CommonLogging.CommonLoggingLoggerFactory, NHibernate.Logging.CommonLogging"/>
</appSettings>
```
