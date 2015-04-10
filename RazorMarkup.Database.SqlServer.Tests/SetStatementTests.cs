using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorMarkup.Database.SqlServer.Tests
{
    // Do later: LockTimeout, RowCount, QueryGovenorCostLimit
    [TestClass]
    public sealed class SetStatementTests
    {
        [TestMethod]
        public void Test_AnsiDefaults_On()
        {
            Sql.Set().AnsiDefaults().On().ToSqlStringViaRazorPageIs("SET ANSI_DEFAULTS ON");
        }

        [TestMethod]
        public void Test_AnsiDefaults_Off()
        {
            Sql.Set().AnsiDefaults().Off().ToSqlStringViaRazorPageIs("SET ANSI_DEFAULTS OFF");
        }

        [TestMethod]
        public void Test_AnsiNullDefaultOff_On()
        {
            Sql.Set().AnsiNullDefaultOff().On().ToSqlStringViaRazorPageIs("SET ANSI_NULL_DFLT_OFF ON");
        }

        [TestMethod]
        public void Test_AnsiNullDefaultOff_Off()
        {
            Sql.Set().AnsiNullDefaultOff().Off().ToSqlStringViaRazorPageIs("SET ANSI_NULL_DFLT_OFF OFF");
        }

        [TestMethod]
        public void Test_AnsiNullDefaultOn_On()
        {
            Sql.Set().AnsiNullDefaultOn().On().ToSqlStringViaRazorPageIs("SET ANSI_NULL_DFLT_ON ON");
        }

        [TestMethod]
        public void Test_AnsiNullDefaultOn_Off()
        {
            Sql.Set().AnsiNullDefaultOn().Off().ToSqlStringViaRazorPageIs("SET ANSI_NULL_DFLT_ON OFF");
        }

        [TestMethod]
        public void Test_AnsiPadding_On()
        {
            Sql.Set().AnsiPadding().On().ToSqlStringViaRazorPageIs("SET ANSI_PADDING ON");
        }

        [TestMethod]
        public void Test_AnsiPadding_Off()
        {
            Sql.Set().AnsiPadding().Off().ToSqlStringViaRazorPageIs("SET ANSI_PADDING OFF");
        }

        [TestMethod]
        public void Test_AnsiWarnings_On()
        {
            Sql.Set().AnsiWarnings().On().ToSqlStringViaRazorPageIs("SET ANSI_WARNINGS ON");
        }

        [TestMethod]
        public void Test_AnsiWarnings_Off()
        {
            Sql.Set().AnsiWarnings().Off().ToSqlStringViaRazorPageIs("SET ANSI_WARNINGS OFF");
        }

        [TestMethod]
        public void Test_ArithmeticAbort_On()
        {
            Sql.Set().ArithmeticAbort().On().ToSqlStringViaRazorPageIs("SET ARITHABORT ON");
        }

        [TestMethod]
        public void Test_ArithmeticAbort_Off()
        {
            Sql.Set().ArithmeticAbort().Off().ToSqlStringViaRazorPageIs("SET ARITHABORT OFF");
        }

        [TestMethod]
        public void Test_ArithmeticIgnore_On()
        {
            Sql.Set().ArithmeticIgnore().On().ToSqlStringViaRazorPageIs("SET ARITHIGNORE ON");
        }

        [TestMethod]
        public void Test_ArithmeticIgnore_Off()
        {
            Sql.Set().ArithmeticIgnore().Off().ToSqlStringViaRazorPageIs("SET ARITHIGNORE OFF");
        }

        [TestMethod]
        public void Test_CursorCloseOnCommit_On()
        {
            Sql.Set().CursorCloseOnCommit().On().ToSqlStringViaRazorPageIs("SET CURSOR_CLOSE_ON_COMMIT ON");
        }

        [TestMethod]
        public void Test_CursorCloseOnCommit_Off()
        {
            Sql.Set().CursorCloseOnCommit().Off().ToSqlStringViaRazorPageIs("SET CURSOR_CLOSE_ON_COMMIT OFF");
        }

        [TestMethod]
        public void Test_DateFirst_ForVariable()
        {
            Sql.Set().DateFirst(new VariableName("datefirst")).ToSqlStringViaRazorPageIs("SET DATEFIRST @datefirst");
        }

        [TestMethod]
        public void Test_DateFirst_ForMonday()
        {
            Sql.Set().DateFirst().ToMonday().ToSqlStringViaRazorPageIs("SET DATEFIRST 1");
        }

        [TestMethod]
        public void Test_DateFirst_ForTuesday()
        {
            Sql.Set().DateFirst().ToTuesday().ToSqlStringViaRazorPageIs("SET DATEFIRST 2");
        }

        [TestMethod]
        public void Test_DateFirst_ForWednesday()
        {
            Sql.Set().DateFirst().ToWednesday().ToSqlStringViaRazorPageIs("SET DATEFIRST 3");
        }

        [TestMethod]
        public void Test_DateFirst_ForThursday()
        {
            Sql.Set().DateFirst().ToThursday().ToSqlStringViaRazorPageIs("SET DATEFIRST 4");
        }

        [TestMethod]
        public void Test_DateFirst_ForFriday()
        {
            Sql.Set().DateFirst().ToFriday().ToSqlStringViaRazorPageIs("SET DATEFIRST 5");
        }

        [TestMethod]
        public void Test_DateFirst_ForSaturday()
        {
            Sql.Set().DateFirst().ToSaturday().ToSqlStringViaRazorPageIs("SET DATEFIRST 6");
        }

        [TestMethod]
        public void Test_DateFirst_ForSunday()
        {
            Sql.Set().DateFirst().ToSunday().ToSqlStringViaRazorPageIs("SET DATEFIRST 7");
        }

        [TestMethod]
        public void Test_DateFormat_ForVariable()
        {
            Sql.Set().DateFormat(new VariableName("@dateformat")).ToSqlStringViaRazorPageIs("SET DATEFORMAT @dateformat");
        }

        [TestMethod]
        public void Test_DateFormat_ForDayMonthYear()
        {
            Sql.Set().DateFormat().ToDayMonthYear().ToSqlStringViaRazorPageIs("SET DATEFORMAT dmy");
        }

        [TestMethod]
        public void Test_DateFormat_ForDayYearMonth()
        {
            Sql.Set().DateFormat().ToDayYearMonth().ToSqlStringViaRazorPageIs("SET DATEFORMAT dym");
        }

        [TestMethod]
        public void Test_DateFormat_ForMonthDayYear()
        {
            Sql.Set().DateFormat().ToMonthDayYear().ToSqlStringViaRazorPageIs("SET DATEFORMAT mdy");
        }

        [TestMethod]
        public void Test_DateFormat_ForMonthYearDay()
        {
            Sql.Set().DateFormat().ToMonthYearDay().ToSqlStringViaRazorPageIs("SET DATEFORMAT myd");
        }

        [TestMethod]
        public void Test_DateFormat_ForYearDayMonth()
        {
            Sql.Set().DateFormat().ToYearDayMonth().ToSqlStringViaRazorPageIs("SET DATEFORMAT ydm");
        }

        [TestMethod]
        public void Test_DateFormat_ForYearMonthDay()
        {
            Sql.Set().DateFormat().ToYearMonthDay().ToSqlStringViaRazorPageIs("SET DATEFORMAT ymd");
        }

        [TestMethod]
        public void Test_FipsFlagger_ForEntry()
        {
            Sql.Set().FipsFlagger().ToEntry().ToSqlStringViaRazorPageIs("SET FIPS_FLAGGER 'ENTRY'");
        }

        [TestMethod]
        public void Test_FipsFlagger_ForFull()
        {
            Sql.Set().FipsFlagger().ToFull().ToSqlStringViaRazorPageIs("SET FIPS_FLAGGER 'FULL'");
        }

        [TestMethod]
        public void Test_FipsFlagger_ForIntermediate()
        {
            Sql.Set().FipsFlagger().ToIntermediate().ToSqlStringViaRazorPageIs("SET FIPS_FLAGGER 'INTERMEDIATE'");
        }

        [TestMethod]
        public void Test_FipsFlagger_ForOff()
        {
            Sql.Set().FipsFlagger().ToOff().ToSqlStringViaRazorPageIs("SET FIPS_FLAGGER OFF");
        }

        [TestMethod]
        public void Test_ForcePlan_On()
        {
            Sql.Set().ForcePlan().On().ToSqlStringViaRazorPageIs("SET FORCEPLAN ON");
        }

        [TestMethod]
        public void Test_ForcePlan_Off()
        {
            Sql.Set().ForcePlan().Off().ToSqlStringViaRazorPageIs("SET FORCEPLAN OFF");
        }

        [TestMethod]
        public void Test_IdentityInsert_On()
        {
            Sql.Set().IdentityInsert(new TableName("test_table")).On().ToSqlStringViaRazorPageIs("SET IDENTITY_INSERT test_table ON");
        }

        [TestMethod]
        public void Test_IdentityInsert_Off()
        {
            Sql.Set().IdentityInsert(new TableName("test_table")).Off().ToSqlStringViaRazorPageIs("SET IDENTITY_INSERT test_table OFF");
        }

        [TestMethod]
        public void Test_ImplicitTransactions_On()
        {
            Sql.Set().ImplicitTransactions().On().ToSqlStringViaRazorPageIs("SET IMPLICIT_TRANSACTIONS ON");
        }

        [TestMethod]
        public void Test_ImplicitTransactions_Off()
        {
            Sql.Set().ImplicitTransactions().Off().ToSqlStringViaRazorPageIs("SET IMPLICIT_TRANSACTIONS OFF");
        }

        [TestMethod]
        public void Test_Language_ForEnglish()
        {
            Sql.Set().Language(() => "English").ToSqlStringViaRazorPageIs("SET LANGUAGE 'English'");
        }

        [TestMethod]
        public void Test_NoCount_On()
        {
            Sql.Set().NoCount().On().ToSqlStringViaRazorPageIs("SET NOCOUNT ON");
        }

        [TestMethod]
        public void Test_NoCount_Off()
        {
            Sql.Set().NoCount().Off().ToSqlStringViaRazorPageIs("SET NOCOUNT OFF");
        }

        [TestMethod]
        public void Test_NoExec_On()
        {
            Sql.Set().NoExec().On().ToSqlStringViaRazorPageIs("SET NOEXEC ON");
        }

        [TestMethod]
        public void Test_NoExec_Off()
        {
            Sql.Set().NoExec().Off().ToSqlStringViaRazorPageIs("SET NOEXEC OFF");
        }

        [TestMethod]
        public void Test_NumericRoundAbort_On()
        {
            Sql.Set().NumericRoundAbort().On().ToSqlStringViaRazorPageIs("SET NUMERIC_ROUNDABORT ON");
        }

        [TestMethod]
        public void Test_NumericRoundAbort_Off()
        {
            Sql.Set().NumericRoundAbort().Off().ToSqlStringViaRazorPageIs("SET NUMERIC_ROUNDABORT OFF");
        }

        [TestMethod]
        public void Test_ParseOnly_On()
        {
            Sql.Set().ParseOnly().On().ToSqlStringViaRazorPageIs("SET PARSEONLY ON");
        }

        [TestMethod]
        public void Test_ParseOnly_Off()
        {
            Sql.Set().ParseOnly().Off().ToSqlStringViaRazorPageIs("SET PARSEONLY OFF");
        }

        [TestMethod]
        public void Test_QuotedIdentifier_On()
        {
            Sql.Set().QuotedIdentifier().On().ToSqlStringViaRazorPageIs("SET QUOTED_IDENTIFIER ON");
        }

        [TestMethod]
        public void Test_QuotedIdentifier_Off()
        {
            Sql.Set().QuotedIdentifier().Off().ToSqlStringViaRazorPageIs("SET QUOTED_IDENTIFIER OFF");
        }

        [TestMethod]
        public void Test_ShowPlanAll_On()
        {
            Sql.Set().ShowPlanAll().On().ToSqlStringViaRazorPageIs("SET SHOWPLAN_ALL ON");
        }

        [TestMethod]
        public void Test_ShowPlanAll_Off()
        {
            Sql.Set().ShowPlanAll().Off().ToSqlStringViaRazorPageIs("SET SHOWPLAN_ALL OFF");
        }

        [TestMethod]
        public void Test_ShowPlanText_On()
        {
            Sql.Set().ShowPlanText().On().ToSqlStringViaRazorPageIs("SET SHOWPLAN_TEXT ON");
        }

        [TestMethod]
        public void Test_ShowPlanText_Off()
        {
            Sql.Set().ShowPlanText().Off().ToSqlStringViaRazorPageIs("SET SHOWPLAN_TEXT OFF");
        }

        [TestMethod]
        public void Test_ShowPlanXml_On()
        {
            Sql.Set().ShowPlanXml().On().ToSqlStringViaRazorPageIs("SET SHOWPLAN_XML ON");
        }

        [TestMethod]
        public void Test_ShowPlanXml_Off()
        {
            Sql.Set().ShowPlanXml().Off().ToSqlStringViaRazorPageIs("SET SHOWPLAN_XML OFF");
        }

        [TestMethod]
        public void Test_StatisticsIo_On()
        {
            Sql.Set().StatisticsIo().On().ToSqlStringViaRazorPageIs("SET STATISTICS IO ON");
        }

        [TestMethod]
        public void Test_StatisticsIo_Off()
        {
            Sql.Set().StatisticsIo().Off().ToSqlStringViaRazorPageIs("SET STATISTICS IO OFF");
        }

        [TestMethod]
        public void Test_StatisticsProfile_On()
        {
            Sql.Set().StatisticsProfile().On().ToSqlStringViaRazorPageIs("SET STATISTICS PROFILE ON");
        }

        [TestMethod]
        public void Test_StatisticsProfile_Off()
        {
            Sql.Set().StatisticsProfile().Off().ToSqlStringViaRazorPageIs("SET STATISTICS PROFILE OFF");
        }

        [TestMethod]
        public void Test_StatisticsTime_On()
        {
            Sql.Set().StatisticsTime().On().ToSqlStringViaRazorPageIs("SET STATISTICS TIME ON");
        }

        [TestMethod]
        public void Test_StatisticsTime_Off()
        {
            Sql.Set().StatisticsTime().Off().ToSqlStringViaRazorPageIs("SET STATISTICS TIME OFF");
        }

        [TestMethod]
        public void Test_StatisticsXml_On()
        {
            Sql.Set().StatisticsXml().On().ToSqlStringViaRazorPageIs("SET STATISTICS XML ON");
        }

        [TestMethod]
        public void Test_StatisticsXml_Off()
        {
            Sql.Set().StatisticsXml().Off().ToSqlStringViaRazorPageIs("SET STATISTICS XML OFF");
        }
    }
}
