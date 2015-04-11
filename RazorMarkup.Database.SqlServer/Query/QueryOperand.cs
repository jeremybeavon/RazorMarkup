using System;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class QueryOperand<TEndType> : AbstractQueryStatement<ClauseBuilder, TEndType>, IQueryOperand<TEndType>,
        IClauseStart<IQueryOperand<TEndType>>
    {
        public QueryOperand(string @operator, TEndType endClosure)
            : base(new QueryOperatorBuilder(@operator), endClosure)
        {
        }

        public QueryOperand(ClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithDistinct<TEndType> Select()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.Select());
            return new SelectClauseWithDistinct<TEndType>(EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<TEndType>> BeginOperatorGroup()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.BeginOperatorGroup());
            return new QueryOperatorGroupEnd<TEndType>(EndClosure, Statement.Expression).AsOperand().AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
