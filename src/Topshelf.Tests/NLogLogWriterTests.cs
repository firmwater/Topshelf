using System;
using NLog;
using NUnit.Framework;
using Topshelf.Logging;

namespace Topshelf.NLog.Tests
{
    [TestFixture]
    public class NLogLogWriterTests
    {
        [Test]
        public void Constructor_ShouldThrowArgumentNullException_WhenNameIsNull()
        {
            // Arrange
            var logger = LogManager.GetCurrentClassLogger();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new NLogLogWriter(logger, null));
        }

        [Test]
        public void IsDebugEnabled_ShouldReturnLoggerDebugState()
        {
            // Arrange
            var logger = LogManager.GetCurrentClassLogger();
            var logWriter = new NLogLogWriter(logger, "TestLogger");

            // Act
            var isDebugEnabled = logWriter.IsDebugEnabled;

            // Assert
            Assert.AreEqual(logger.IsDebugEnabled, isDebugEnabled);
        }

        [Test]
        public void Log_ShouldCallLoggerWithCorrectLevel()
        {
            // Arrange
            var logger = LogManager.GetCurrentClassLogger();
            var logWriter = new NLogLogWriter(logger, "TestLogger");
            var logLevel = LoggingLevel.Info;
            var message = "Test message";

            // Act
            logWriter.Log(logLevel, message);

            // Assert
            // Verify the log output using a mock or NLog's internal testing tools.
        }
    }
}
