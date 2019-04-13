using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class QueryOperand<TEndType> : AbstractQueryStatement<ClauseBuilder, TEndType>, IQueryOperand<TEndType>,
        IClauseStart<IQueryOperand<TEndType>>
    {
        public QueryOperand(ExpressionBuilder expressionBuilder, string @operator, TEndType endClosure)
            : base(new QueryOperatorBuilder(expressionBuilder, @operator), endClosure)
        {
        }

        public QueryOperand(ClauseBuilder statement, TEndType endClosure)
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
            return new SelectClauseWithDistinct<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<IQueryGroupEnd<TEndType>> BeginQueryGroup()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.BeginQueryGroup());
            return new QueryOperatorGroupEnd<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement).AsOperand();
        }

        public IQueryOperand<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
