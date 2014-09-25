using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class DropStatementTests
    {
        [TestMethod]
        public void Test_DropMasterKey_GeneratesCorrectText()
        {
            Sql.Drop().MasterKey().ToSqlString().Should().Be("DROP MASTER KEY");
        }

        [TestMethod]
        public void Test_DropMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().MasterKey().ToSqlStringViaRazorPage().Trim().Should().Be("DROP MASTER KEY");
        }

        [TestMethod]
        public void Test_DropApplicationRole_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Drop().ApplicationRole(new ApplicationRoleName("test")).Matches("DROP APPLICATION ROLE test");
        }
    }
}
