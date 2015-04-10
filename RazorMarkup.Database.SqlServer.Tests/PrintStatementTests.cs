using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class PrintStatementTests
    {
        [TestMethod]
        public void Test_Print_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Print(() => "Test").ToSqlStringViaRazorPageIs("PRINT 'Test'");
        }
    }
}
