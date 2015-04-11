using System;
using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Options;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using SqlIntegerLiteral = Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        private static readonly IDictionary<SetOptions, Func<ISetStatements, IOnOffOptions>> optionBuilders =
            new Dictionary<SetOptions, Func<ISetStatements, IOnOffOptions>>()
        {
            { SetOptions.AnsiDefaults, set => set.AnsiDefaults() },
            { SetOptions.AnsiNullDfltOff, set => set.AnsiNullDefaultOff() },
            { SetOptions.AnsiNullDfltOn, set => set.AnsiNullDefaultOn() },
            { SetOptions.AnsiNulls, set => Obsolete("SET ANSI_NULLS is obsolete.") },
            { SetOptions.AnsiPadding, set => set.AnsiPadding() },
            { SetOptions.AnsiWarnings, set => set.AnsiWarnings() },
            { SetOptions.ArithAbort, set => set.ArithmeticAbort() },
            { SetOptions.ArithIgnore, set => set.ArithmeticIgnore() },
            { SetOptions.ConcatNullYieldsNull, set => Obsolete("SET CONCAT_NULL_YIELDS_NULL is obsolete.") },
            { SetOptions.CursorCloseOnCommit, set => set.CursorCloseOnCommit() },
            { SetOptions.DisableDefCnstChk, set => NotSupported("DisableDefCnstChk is not supported.") },
            { SetOptions.FmtOnly, set =>Obsolete("SET FMTONLY is obsolete.") },
            { SetOptions.ForcePlan, set => set.ForcePlan() },
            { SetOptions.ImplicitTransactions, set => set.ImplicitTransactions() },
            { SetOptions.NoBrowsetable, set => NotSupported("SET NO_BROWSETABLE is not supported.") },
            { SetOptions.NoCount, set => set.NoCount() },
            { SetOptions.NoExec, set => set.NoExec() },
            { SetOptions.NumericRoundAbort, set => set.NumericRoundAbort() },
            { SetOptions.ParseOnly, set => set.ParseOnly() },
            { SetOptions.QuotedIdentifier, set => set.QuotedIdentifier() },
            { SetOptions.RemoteProcTransactions, set => Obsolete("SET REMOTE_PROC_TRANSACTIONS is obsolete.") },
            { SetOptions.ShowPlanAll, set => set.ShowPlanAll() },
            { SetOptions.ShowPlanText, set => set.ShowPlanText() },
            { SetOptions.ShowPlanXml, set => set.ShowPlanXml() },
            { SetOptions.XactAbort, set => set.XactAbort() }
        };

        private static readonly IDictionary<SetStatisticsOptions, Func<ISetStatements, IOnOffOptions>> statisticsOptionBuilders =
            new Dictionary<SetStatisticsOptions, Func<ISetStatements, IOnOffOptions>>()
        {
            { SetStatisticsOptions.IO, set => set.StatisticsIo() },
            { SetStatisticsOptions.Profile, set => set.StatisticsProfile() },
            { SetStatisticsOptions.Time, set => set.StatisticsTime() },
            { SetStatisticsOptions.Xml, set => set.StatisticsXml() }
        };

        public override void ExplicitVisit(GeneralSetCommand node)
        {
            switch (node.CommandType)
            {
                case GeneralSetCommandType.ContextInfo:
                    throw new NotImplementedException();
                case GeneralSetCommandType.DateFirst:
                    Result = BuildDateFirst(node);
                    break;
                case GeneralSetCommandType.DateFormat:
                    Result = BuildDateFormat(node);
                    break;
                case GeneralSetCommandType.DeadlockPriority:
                    throw new ObsoleteException("SET DEADLOCK_PRIORITY is obsolete.");
                case GeneralSetCommandType.Language:
                    Result = Sql.Set().Language(node.Parameter.ToExpression<LiteralText>());
                    break;
                case GeneralSetCommandType.LockTimeout:
                    throw new NotImplementedException();
                case GeneralSetCommandType.None:
                    throw new NotSupportedException();
                case GeneralSetCommandType.QueryGovernorCostLimit:
                    throw new NotImplementedException();
            }
        }

        public override void ExplicitVisit(PredicateSetStatement node)
        {
            Result = BuildSetStatement(node, node.Options, optionBuilders);
        }

        public override void ExplicitVisit(SetFipsFlaggerCommand node)
        {
            IFipsFlagger fipsFlagger = Sql.Set().FipsFlagger();
            switch (node.ComplianceLevel)
            {
                case FipsComplianceLevel.Entry:
                    Result = fipsFlagger.ToEntry();
                    break;
                case FipsComplianceLevel.Full:
                    Result = fipsFlagger.ToFull();
                    break;
                case FipsComplianceLevel.Intermediate:
                    Result = fipsFlagger.ToIntermediate();
                    break;
                case FipsComplianceLevel.Off:
                    Result = fipsFlagger.ToOff();
                    break;
            }
        }

        public override void ExplicitVisit(SetCommandStatement node)
        {
            if (node.Commands.Count > 1)
            {
                throw new NotSupportedException("Cannot support set commands with more than 1 command.");
            }

            node.Commands[0].Accept(this);
        }

        public override void ExplicitVisit(SetIdentityInsertStatement node)
        {
            Result = BuildSetStatement(node, Sql.Set().IdentityInsert(node.Table.ToTableName()));
        }

        public override void ExplicitVisit(SetOffsetsStatement node)
        {
            Obsolete("SET OFFSET is obsolete.");
        }

        public override void ExplicitVisit(SetStatisticsStatement node)
        {
            Result = BuildSetStatement(node, node.Options, statisticsOptionBuilders);
        }

        private static ISqlString BuildDateFirst(GeneralSetCommand command)
        {
            VariableReference variableReference = command.Parameter as VariableReference;
            if (variableReference != null)
            {
                return Sql.Set().DateFirst(new VariableName(variableReference.Name));
            }

            SqlIntegerLiteral literal = command.Parameter as SqlIntegerLiteral;
            if (literal != null)
            {
                IDateFirst dateFirst = Sql.Set().DateFirst();
                switch (literal.Value)
                {
                    case "1":
                        return dateFirst.ToMonday();
                    case "2":
                        return dateFirst.ToTuesday();
                    case "3":
                        return dateFirst.ToWednesday();
                    case "4":
                        return dateFirst.ToThursday();
                    case "5":
                        return dateFirst.ToFriday();
                    case "6":
                        return dateFirst.ToSaturday();
                    case "7":
                        return dateFirst.ToSunday();
                }
            }

            throw new NotSupportedException();
        }

        private static ISqlString BuildDateFormat(GeneralSetCommand command)
        {
            VariableReference variableReference = command.Parameter as VariableReference;
            if (variableReference != null)
            {
                return Sql.Set().DateFormat(new VariableName(variableReference.Name));
            }

            IdentifierLiteral literal = command.Parameter as IdentifierLiteral;
            if (literal != null)
            {
                IDateFormat dateFormat = Sql.Set().DateFormat();
                switch (literal.Value)
                {
                    case "dmy":
                        return dateFormat.ToDayMonthYear();
                    case "dym":
                        return dateFormat.ToDayYearMonth();
                    case "mdy":
                        return dateFormat.ToMonthDayYear();
                    case "myd":
                        return dateFormat.ToMonthYearDay();
                    case "ydm":
                        return dateFormat.ToYearDayMonth();
                    case "ymd":
                        return dateFormat.ToYearMonthDay();
                }
            }

            throw new NotSupportedException();
        }

        private static ISqlString BuildSetStatement<TEnum>(
            SetOnOffStatement statement,
            TEnum setting,
            IDictionary<TEnum, Func<ISetStatements, IOnOffOptions>> builders)
        {
            Func<ISetStatements, IOnOffOptions> builder;
            if (!builders.TryGetValue(setting, out builder))
            {
                throw new NotSupportedException("Unknown options: " + setting);
            }

            IOnOffOptions options = builder(Sql.Set());
            return BuildSetStatement(statement, options);
        }

        private static ISqlString BuildSetStatement(SetOnOffStatement statement, IOnOffOptions options)
        {
            return statement.IsOn ? options.On() : options.Off();
        }

        private static IOnOffOptions Obsolete(string message)
        {
            throw new ObsoleteException(message);
        }

        private static IOnOffOptions NotSupported(string message)
        {
            throw new NotSupportedException(message);
        }
    }
}
