using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class CreateStatementTests
    {
        [TestMethod]
        public void Test_CreateAggregate_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE AGGREGATE aggregate
(
    @parameter1 int,
    @parameter2 money
)
RETURNS bigint
EXTERNAL NAME assembly.class";
            Sql.Create()
                .Aggregate(new AggregateName("aggregate"))
                .WithParameter(new ParameterName("@parameter1"), typeof(SqlInt))
                .And(new ParameterName("@parameter2"), new TypeName("money"))
                .Returns(new TypeName("bigint"))
                .ExternalName(new AssemblyName("assembly"), new ClassName("class"))
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateAssemblyWithSafe_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE ASSEMBLY TestAssembly
AUTHORIZATION owner
FROM C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll
WITH PERMISSION_SET = SAFE";
            Sql.Create()
                .Assembly(new AssemblyName("TestAssembly"))
                .Authorization("owner")
                .From(@"C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll")
                .WithPermissionSet().Safe()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateAssemblyWithExternalAccess_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE ASSEMBLY TestAssembly
FROM C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll
WITH PERMISSION_SET = EXTERNAL_ACCESS";
            Sql.Create()
                .Assembly(new AssemblyName("TestAssembly"))
                .From(@"C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll")
                .WithPermissionSet().ExternalAccess()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateAssemblyWithUnsafe_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE ASSEMBLY TestAssembly
FROM C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll
WITH PERMISSION_SET = UNSAFE";
            Sql.Create()
                .Assembly(new AssemblyName("TestAssembly"))
                .From(@"C:\Program Files\Microsoft SQL Server\100\Samples\HelloWorld\CS\HelloWorld\bin\debug\HelloWorld.dll")
                .WithPermissionSet().Unsafe()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateMasterKey_GeneratesCorrectTextFromRazorPage()
        {
            Sql.Create().MasterKey().EncryptionByPassword("test")
                .ToSqlStringViaRazorPageIs("CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'test'");
        }
    }
}
