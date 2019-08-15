using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class TableSelectionWithAdditionalTableHint :
        CommonTableSelectionWithAdditionalTableHint<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            IAdditionalTableHint,
            ITableSelectionWithAdditionalTableHint>,
        ITableSelectionWithAdditionalTableHint
    {
        public TableSelectionWithAdditionalTableHint(FromClauseBuilder statement)
            : base(
                  statement,
                  TableSelectionWithJoin.CreateTableSourceInJoin,
                  TableSource.Create,
                  PivotClause.Create,
                  UnpivotClause.Create,
                  AdditionalTableHint.Create)
        {
        }

        public static ITableSelectionWithAdditionalTableHint Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithAdditionalTableHint(statement);
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            return new EndFromClause(Statement).On(searchCondition);
        }
    }
}
