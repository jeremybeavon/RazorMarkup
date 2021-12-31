using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins;
using System;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection
{
    internal class TableSelectionWithJoin : EndFromClause, ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public ITableSourceInJoinWithTableSelection InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            return new TableSourceInJoin(Statement, this);
        }

        public ITableSourceInJoinWithTableSelection LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            return new TableSourceInJoin(Statement, this);
        }

        public ITableSourceInJoinWithTableSelection RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            return new TableSourceInJoin(Statement, this);
        }

        public ITableSourceInJoinWithTableSelection FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            return new TableSourceInJoin(Statement, this);
        }

        public ITableSource CrossJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS JOIN "));
            return new TableSource(Statement);
        }

        public ITableSource CrossApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS APPLY "));
            return new TableSource(Statement);
        }

        public ITableSource OuterApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " OUTER APPLY "));
            return new TableSource(Statement);
        }

        public IPivotClause Pivot()
        {
            throw new NotImplementedException();
        }
    }
}
