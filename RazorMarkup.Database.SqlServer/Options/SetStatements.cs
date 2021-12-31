using RazorMarkup.Database.SqlServer.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Options
{
    internal sealed class SetStatements : ISetStatements
    {
        public IOnOffOptions AnsiDefaults()
        {
            return new OnOffOptions("ANSI_DEFAULTS", () => Sql.Set().AnsiDefaults());
        }

        public IOnOffOptions AnsiNullDefaultOff()
        {
            return new OnOffOptions("ANSI_NULL_DFLT_OFF", () => Sql.Set().AnsiNullDefaultOff());
        }

        public IOnOffOptions AnsiNullDefaultOn()
        {
            return new OnOffOptions("ANSI_NULL_DFLT_ON", () => Sql.Set().AnsiNullDefaultOn());
        }

        public IOnOffOptions AnsiPadding()
        {
            return new OnOffOptions("ANSI_PADDING", () => Sql.Set().AnsiPadding());
        }

        public IOnOffOptions AnsiWarnings()
        {
            return new OnOffOptions("ANSI_WARNINGS", () => Sql.Set().AnsiWarnings());
        }

        public IOnOffOptions ArithmeticAbort()
        {
            return new OnOffOptions("ARITHABORT", () => Sql.Set().ArithmeticAbort());
        }

        public IOnOffOptions ArithmeticIgnore()
        {
            return new OnOffOptions("ARITHIGNORE", () => Sql.Set().ArithmeticIgnore());
        }

        public IOnOffOptions CursorCloseOnCommit()
        {
            return new OnOffOptions("CURSOR_CLOSE_ON_COMMIT", () => Sql.Set().CursorCloseOnCommit());
        }

        public IDateFirst DateFirst()
        {
            return new DateFirst();
        }

        public ISqlString DateFirst(VariableName variableName)
        {
            return new DateFirst(variableName);
        }

        public IDateFormat DateFormat()
        {
            return new DateFormat();
        }

        public ISqlString DateFormat(VariableName variableName)
        {
            return new DateFormat(variableName);
        }

        public IFipsFlagger FipsFlagger()
        {
            return new FipsFlagger();
        }

        public IOnOffOptions ForcePlan()
        {
            return new OnOffOptions("FORCEPLAN", () => Sql.Set().ForcePlan());
        }

        public IOnOffOptions ImplicitTransactions()
        {
            return new OnOffOptions("IMPLICIT_TRANSACTIONS", () => Sql.Set().ImplicitTransactions());
        }

        public IOnOffOptions IdentityInsert(TableName tableName)
        {
            return new OnOffOptions("IDENTITY_INSERT", () => Sql.Set().IdentityInsert(tableName), tableName);
        }

        public ISqlString Language(Expression<Func<LiteralText>> language)
        {
            SqlBuilder sqlBuilder = new("SET LANGUAGE ");
            new SqlExpressionBuilder(sqlBuilder).Visit(language.Body);
            return SqlString.Create(sqlBuilder.ToSqlString(), () => Sql.Set().Language(language), language);
        }

        public ILockTimeout LockTimeout()
        {
            return new LockTimeout();
        }

        public ISqlString LockTimeout(TimeSpan timeoutPeriod)
        {
            return new LockTimeout((int)timeoutPeriod.TotalMilliseconds);
        }

        public ISqlString LockTimeout(int milliseconds)
        {
            return new LockTimeout(milliseconds);
        }

        public IOnOffOptions NoCount()
        {
            return new OnOffOptions("NOCOUNT", () => Sql.Set().NoCount());
        }

        public IOnOffOptions NoExec()
        {
            return new OnOffOptions("NOEXEC", () => Sql.Set().NoExec());
        }

        public IOnOffOptions NumericRoundAbort()
        {
            return new OnOffOptions("NUMERIC_ROUNDABORT", () => Sql.Set().NumericRoundAbort());
        }

        public IOnOffOptions ParseOnly()
        {
            return new OnOffOptions("PARSEONLY", () => Sql.Set().ParseOnly());
        }

        public ISqlString QueryGovernorCostLimit(int value)
        {
            return new SqlString(string.Format("SET QUERY_GOVERNOR_COST_LIMIT {0}", value));
        }

        public IOnOffOptions QuotedIdentifier()
        {
            return new OnOffOptions("QUOTED_IDENTIFIER", () => Sql.Set().QuotedIdentifier());
        }

        public ISqlString RowCount(VariableName rowCount)
        {
            return new SqlString(string.Format("SET ROWCOUNT {0}", rowCount.ToSqlString()));
        }

        public ISqlString RowCount(int rowCount)
        {
            return new SqlString(string.Format("SET ROWCOUNT {0}", rowCount));
        }

        public IOnOffOptions ShowPlanAll()
        {
            return new OnOffOptions("SHOWPLAN_ALL", () => Sql.Set().ShowPlanAll());
        }

        public IOnOffOptions ShowPlanText()
        {
            return new OnOffOptions("SHOWPLAN_TEXT", () => Sql.Set().ShowPlanText());
        }

        public IOnOffOptions ShowPlanXml()
        {
            return new OnOffOptions("SHOWPLAN_XML", () => Sql.Set().ShowPlanXml());
        }

        public IOnOffOptions StatisticsIo()
        {
            return new OnOffOptions("STATISTICS IO", () => Sql.Set().StatisticsIo());
        }

        public IOnOffOptions StatisticsProfile()
        {
            return new OnOffOptions("STATISTICS PROFILE", () => Sql.Set().StatisticsProfile());
        }

        public IOnOffOptions StatisticsTime()
        {
            return new OnOffOptions("STATISTICS TIME", () => Sql.Set().StatisticsTime());
        }

        public IOnOffOptions StatisticsXml()
        {
            return new OnOffOptions("STATISTICS XML", () => Sql.Set().StatisticsXml());
        }

        public ITransactionIsolationLevel TransactionIsolationLevel()
        {
            return new TransactionIsolationLevel();
        }

        public IOnOffOptions XactAbort()
        {
            return new OnOffOptions("XACT_ABORT", () => Sql.Set().XactAbort());
        }
    }
}
