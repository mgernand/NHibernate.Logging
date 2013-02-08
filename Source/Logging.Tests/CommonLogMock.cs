namespace Logging.Tests
{
	using System;
	using Common.Logging;

	internal class CommonLogMock : ILog
	{
		public int debug;
		public int debugException;
		public int debugFormat;
		public int info;
		public int infoException;
		public int infoFormat;
		public int warn;
		public int warnException;
		public int warnFormat;
		public int error;
		public int errorException;
		public int errorFormat;
		public int fatal;
		public int fatalException;
		public int isDebugEnabled;
		public int isInfoEnabled;
		public int isWarnEnabled;
		public int isErrorEnabled;
		public int isFatalEnabled;

		#region Trace
		public void Trace(object message)
		{
			throw new NotImplementedException();
		}

		public void Trace(object message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void TraceFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void TraceFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Trace(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Debug
		public void Debug(object message)
		{
			debug++;
		}

		public void Debug(object message, Exception exception)
		{
			debugException++;
		}

		public void DebugFormat(string format, params object[] args)
		{
			debugFormat++;
		}

		public void DebugFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Debug(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Info
		public void Info(object message)
		{
			info++;
		}

		public void Info(object message, Exception exception)
		{
			infoException++;
		}

		public void InfoFormat(string format, params object[] args)
		{
			infoFormat++;
		}

		public void InfoFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Info(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Warn
		public void Warn(object message)
		{
			warn++;
		}

		public void Warn(object message, Exception exception)
		{
			warnException++;
		}

		public void WarnFormat(string format, params object[] args)
		{
			warnFormat++;
		}

		public void WarnFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Warn(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Error
		public void Error(object message)
		{
			error++;
		}

		public void Error(object message, Exception exception)
		{
			errorException++;
		}

		public void ErrorFormat(string format, params object[] args)
		{
			errorFormat++;
		}

		public void ErrorFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Error(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region Fatal
		public void Fatal(object message)
		{
			fatal++;
		}

		public void Fatal(object message, Exception exception)
		{
			fatalException++;
		}

		public void FatalFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void FatalFormat(string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
		{
			throw new NotImplementedException();
		}

		public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
		{
			throw new NotImplementedException();
		}

		public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
		{
			throw new NotImplementedException();
		}
		#endregion

		public bool IsTraceEnabled
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsDebugEnabled
		{
			get
			{
				isDebugEnabled++;
				return false;
			}
		}

		public bool IsInfoEnabled
		{
			get
			{
				isInfoEnabled++;
				return false;
			}
		}

		public bool IsWarnEnabled
		{
			get
			{
				isWarnEnabled++;
				return false;
			}
		}

		public bool IsErrorEnabled
		{
			get
			{
				isErrorEnabled++;
				return false;
			}
		}

		public bool IsFatalEnabled
		{
			get
			{
				isFatalEnabled++;
				return false;
			}
		}
	}
}