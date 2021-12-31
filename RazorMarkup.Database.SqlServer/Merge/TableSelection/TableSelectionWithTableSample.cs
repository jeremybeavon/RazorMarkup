using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableSample :
        CommonTableSelectionWithTableSample<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample>,
        ITableSelectionWithTableSample
    {
        public TableSelectionWithTableSample(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableHint.Create,
                TableSampleWithSystem.Create)
        {
        }

        public static ITableSelectionWithTableSample Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableSample(statement);
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            return new EndFromClause(Statement).On(searchCondition);
        }
    }
}
