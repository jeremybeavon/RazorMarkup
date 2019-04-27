using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndQueryOperatorGroup<TEndType> : AbstractQueryStatement<QueryOperatorGroupBuilder, TEndType>,
        IEndQueryGroup<TEndType>
    {
        public EndQueryOperatorGroup(QueryOperatorGroupBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IQueryOperand<TEndType> Union()
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.Union());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.UnionAll());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.Except());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.Intersect());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.OrderBy(null), expression);
            return new OrderByCollate<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression)
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.Offset(null), expression);
            return new OffsetRow<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            Statement.Append((IEndQueryGroup<TEndType> input) => input.For());
            return new ForBrowseOrXml<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
