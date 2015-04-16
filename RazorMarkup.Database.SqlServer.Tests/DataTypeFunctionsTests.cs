using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    // Do later: Identity
    [TestClass]
    public sealed class DataTypeFunctionsTests
    {
        [TestMethod]
        public void Test_DatabaseLength()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.DataLength(null), "DATALENGTH(NULL)");
        }

        /*public void Test_IdentityWith1Parameter()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.Identity(10), "IDENTITY(10)");
        }*/

        [TestMethod]
        public void Test_IdentityCurrent()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.IdentityCurrent(null), "IDENT_CURRENT(NULL)");
        }

        [TestMethod]
        public void Test_IdentityIncrement()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.IdentityIncrement(null), "IDENT_INCR(NULL)");
        }

        [TestMethod]
        public void Test_IdentitySeed()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.IdentitySeed(null), "IDENT_SEED(NULL)");
        }

        [TestMethod]
        public void Test_SqlVariantProperty()
        {
            FunctionTestHelper.TestFunction(() => DataTypeFunctions.SqlVariantProperty(null, null), "SQL_VARIANT_PROPERTY(NULL, NULL)");
        }
    }
}
