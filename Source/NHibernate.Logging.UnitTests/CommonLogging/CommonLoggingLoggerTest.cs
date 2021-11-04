namespace NHibernate.Logging.UnitTests.CommonLogging
{
	using FluentAssertions;
	using NHibernate;
	using NHibernate.Logging.CommonLogging;
	using NUnit.Framework;

	[TestFixture]
	public class CommonLoggingLoggerTest
	{
		private CommonLogMock logMock;
		private CommonLoggingLogger logger;

		[SetUp]
		public void SetUp()
		{
			this.logMock = new CommonLogMock();
			this.logger = new CommonLoggingLogger(this.logMock);
		}

		[Test]
		public void ShouldCall_IsTranceEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Trace);
			this.logMock.isTraceEnabled.Should().Be(1);
		}

		[Test]
		public void ShouldCall_IsDebugEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Debug);
			this.logMock.isDebugEnabled.Should().Be(1);
		}

		[Test]
		public void ShouldCall_IsInfoEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Info);
			this.logMock.isInfoEnabled.Should().Be(1);
		}

		[Test]
		public void ShouldCall_IsWarnEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Warn);
			this.logMock.isWarnEnabled.Should().Be(1);
		}

		[Test]
		public void ShouldCall_IsErrorEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Error);
			this.logMock.isErrorEnabled.Should().Be(1);
		}

		[Test]
		public void ShouldCall_IsFatalEnabled()
		{
			this.logger.IsEnabled(NHibernateLogLevel.Fatal);
			this.logMock.isFatalEnabled.Should().Be(1);
		}
	}
}
