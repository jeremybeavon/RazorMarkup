using RazorMarkup.Database.SqlServer.Query.Builders;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonUnpivotClauseAliasInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonUnpivotClauseAlias> :
        CommonUnpivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin,
            TCommonUnpivotClauseAlias>,
        ICommonUnpivotClauseAliasInJoin<
            TJoinEndType,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
        where TCommonUnpivotClauseAlias : ICommonUnpivotClauseAlias<
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonUnpivotClauseAliasInJoin(
            FromClauseBuilder statement,
            TJoinEndType joinClosure,
            Func<FromClauseBuilder, TTableSourceInJoin> tableSourceInJoinBuilder,
            Func<FromClauseBuilder, TTableSource> tableSourceBuilder,
            Func<FromClauseBuilder, TPivotClause> pivotClauseBuilder,
            Func<FromClauseBuilder, TUnpivotClause> unpivotClauseBuilder,
            Func<FromClauseBuilder, TTableSelectionWithJoin> tableSelectionWithJoinBuilder)
            : base(
                  statement,
                  tableSourceInJoinBuilder,
                  tableSourceBuilder,
                  pivotClauseBuilder,
                  unpivotClauseBuilder,
                  tableSelectionWithJoinBuilder)
        {
            endJoin = new EndJoin<TJoinEndType>(statement, joinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            return endJoin.On(searchCondition);
        }
    }
}
