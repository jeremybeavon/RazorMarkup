using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Tests
{
    [TestClass]
    public sealed class AlterStatementTests
    {
        [TestMethod]
        public void Test_AlterBrokerPriorityWithContractName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (CONTRACT_NAME = ContractName)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().ContractName(new ContractName("ContractName"))
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithContractNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (CONTRACT_NAME = ANY)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().ContractName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithLocalServiceNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (LOCAL_SERVICE_NAME = ANY)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().LocalServiceName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithLocalServiceName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (LOCAL_SERVICE_NAME = LocalService)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().LocalServiceName("LocalService")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithRemoteServiceNameAny_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (REMOTE_SERVICE_NAME = ANY)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().RemoteServiceName().Any()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithRemoteServiceName_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (REMOTE_SERVICE_NAME = RemoteService)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().RemoteServiceName("RemoteService")
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelDefault_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = DEFAULT)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Default()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelOne_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 1)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().One()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelTwo_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 2)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Two()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelThree_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 3)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Three()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelFour_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 4)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Four()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelFive_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 5)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Five()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelSix_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 6)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Six()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelSeven_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 7)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Seven()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelEight_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 8)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Eight()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelNine_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 9)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Nine()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }

        [TestMethod]
        public void Test_AlterBrokerPriorityWithPriorityLevelTen_GeneratesCorrectTextFromRazorPage()
        {
            const string expectedResult = @"ALTER BROKER PRIORITY TestConversation
    FOR CONVERSATION
    SET (PRIORITY_LEVEL = 10)";
            Sql.Alter()
                .BrokerPriority(new ConversationPriorityName("TestConversation"))
                .ForConversation()
                .Set().PriorityLevel().Ten()
                .ToSqlStringViaRazorPageIs(expectedResult);
        }
    }
}
