using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class ContinueStatementTests
    {
        [TestMethod]
        public void Test_Continue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Continue().ToSqlStringViaRazorPageIs("CONTINUE");
        }
    }
}
