namespace NHibernate.Logging.CommonLogging
{
	using System;
	using Common.Logging;

	/// <summary>
	/// <para>Implementation of the <see cref="INHibernateLoggerFactory"/> interface 
	/// to allow the usage of Common.Logging 3.4.1 with the NHibernate 
	/// logging infrastructure.</para>
	/// <para>To use this logger factory with NHibernate add the following
	/// to your App/Web.config:</para>
	/// 
	/// &lt;appSettings&gt;
	///	&lt;add key="nhibernate-logger" value="NHibernate.Logging.CommonLogging.CommonLoggingLoggerFactory, NHibernate.Logging.CommonLogging"/&gt;
	/// &lt;/appSettings&gt;
	/// </summary>
	public sealed class CommonLoggingLoggerFactory : INHibernateLoggerFactory
	{
		public INHibernateLogger LoggerFor(string keyName)
		{
			return new CommonLoggingLogger(LogManager.GetLogger(keyName));
		}

		public INHibernateLogger LoggerFor(Type type)
		{
			return new CommonLoggingLogger(LogManager.GetLogger(type));
		}
	}
}
