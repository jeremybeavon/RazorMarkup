using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class ConfigurationFunctionsTests
    {
        [TestMethod]
        public void Test_DatabaseTimestamp()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.DatabaseTimestamp(), "@@DBTS");
        }

        [TestMethod]
        public void Test_LanguageId()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.LanguageId(), "@@LANGID");
        }

        [TestMethod]
        public void Test_Language()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.Language(), "@@LANGUAGE");
        }

        [TestMethod]
        public void Test_LockTimeout()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.LockTimeout(), "@@LOCK_TIMEOUT");
        }

        [TestMethod]
        public void Test_MaxConnections()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.MaxConnections(), "@@MAX_CONNECTIONS");
        }

        [TestMethod]
        public void Test_MaxPrecision()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.MaxPrecision(), "@@MAX_PRECISION");
        }

        [TestMethod]
        public void Test_NestLevel()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.NestLevel(), "@@NESTLEVEL");
        }

        [TestMethod]
        public void Test_Options()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.Options(), "@@OPTIONS");
        }

        [TestMethod]
        public void Test_ServerName()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.ServerName(), "@@SERVERNAME");
        }

        [TestMethod]
        public void Test_ServiceName()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.ServiceName(), "@@SERVICENAME");
        }

        [TestMethod]
        public void Test_SessionId()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.SessionId(), "@@SPID");
        }

        [TestMethod]
        public void Test_TextSize()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.TextSize(), "@@TEXTSIZE");
        }

        [TestMethod]
        public void Test_Version()
        {
            FunctionTestHelper.TestFunction(() => ConfigurationFunctions.Version(), "@@VERSION");
        }
    }
}
