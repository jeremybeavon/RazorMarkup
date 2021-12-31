using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Options
{
    // Do later: deadlock_priority, language
    public interface ISetStatements : IHideObjectMethods
    {
        IOnOffOptions AnsiDefaults();

        IOnOffOptions AnsiNullDefaultOff();

        IOnOffOptions AnsiNullDefaultOn();

        IOnOffOptions AnsiPadding();

        IOnOffOptions AnsiWarnings();

        IOnOffOptions ArithmeticAbort();

        IOnOffOptions ArithmeticIgnore();

        //ISqlString ContextInfo(Binary binary);

        IOnOffOptions CursorCloseOnCommit();

        IDateFirst DateFirst();

        ISqlString DateFirst(VariableName variableName);

        IDateFormat DateFormat();

        ISqlString DateFormat(VariableName variableName);

        IFipsFlagger FipsFlagger();

        IOnOffOptions ForcePlan();

        IOnOffOptions IdentityInsert(TableName tableName);

        IOnOffOptions ImplicitTransactions();

        ISqlString Language(Expression<Func<LiteralText>> language);

        ISqlString LockTimeout(int milliseconds);

        ISqlString LockTimeout(TimeSpan timeoutPeriod);

        ILockTimeout LockTimeout();

        IOnOffOptions NoCount();

        IOnOffOptions NoExec();

        IOnOffOptions NumericRoundAbort();

        ISqlString RowCount(int rowCount);

        ISqlString RowCount(VariableName rowCount);

        IOnOffOptions ParseOnly();

        ISqlString QueryGovernorCostLimit(int value);

        IOnOffOptions QuotedIdentifier();

        IOnOffOptions ShowPlanAll();

        IOnOffOptions ShowPlanText();

        IOnOffOptions ShowPlanXml();

        IOnOffOptions StatisticsIo();

        IOnOffOptions StatisticsProfile();

        IOnOffOptions StatisticsTime();

        IOnOffOptions StatisticsXml();

        ITransactionIsolationLevel TransactionIsolationLevel();

        IOnOffOptions XactAbort();
    }
}