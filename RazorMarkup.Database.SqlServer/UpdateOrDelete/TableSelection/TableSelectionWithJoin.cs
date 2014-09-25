using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithJoin : EndFromClause, ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("INNER"));
            return new TableSourceWithJoinHint<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("LEFT"));
            return new TableSourceWithJoinHint<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("RIGHT"));
            return new TableSourceWithJoinHint<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("FULL"));
            return new TableSourceWithJoinHint<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSource CrossJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" CROSS JOIN "));
            return new TableSource(Statement);
        }

        public ITableSource CrossApplyJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" CROSS APPLY "));
            return new TableSource(Statement);
        }

        public ITableSource OuterApplyJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" OUTER APPLY "));
            return new TableSource(Statement);
        }

        public IPivotClause Pivot()
        {
            throw new NotImplementedException();
        }
    }
}
