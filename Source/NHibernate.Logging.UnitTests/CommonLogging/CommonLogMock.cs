namespace NHibernate.Logging.UnitTests.CommonLogging
{
	using System;
	using Common.Logging;

	internal class CommonLogMock : ILog
	{
		public int isTraceEnabled;
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
			throw new NotImplementedException();
		}

		public void Debug(object message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void DebugFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void Info(object message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void InfoFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void Warn(object message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void WarnFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void Error(object message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void ErrorFormat(string format, params object[] args)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void Fatal(object message, Exception exception)
		{
			throw new NotImplementedException();
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
			get
			{
				this.isTraceEnabled++;
				return false;
			}
		}

		public bool IsDebugEnabled
		{
			get
			{
				this.isDebugEnabled++;
				return false;
			}
		}

		public bool IsInfoEnabled
		{
			get
			{
				this.isInfoEnabled++;
				return false;
			}
		}

		public bool IsWarnEnabled
		{
			get
			{
				this.isWarnEnabled++;
				return false;
			}
		}

		public bool IsErrorEnabled
		{
			get
			{
				this.isErrorEnabled++;
				return false;
			}
		}

		public bool IsFatalEnabled
		{
			get
			{
				this.isFatalEnabled++;
				return false;
			}
		}

		public IVariablesContext GlobalVariablesContext { get; private set; }

		public IVariablesContext ThreadVariablesContext { get; private set; }

		/// <inheritdoc />
		public INestedVariablesContext NestedThreadVariablesContext { get; }
	}
}