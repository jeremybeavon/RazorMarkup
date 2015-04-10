using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class BreakStatementTests
    {
        [TestMethod]
        public void Test_Break_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Break().ToSqlStringViaRazorPageIs("BREAK");
        }
    }
}
