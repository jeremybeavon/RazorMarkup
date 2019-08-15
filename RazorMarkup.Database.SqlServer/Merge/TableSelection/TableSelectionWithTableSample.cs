using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using System.Linq.Expressions;
using System;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableSample :
        CommonTableSelectionWithTableSample<
            ITableSourceInJoin<ITableSelectionWithJoin>,
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
