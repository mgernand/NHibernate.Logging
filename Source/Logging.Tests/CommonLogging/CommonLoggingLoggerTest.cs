namespace Logging.Tests.CommonLogging
{
	using NHibernate;
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
			logger.IsEnabled(NHibernateLogLevel.Trace);
			logger.IsEnabled(NHibernateLogLevel.Debug);
			logger.IsEnabled(NHibernateLogLevel.Info);
			logger.IsEnabled(NHibernateLogLevel.Warn);
			logger.IsEnabled(NHibernateLogLevel.Error);
			logger.IsEnabled(NHibernateLogLevel.Fatal);

			logger.Log(NHibernateLogLevel.Trace, default, null);
			logger.Log(NHibernateLogLevel.Debug, default, null);
			logger.Log(NHibernateLogLevel.Info, default, null);
			logger.Log(NHibernateLogLevel.Warn, default, null);
			logger.Log(NHibernateLogLevel.Error, default, null);
			logger.Log(NHibernateLogLevel.Fatal, default, null);

			logMock.trace.Should().Be(1);
			logMock.traceException.Should().Be(1);
			logMock.traceFormat.Should().Be(1);
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
			logMock.isTraceEnabled.Should().Be(1);
			logMock.isDebugEnabled.Should().Be(1);
			logMock.isInfoEnabled.Should().Be(1);
			logMock.isWarnEnabled.Should().Be(1);
			logMock.isErrorEnabled.Should().Be(1);
			logMock.isFatalEnabled.Should().Be(1);
		}
	}
}
