using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class ReturnStatementTests
    {
        [TestMethod]
        public void Test_Return_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Return().ToSqlStringViaRazorPageIs("RETURN");
        }

        [TestMethod]
        public void Test_ReturnWithValue_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Return(() => "Test").ToSqlStringViaRazorPageIs("RETURN 'Test'");
        }
    }
}
