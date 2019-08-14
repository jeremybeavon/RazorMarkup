﻿using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithTableHint :
        CommonTableSelectionWithTableHint<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSelectionWithTableHint>,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(
                statement,
                TableSelectionWithJoin.CreateTableSourceInJoin,
                TableSource.Create,
                PivotClause.Create,
                UnpivotClause.Create,
                TableHint.Create)
        {
        }

        public static ITableSelectionWithTableHint Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithTableHint(statement);
        }
    }
}
