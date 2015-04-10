using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class GotoStatementTests
    {
        [TestMethod]
        public void Test_Goto_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Goto(new LabelName("labelName")).ToSqlStringViaRazorPageIs("GOTO labelName");
        }
    }
}
