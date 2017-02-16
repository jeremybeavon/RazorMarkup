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
        public void Test_CreateBrokerPriority_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithContractName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (CONTRACT_NAME = ContractName)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().ContractName(new ContractName("ContractName"))
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithContractNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (CONTRACT_NAME = ANY)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().ContractName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithLocalServiceNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (LOCAL_SERVICE_NAME = ANY)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().LocalServiceName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithLocalServiceName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (LOCAL_SERVICE_NAME = LocalService)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().LocalServiceName("LocalService")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithRemoteServiceNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (REMOTE_SERVICE_NAME = ANY)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().RemoteServiceName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithRemoteServiceName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (REMOTE_SERVICE_NAME = RemoteService)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().RemoteServiceName("RemoteService")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelDefault_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = DEFAULT)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Default()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelOne_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 1)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().One()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelTwo_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 2)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Two()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelThree_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 3)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Three()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelFour_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 4)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Four()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelFive_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 5)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Five()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelSix_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 6)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Six()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelSeven_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 7)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Seven()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelEight_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 8)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Eight()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelNine_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 9)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Nine()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_CreateBrokerPriorityWithPriorityLevelTen_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"CREATE BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 10)";
            Sql.Create()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Ten()
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
