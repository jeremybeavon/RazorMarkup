﻿using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    internal class TableSelectionWithTableHint : TableSelectionWithJoin,
        ITableSelectionWithTableHint
    {
        public TableSelectionWithTableHint(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableHint WithHint()
        {
            Statement.Append((ITableSelectionWithTableHint input) => input.WithHint());
            return new TableHint(Statement);
        }
    }
}
