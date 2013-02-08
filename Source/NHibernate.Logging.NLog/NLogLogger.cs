/**
 * Licensed under the LGPL. See License.txt
 * The software is provided AS IS.
 * 
 * Copyright © Matthias Gernand 2010 - 2013
 * https://github.com/mgernand/nhibernate-logging
 * 
 * Please keep this header intact if you use this code.
 */
namespace NHibernate.Logging.NLog
{
	using System;
	using global::NLog;

	/// <summary>
	/// Implements the <see cref="IInternalLogger"/> interface to allow the usage 
	/// of NLog 2.0 with the NHibernate logging infrastructure.
	/// </summary>
	/// Note: https://github.com/uhaciogullari/NLog.Interface
	public class NLogLogger : IInternalLogger
	{
		private readonly Logger logger;

		public NLogLogger(Logger logger)
		{
			this.logger = logger;
		}

		public void Error(object message)
		{
			this.logger.Error(message);
		}

		public void Error(object message, Exception exception)
		{
			this.logger.ErrorException(message.ToStringSafe(), exception);
		}

		public void ErrorFormat(string format, params object[] args)
		{
			this.logger.Error(format, args);
		}

		public void Fatal(object message)
		{
			this.logger.Fatal(message);
		}

		public void Fatal(object message, Exception exception)
		{
			this.logger.FatalException(message.ToStringSafe(), exception);
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
			this.logger.DebugException(message.ToStringSafe(), exception);
		}

		public void DebugFormat(string format, params object[] args)
		{
			this.logger.Debug(format, args);
		}

		public void Info(object message)
		{
			this.logger.Info(message);
		}

		public void Info(object message, Exception exception)
		{
			this.logger.InfoException(message.ToStringSafe(), exception);
		}

		public void InfoFormat(string format, params object[] args)
		{
			this.logger.Info(format, args);
		}

		public void Warn(object message)
		{
			this.logger.Warn(message);
		}

		public void Warn(object message, Exception exception)
		{
			this.logger.WarnException(message.ToStringSafe(), exception);
		}

		public void WarnFormat(string format, params object[] args)
		{
			this.logger.Warn(format, args);
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
