﻿using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithAlias :
        CommonTableSelectionWithAlias<
            ITableSourceInJoin<ITableSelectionWithJoin>,
            ITableSource,
            IPivotClause,
            IUnpivotClause,
            ITableHint,
            ITableSampleWithSystem,
            ITableSelectionWithTableSample,
            ITableSelectionWithAlias>,
        ITableSelectionWithAlias
    {
        public TableSelectionWithAlias(FromClauseBuilder statement)
            : base(
                  statement,
                  TableSelectionWithJoin.CreateTableSourceInJoin,
                  TableSource.Create,
                  PivotClause.Create,
                  UnpivotClause.Create,
                  TableHint.Create,
                  TableSampleWithSystem.Create,
                  TableSelectionWithTableSample.Create)
        {
        }

        public static ITableSelectionWithAlias Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithAlias(statement);
        }
    }
}
