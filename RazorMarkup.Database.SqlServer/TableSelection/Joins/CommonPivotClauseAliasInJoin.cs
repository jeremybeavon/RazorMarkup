using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection.Joins
{
    internal abstract class CommonPivotClauseAliasInJoin<
        TJoinEndType,
        TTableSourceInJoin,
        TTableSource,
        TPivotClause,
        TUnpivotClause,
        TTableSelectionWithJoin,
        TCommonPivotClauseAlias> :
        CommonPivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin,
            TCommonPivotClauseAlias>,
        ICommonPivotClauseAliasInJoin<
            TJoinEndType,
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
        where TCommonPivotClauseAlias : ICommonPivotClauseAlias<
            TTableSourceInJoin,
            TTableSource,
            TPivotClause,
            TUnpivotClause,
            TTableSelectionWithJoin>
    {
        private readonly EndJoin<TJoinEndType> endJoin;

        protected CommonPivotClauseAliasInJoin(
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
