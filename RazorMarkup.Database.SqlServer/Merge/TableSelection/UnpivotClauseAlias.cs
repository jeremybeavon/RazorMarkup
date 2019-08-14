using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal sealed class UnpivotClauseAlias :
        CommonUnpivotClauseAlias<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableSelectionWithJoin,
            IUnpivotClauseAlias>,
        IUnpivotClauseAlias
    {
        public UnpivotClauseAlias(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableSelectionWithJoin.Create)
        {
        }

        public static IUnpivotClauseAlias Create(FromClauseBuilder statement)
        {
            return new UnpivotClauseAlias(statement);
        }
    }
}
