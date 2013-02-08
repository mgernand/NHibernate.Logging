namespace Logging.Tests.NLog
{
	using System;
	using global::NLog;

	// https://github.com/uhaciogullari/NLog.Interface
	internal class NLogLogMock : Logger
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

		#region Debug
		public new void Debug(object message)
		{
			this.debug++;
		}

		public new void DebugException(string message, Exception exception)
		{
			this.debugException++;
		}

		public new void Debug(string format, params object[] args)
		{
			this.debugFormat++;
		}
		#endregion

		#region Info
		public new void Info(object message)
		{
			this.info++;
		}

		public new void InfoException(string message, Exception exception)
		{
			this.infoException++;
		}

		public new void Info(string format, params object[] args)
		{
			this.infoFormat++;
		}
		#endregion

		#region Warn
		public new void Warn(object message)
		{
			this.warn++;
		}

		public new void WarnException(string message, Exception exception)
		{
			this.warnException++;
		}

		public new void Warn(string format, params object[] args)
		{
			this.warnFormat++;
		}
		#endregion

		#region Error
		public new void Error(object message)
		{
			this.error++;
		}

		public new void ErrorException(string message, Exception exception)
		{
			this.errorException++;
		}

		public new void Error(string format, params object[] args)
		{
			this.errorFormat++;
		}
		#endregion

		#region Fatal
		public new void Fatal(object message)
		{
			this.fatal++;
		}

		public new void FatalException(string message, Exception exception)
		{
			this.fatalException++;
		}
		#endregion

		public new bool IsDebugEnabled
		{
			get
			{
				this.isDebugEnabled++;
				return false;
			}
		}

		public new bool IsInfoEnabled
		{
			get
			{
				this.isInfoEnabled++;
				return false;
			}
		}

		public new bool IsWarnEnabled
		{
			get
			{
				this.isWarnEnabled++;
				return false;
			}
		}

		public new bool IsErrorEnabled
		{
			get
			{
				this.isErrorEnabled++;
				return false;
			}
		}

		public new bool IsFatalEnabled
		{
			get
			{
				this.isFatalEnabled++;
				return false;
			}
		}
	}
}