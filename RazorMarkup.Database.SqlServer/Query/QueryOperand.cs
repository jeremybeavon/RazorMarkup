using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class QueryOperand<TEndType> : AbstractQueryStatement<ClauseBuilder, TEndType>, IQueryOperand<TEndType>,
        IClauseStart<IQueryOperand<TEndType>>
    {
        public QueryOperand(Expression initialExpression, string @operator, TEndType endClosure)
            : base(new QueryOperatorBuilder(initialExpression, @operator), endClosure)
        {
        }

        public QueryOperand(SelectClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public QueryOperand(QueryOperatorGroupBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public QueryOperand(SubqueryBuilder statement, TEndType endClosure)
            : base(statement.Select, endClosure)
        {
        }

        public ISelectClauseWithDistinct<TEndType> Select()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.Select());
            return new SelectClauseWithDistinct<TEndType>(Expression, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<TEndType>> BeginOperatorGroup()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.BeginOperatorGroup());
            return new QueryOperatorGroupEnd<TEndType>(Expression, EndClosure).AsOperand().AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
