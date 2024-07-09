# NHibernate Logging Providers

The current version **5.5.2** is available as [NuGet package](http://nuget.org/packages/NHibernate.Logging/).
This version is built against NHibernate 5.5.2 and Common.Logging 3.4.1.

NHibernate Logging Providers makes it possible to use your favourite logger with NHibernate. 
You no longer have to use log4net. The new NHibernate (since NH3) logging abstraction makes 
this possible. The provider is developed .NET Standard 2.0.

## Available Logging Providers

The current release contains log providers for the following logging frameworks.

* [Common.Logging 3.4.1](https://github.com/net-commons/common-logging)

Common.Logging 3.4.1 supports several other logging frameworks. So you can use
each of them with NHibernate via Common.Logging 3.4.1 abstraction.

Review the [NHibernate Wiki](http://nhibernate.info/doc/howto/various/using-nlog-via-common-logging-with-nhibernate.html) for additional informations. Please leave a comment if you 
like it or not. 😉

## NuGet package

The repository contains a *.nuspec file for creating a NuGet package since the last release. 
The file was created and contributed by [Matthew Ferreira](https://nuget.org/packages?q=Matthew%20Ferreira). 
Thanks again for the effort.

## Getting Started

Add the [NuGet package](http://nuget.org/packages/NHibernate.Logging/) to your project. Install
all nessessary Common.Logging packages for the logging provider you want to use.

To enable the log provider you have to add the following lines to your Web.config or App.config:

```xml
<appSettings>
  <add key="nhibernate-logger" 
       value="NHibernate.Logging.CommonLogging.CommonLoggingLoggerFactory, NHibernate.Logging.CommonLogging"/>
</appSettings>
```
