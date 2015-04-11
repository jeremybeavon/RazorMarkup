using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithJoin<TEndType> : EndFromClause<TEndType>, ITableSelectionWithJoin<TEndType>
    {
        public TableSelectionWithJoin(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("INNER"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerJoin());
            return new TableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("LEFT"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftJoin());
            return new TableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("RIGHT"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightJoin());
            return new TableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder("FULL"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullJoin());
            return new TableSourceWithJoinHint<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSource<TEndType> CrossJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" CROSS JOIN "));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.CrossJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public ITableSource<TEndType> CrossApplyJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" CROSS APPLY "));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.CrossApplyJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public ITableSource<TEndType> OuterApplyJoin()
        {
            Statement.Statements.Add(new RawStatementBuilder(" OUTER APPLY "));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.OuterApplyJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public IPivotClause<TEndType> Pivot()
        {
            throw new NotImplementedException();
        }
    }
}
