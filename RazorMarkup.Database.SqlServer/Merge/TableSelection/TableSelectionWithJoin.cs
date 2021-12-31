using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithJoin :
        CommonTableSelectionWithJoin<
            ITableSourceInJoinWithTableSelection,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin>,
        ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create)
        {
        }

        public static ITableSelectionWithJoin Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithJoin(statement);
        }

        public static ITableSourceInJoinWithTableSelection CreateTableSourceInJoin(FromClauseBuilder statement)
        {
            return new TableSourceInJoin(statement, Create(statement));
        }

        public IMergeWhen On(Expression<Func<bool>> searchCondition)
        {
            return new EndFromClause(Statement).On(searchCondition);
        }
    }
}
