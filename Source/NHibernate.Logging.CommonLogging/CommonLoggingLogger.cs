/**
 * Licensed under the LGPL. See License.txt
 * The software is provided AS IS.
 * 
 * Copyright © Matthias Gernand 2010
 * nhlogging.codeplex.com
 * 
 * Please keep this header intact if you use this code.
 */
namespace NHibernate.Logging.CommonLogging
{
	using System;
	using Common.Logging;

	/// <summary>
	/// Implements the <see cref="IInternalLogger"/> interface to allow the usage 
	/// of Common.Logging 2.0 with the NHibernate logging infrastructure.
	/// </summary>
	public class CommonLoggingLogger : IInternalLogger
	{
		private readonly ILog logger;

		public CommonLoggingLogger(ILog logger)
		{
			this.logger = logger;
		}

		public void Error(object message)
		{
			this.logger.Error(message);
		}

		public void Error(object message, Exception exception)
		{
			this.logger.Error(message, exception);
		}

		public void ErrorFormat(string format, params object[] args)
		{
			this.logger.ErrorFormat(format, args);
		}

		public void Fatal(object message)
		{
			this.logger.Fatal(message);
		}

		public void Fatal(object message, Exception exception)
		{
			this.logger.Fatal(message, exception);
		}

		// Note: No FatalFormat() in ILogger-Interface available.
		/*public void FatalFormat(string format, params object[] args)
		{
			this.logger.FatalFormat(format, args);
		}*/

		public void Debug(object message)
		{
			this.logger.Debug(message);
		}

		public void Debug(object message, Exception exception)
		{
			this.logger.Debug(message, exception);
		}

		public void DebugFormat(string format, params object[] args)
		{
			this.logger.DebugFormat(format, args);
		}

		public void Info(object message)
		{
			this.logger.Info(message);
		}

		public void Info(object message, Exception exception)
		{
			this.logger.Info(message, exception);
		}

		public void InfoFormat(string format, params object[] args)
		{
			this.logger.InfoFormat(format, args);
		}

		public void Warn(object message)
		{
			this.logger.Warn(message);
		}

		public void Warn(object message, Exception exception)
		{
			this.logger.Warn(message, exception);
		}

		public void WarnFormat(string format, params object[] args)
		{
			this.logger.WarnFormat(format, args);
		}

		public bool IsErrorEnabled
		{
			get { return this.logger.IsErrorEnabled; }
		}

		public bool IsFatalEnabled
		{
			get { return this.logger.IsFatalEnabled; }
		}

		public bool IsDebugEnabled
		{
			get { return this.logger.IsDebugEnabled; }
		}

		public bool IsInfoEnabled
		{
			get { return this.logger.IsInfoEnabled; }
		}

		public bool IsWarnEnabled
		{
			get { return this.logger.IsWarnEnabled; }
		}
	}
}
