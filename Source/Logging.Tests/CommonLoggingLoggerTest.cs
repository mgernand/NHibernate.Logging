namespace Logging.Tests
{
	using NHibernate.Logging.CommonLogging;
	using NUnit.Framework;
	using SharpTestsEx;

	[TestFixture]
	public class CommonLoggingLoggerTest
	{
		[Test]
		public void CallingMethods()
		{
			CommonLogMock logMock = new CommonLogMock();
			CommonLoggingLogger logger = new CommonLoggingLogger(logMock);
			bool b = logger.IsDebugEnabled;
			b = logger.IsErrorEnabled;
			b = logger.IsFatalEnabled;
			b = logger.IsInfoEnabled;
			b = logger.IsWarnEnabled;

			logger.Debug(null);
			logger.Debug(null, null);
			logger.DebugFormat(null, null);

			logger.Error(null);
			logger.Error(null, null);
			logger.ErrorFormat(null, null);

			logger.Warn(null);
			logger.Warn(null, null);
			logger.WarnFormat(null, null);

			logger.Info(null);
			logger.Info(null, null);
			logger.InfoFormat(null, null);

			logger.Fatal(null);
			logger.Fatal(null, null);

			logMock.debug.Should().Be(1);
			logMock.debugException.Should().Be(1);
			logMock.debugFormat.Should().Be(1);
			logMock.info.Should().Be(1);
			logMock.infoException.Should().Be(1);
			logMock.infoFormat.Should().Be(1);
			logMock.warn.Should().Be(1);
			logMock.warnException.Should().Be(1);
			logMock.warnFormat.Should().Be(1);
			logMock.error.Should().Be(1);
			logMock.errorException.Should().Be(1);
			logMock.errorFormat.Should().Be(1);
			logMock.fatal.Should().Be(1);
			logMock.fatalException.Should().Be(1);
			logMock.isDebugEnabled.Should().Be(1);
			logMock.isInfoEnabled.Should().Be(1);
			logMock.isWarnEnabled.Should().Be(1);
			logMock.isErrorEnabled.Should().Be(1);
			logMock.isFatalEnabled.Should().Be(1);
		}
	}
}
