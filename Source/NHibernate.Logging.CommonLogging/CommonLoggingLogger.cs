namespace NHibernate.Logging.CommonLogging
{
	using System;
	using Common.Logging;

	/// <summary>
	/// Implements the <see cref="INHibernateLogger"/> interface to allow the usage 
	/// of Common.Logging 3.4.1 with the NHibernate logging infrastructure.
	/// </summary>
	public class CommonLoggingLogger : INHibernateLogger
	{
		private readonly ILog logger;

		public CommonLoggingLogger(ILog logger)
		{
			this.logger = logger;
		}

		public bool IsEnabled(NHibernateLogLevel logLevel)
		{
			switch (logLevel)
			{
				case NHibernateLogLevel.Trace:
					return this.logger.IsTraceEnabled;
				case NHibernateLogLevel.Debug:
					return this.logger.IsDebugEnabled;
				case NHibernateLogLevel.Info:
					return this.logger.IsInfoEnabled;
				case NHibernateLogLevel.Warn:
					return this.logger.IsWarnEnabled;
				case NHibernateLogLevel.Error:
					return this.logger.IsErrorEnabled;
				case NHibernateLogLevel.Fatal:
					return this.logger.IsFatalEnabled;
				case NHibernateLogLevel.None:
					return true;
				default:
					return false;
			}
		}

		public void Log(NHibernateLogLevel logLevel, NHibernateLogValues state, Exception exception)
		{
			switch (logLevel)
			{
				case NHibernateLogLevel.Trace:
					this.logger.TraceFormat(state.Format, exception, state.Args);
					break;
				case NHibernateLogLevel.Debug:
					this.logger.DebugFormat(state.Format, exception, state.Args);
					break;
				case NHibernateLogLevel.Info:
					this.logger.InfoFormat(state.Format, exception, state.Args);
					break;
				case NHibernateLogLevel.Warn:
					this.logger.WarnFormat(state.Format, exception, state.Args);
					break;
				case NHibernateLogLevel.Error:
					this.logger.ErrorFormat(state.Format, exception, state.Args);
					break;
				case NHibernateLogLevel.Fatal:
					this.logger.FatalFormat(state.Format, exception, state.Args);
					break;
			}
		}
	}
}
